using MediaPustaka.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPustaka.net.Controllers
{
    public class AdminController : Controller
    {
        private OperationDataContext context;

        public AdminController()
        {
            context = new OperationDataContext();
        }

        // GET: Admin
        public ActionResult Index()
        {
            if (Session["Username"].ToString() == "admin")
            {
                return View();
            }
            else
            {
                return RedirectToAction("AdminOnly", "Home");
            }
        }

        #region Book List
        public ActionResult Book()
        {
            // Create the  BooksList Variable
            List<BooksModel> BookList = new List<BooksModel>();

            // perform Linq
            var query = from Book in context.Books select Book;

            Populate(BookList, query);


            return View(BookList);
        }

        public ActionResult Create()
        {
            if (Session["Username"].ToString() == "admin")
            {
                return View();
            }
            else
            {
                return RedirectToAction("AdminOnly", "Home");
            }
        }

        [HttpPost]
        public ActionResult Create(BooksModel Z)
        {
            try
            {
                Book book = new Book()
                {
                    Title = Z.Title,
                    Author = Z.Author,
                    Genre = Z.Genre,
                    Rating = Z.Rating,
                    Sinopsis = Z.Sinopis,
                    Price = Z.Price,
                    Stock = Z.Stock,
                    Shelves = Z.Shelves

                };

                context.Books.InsertOnSubmit(book);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Z);
            }
        }

        private static void Populate(List<BooksModel> BookList, IQueryable<Book> query)
        {
            //store those thing to list
            var books = query.ToList();


            //Add Books to Booklist
            foreach (var x in books)
            {
                BookList.Add(new BooksModel()
                {
                    Id_Book = x.ID_Book,
                    Title = x.Title,
                    Author = x.Author,
                    Genre = x.Genre,
                    Sinopis = x.Sinopsis,
                    Shelves = x.Shelves,
                    Stock = (int)x.Stock,
                    Rating = (double)x.Rating,
                    Price = (decimal)x.Price
                });

            }
        }
        #endregion

       
        public ActionResult Cart()
        {
            #region GET DATA FROM DB
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

            return View(CartList);
        }
        

        #region Invoice

        public ActionResult Invoice()
        {
            // Create the  BooksList Variable
            List<InvoiceModel> Invoice = new List<InvoiceModel>();

            // perform Linq
            var query = from xxx in context.Invoices select xxx;
         
            //store those thing to list
            var CS = query.ToList();



            //Add Books to Booklist
            foreach (var x in CS)
            {

                Invoice.Add(new InvoiceModel()
                {
                    Diskon = x.Diskon_global,
                    ID = x.Order_id,
                    Jumlah_Buku = x.Jumlah_buku,
                    Jumlah_Harga = x.Jumlah_harga,
                    Kasir = x.Kasir,
                    Tanggal = x.Tanggal,
                    Total = x.Total,
                    User = x._username,
                    Pembayaran = x.Pembayaran
                });
            }

            return View(Invoice);
        }


        #endregion

        #region User

        public ActionResult Customer()
        {
            // Create the  BooksList Variable
            List<UserModel> User = new List<UserModel>();

            // perform Linq
            var query = from xxx in context.Admins select xxx;

            //store those thing to list
            var CS = query.ToList();

            //Add Books to Booklist
            foreach (var x in CS)
            {
                User.Add(new UserModel()
                {
                   Id = x.ID_Admin,
                   EmailID = x.Email,
                   Status = (bool)x.Status,
                   Password = x.Password,
                   username = x.Name

                });
            }

            return View(User);
        }

        #endregion






    #endregion

    }
}