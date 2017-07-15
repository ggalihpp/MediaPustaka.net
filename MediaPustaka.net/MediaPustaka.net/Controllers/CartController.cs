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
        public int Diskon_global = 20;

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
                    _title = x._title,
                    Book_ID = x.Book_ID,
                    PriceAD = x.priceAD,
                    Username = x.Username,
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
           

            try
            { 
                Cart cart = context.Carts.Where(xx => xx.ID_Cart == id).Single<Cart>();
               
                context.Carts.DeleteOnSubmit(cart);
                context.SubmitChanges();

                //Book update = context.Books.Single(e => e.ID_Book == id);
                //update.Stock += 1;
                //context.SubmitChanges();

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

        public ActionResult Checkout()
        {               
            int count = (from x in context.Carts select x).Count();
            var sum = context.Carts.Sum(q => q._price);
                       
                Invoice inv = new Invoice()
                {
                    Tanggal = DateTime.Now,
                    _username = "Lexi",
                    Diskon_global = Diskon_global,
                    Jumlah_buku = count,
                    Jumlah_harga = (decimal)sum,
                    Total = ((double)sum - ((double)sum * (double)(Diskon_global / 100 ))),
                    Kasir = "B2",
                    Pembayaran = "Cash"
                };
                context.Invoices.InsertOnSubmit(inv);
                context.SubmitChanges();

            

            return RedirectToAction("Index", "Invoice");
        }
    }
}