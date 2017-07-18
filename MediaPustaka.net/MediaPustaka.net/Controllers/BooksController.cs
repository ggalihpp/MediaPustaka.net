using MediaPustaka.net.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPustaka.net.Controllers
{
    public class BooksController : Controller
    {
        private OperationDataContext context;

        public BooksController()
        {
            context = new OperationDataContext();   
        }


        // GET: Books
        public ActionResult Index()
        {
            // Create the  BooksList Variable
            List<BooksModel> BookList = new List<BooksModel>();

            // perform Linq
            var query = from Book in context.Books select Book;

            Populate(BookList, query);

            List<string> Option = new List<string>();
            Option.Add("Author");
            Option.Add("Genre");
            Option.Add("Title");

            ViewBag.Option = Option;


            return View(BookList);
        }

       



        //the first parameter is the option that we choose and the second parameter will use the textbox value  
        public ActionResult Search(string option, string search)
        {

            List<string> Option = new List<string>();
            Option.Add("Author");
            Option.Add("Genre");
            Option.Add("Title");

            ViewBag.Option = Option;
          
            if (option == "Author")
                {
                
                    List<BooksModel> BookList = new List<BooksModel>();
                    var Author = from Book in context.Books.Where(x => x.Author.Contains(search)) select Book;
                    Populate(BookList, Author);

                    return View(BookList);
                }
                else if (option == "Genre")
                {
                    List<BooksModel> BookList = new List<BooksModel>();
                    var Genre = from Book in context.Books.Where(x => x.Genre.Contains(search)) select Book;
                    Populate(BookList, Genre);

                    return View(BookList);
                }
                else if (option == "Title")
                {
                    List<BooksModel> BookList = new List<BooksModel>();
                    var Title = from Book in context.Books.Where(x => x.Title.Contains(search)) select Book;
                    Populate(BookList, Title);

                    return View(BookList);
                }
                else
                {
                    List<BooksModel> BookList = new List<BooksModel>();
                    var query = from Book in context.Books select Book;
                    Populate(BookList, query);

                    return View(BookList);
                }
            
        }



        public ActionResult Create()
        {
           if(Session["Username"].ToString() == "admin")
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

        public ActionResult Add(int id)
        {
            try
            {
                List<ShoppingCart> Cart = new List<ShoppingCart>();
                var query = from Book in context.Books where Book.ID_Book == id select Book;
                var book = query.ToList();

                foreach (var z in book)
                {
                    Cart cart = new Cart()
                    {
                        _title = z.Title,
                        _price = z.Price,
                        _discount = 0,
                        _genre = z.Genre,
                        Username = Session["Username"].ToString(),
                        Book_ID = z.ID_Book,
                        priceAD = z.Price - (z.Price * 0),
                        _shelves = z.Shelves,
                    };
                    context.Carts.InsertOnSubmit(cart);
                    context.SubmitChanges();

                };

                Book update = context.Books.Single(e => e.ID_Book == id);
                update.Stock -= 1;
                context.SubmitChanges();

                return RedirectToAction("Index", "Cart");
            }
            catch
            {
                return RedirectToAction("PleaseLogin", "Home");
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
    }


   

}