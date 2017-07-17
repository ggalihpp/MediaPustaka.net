using MediaPustaka.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPustaka.net.Controllers
{
    public class UserController : Controller
    {
        private OperationDataContext context;

        // GET: User
        public UserController()
        {
            context = new OperationDataContext();

        }


        [HttpGet]
        public ActionResult Registration()
        {
            ViewBag.Category = "Registration";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(UserModel user)
        {
            bool Status = false;
            string message = "";
            //
            //Model Validation
            if (ModelState.IsValid)
            {

                #region IF Username is already exist
                var isExist = IsUsernameExist(user.username);
                if (isExist)
                {
                    ModelState.AddModelError("UsernameExist", "Username Already Exist");
                    return View(user);
                }
                #endregion

                #region Password Hashing
                user.Password = Crypto.Hash(user.Password);
                user.ConfirmPassword = Crypto.Hash(user.ConfirmPassword);
                #endregion

                #region Save to Database

                Admin registration = new Admin()
                {
                    Name = user.username,
                    Email = user.EmailID,
                    Password = user.Password
                };

                context.Admins.InsertOnSubmit(registration);
                context.SubmitChanges();

                #endregion

                return RedirectToAction("Login", "User");
            }
            else
            {
                message = "Invalid Request";
                return View();
            }


        }

        //Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        //Login Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel login, string ReturnUrl = "")
        {

            string message = "";
            {
                var v = context.Admins.Where(a => a.Name == login.username).FirstOrDefault();
                if (v != null)
                {
                    if (string.Compare(Crypto.Hash(login.Password), v.Password) == 0)
                    {
                        Session["Username"] = login.username;

                        if (Url.IsLocalUrl(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Loading", "Home");
                        }

                    }
                    else
                    {
                        message = "INVALID PASSWORD";
                    }

                }
                else
                {
                    message = "INVALID USERNAME";
                }
            }
            ViewBag.Message = message;
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Response.Cache.SetNoStore();
            Response.CacheControl = "no-cache";

            return RedirectToAction("Login", "User");
        }

        [NonAction]
        public bool IsUsernameExist(string username)
        {
            
                var x = context.Admins.Where(a => a.Name == username).FirstOrDefault();
                return x == null ? false : true;

        }
    }
}
