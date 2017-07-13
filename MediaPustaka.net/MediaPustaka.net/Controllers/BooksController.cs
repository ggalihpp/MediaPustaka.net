﻿using MediaPustaka.net.Models;
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


            return View(BookList);
        }

        public ActionResult Create()
        {
            return View();
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

        public ActionResult Edit(int id)
        {
            ViewBag.ID = id;

            return View();
           
        }




    }
}