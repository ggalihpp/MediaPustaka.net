﻿using MediaPustaka.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPustaka.net.Controllers
{
    public class InvoiceController : Controller
    {
        private OperationDataContext context;
        

        public InvoiceController()
        {
            context = new OperationDataContext();
        }

        // GET: Invoice
        public ActionResult Index()
        {
            try
            {
                // Create the  BooksList Variable
                List<InvoiceModel> Invoice = new List<InvoiceModel>();

                // perform Linq
                var query = from xxx in context.Invoices where xxx._username == Session["Username"].ToString() select xxx;
                var user = from Z in context.Admins where Z.Name == Session["Username"].ToString() select Z.Email;
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

                ViewBag.Email = user;

                return View(Invoice);
            }
            catch
            {
                return RedirectToAction("PleaseLogin", "Home");
            }



        }
    }
}