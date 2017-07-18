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
            ViewBag.Category = "Details ";

            try
            {
                #region GET DATA FROM DB
                // Create the  BooksList Variable
                List<ShoppingCart> CartList = new List<ShoppingCart>();

                // perform Linq
                var query = from Cart in context.Carts where Cart.Username == Session["Username"].ToString() select Cart;

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
                        _title = x._title,
                        Book_ID = x.Book_ID,
                        PriceAD = x.priceAD,
                        Username = x.Username,
                    });
                }

                int Diskon_global = (from x in context.AdminPanels select x.Diskon_global).FirstOrDefault();
                var qq = (from x in context.Carts where x.Username == Session["Username"].ToString() select x);
                var sum2 = qq.Sum(q => q._price);
                float Diskonan = (float)(sum2 * Diskon_global / 100);

                ViewBag.Discount = Diskon_global;
                ViewBag.SUM = sum2;
                ViewBag.TOTAL = (float)sum2 - Diskonan;
                    


                return View(CartList);
                #endregion
            }
            catch
            {

                return RedirectToAction("PleaseLogin", "Home");
            }

     


        }

        public ActionResult Delete(int id)
        {
            try
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
            catch
            {
                return RedirectToAction("PleaseLogin", "Home");
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, ShoppingCart Y)
        {
            ViewBag.Mes = "";
           

            try
            { 
                Cart cart = context.Carts.Where(xx => xx.ID_Cart == id).Single<Cart>();
                Book update = context.Books.Single(e => e.ID_Book == cart.Book_ID);

                context.Carts.DeleteOnSubmit(cart);
                update.Stock += 1;
                context.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Mes = "Error!";
                return View(Y);
            }
        }

        public ActionResult Details(int id)
        {
            ViewBag.Category = "Details";   
            ViewBag.ID = id;

            BooksModel Detail = context.Books.Where(x => x.ID_Book == id).Select(
                x => new BooksModel()
                {
                    Id_Book = x.ID_Book,
                    Title = x.Title,
                    Sinopis = x.Sinopsis,
                    Shelves = x.Shelves,
                    Price = (decimal)x.Price,
                    Rating = (double)x.Rating,
                    Stock = (int)x.Stock,
                    Author = x.Author,
                    Genre = x.Genre
                }).SingleOrDefault();



            return View(Detail);

        }

        public ActionResult Checkout(string Pembayaran)
        {
            List<string> Option = new List<string>();
            Option.Add("Cash");
            Option.Add("Credit Card");
            Option.Add("Debit");

            ViewBag.Pemb = Option;

            int Diskon_global = (from x in context.AdminPanels select x.Diskon_global).FirstOrDefault(); 
            #region Random Cashier (sorry :(()
      
            List<string> sumber = new List<string>()
                {
                   "A1",
                   "B2",
                   "C3",
                   "D4"
                };

            int l = sumber.Count;
            Random r = new Random();
            int xxx = r.Next(l);
            var Cashier = sumber[xxx];

            #endregion

            try
            {

                #region Insert Data to Checkout
                int count = (from x in context.Carts where x.Username == Session["Username"].ToString() select x).Count();
                var qq = (from x in context.Carts where x.Username == Session["Username"].ToString() select x);
                var sum2 = qq.Sum(q => q._price);
                var sum = context.Carts.Sum(q => q._price);
                float Diskonan = (float)(sum2 * Diskon_global / 100);
                Invoice inv = new Invoice()
                {
                    Tanggal = DateTime.Now,
                    _username = Session["Username"].ToString(),
                    Diskon_global = Diskon_global,
                    Jumlah_buku = count,
                    Jumlah_harga = sum2,
                    Total = (float)sum2 - Diskonan,
                    Kasir = Cashier,
                    Pembayaran = "Cash"
                };
                context.Invoices.InsertOnSubmit(inv);
                context.SubmitChanges();
                #endregion

                #region Delete From Cart
                var query = from Cart in context.Carts where Cart.Username == Session["Username"].ToString() select Cart;
      
                context.Carts.DeleteAllOnSubmit(query);
                context.SubmitChanges();
                #endregion

                Session["Diskon"] = Diskonan;

                return RedirectToAction("Index", "Invoice");
            }
            catch
            {
                return RedirectToAction("PleaseLogin", "Home");
            }

        }
    }
}