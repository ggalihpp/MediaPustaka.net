using MediaPustaka.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPustaka.net.Controllers
{
    public class CartController : Controller
    {
        private OperationDataContext context;

        public CartController()
        {
            context = new OperationDataContext();
        }

        // GET: Cart
        public ActionResult Index()
        {
            // Create the  BooksList Variable
            List<ShoppingCart> CartList = new List<ShoppingCart>();

            // perform Linq
            var query = from Cart in context.Carts select Cart;

            //store those thing to list
            var CS = query.ToList();


            //Add Books to Booklist
            foreach (var x in CS)
            {
                CartList.Add(new ShoppingCart()
                {
                    ID_Cart = x.ID_Cart,
                    _discount = (float)x._discount,
                    _genre = x._genre,
                    _price = (decimal)x._price,
                    _shelves = x._shelves,
                    _title = x._title
                });
            }

            var sum = context.Carts.Sum(q => q._price);

            ViewBag.SUM = sum;


            return View(CartList);
        }

        public ActionResult Delete(int id)
        {
            ShoppingCart cart = context.Carts.Where(x => x.ID_Cart == id).Select(
                x => new ShoppingCart()
                {
                    ID_Cart = x.ID_Cart,
                    _title = x._title,
                    _discount = (float)x._discount,
                    _genre = x._genre,
                    _price = (decimal)x._price,
                    _shelves = x._shelves
                }).SingleOrDefault();

            
            return View(cart);

        }

        [HttpPost]
        public ActionResult Delete(int id, ShoppingCart Y)
        {
            ViewBag.Mes = "";
            ShoppingCart X = Y;

            try
            { 
                Cart cart = context.Carts.Where(xx => xx.ID_Cart == Y.ID_Cart).Single<Cart>();

                context.Carts.DeleteOnSubmit(cart);
                context.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Mes = "Error!";
                return View(X);
            }
        }
    }
}