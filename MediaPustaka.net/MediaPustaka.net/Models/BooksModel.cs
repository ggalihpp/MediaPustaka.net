using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaPustaka.net.Models
{
    public class BooksModel
    {
        public int Id_Book { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public double Rating { get; set; }

        public string Sinopis { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string Shelves { get; set; }
        
        public string Img
        {
            get
            {
                return Title.ToLower().Replace(" ", "-") + ".jpg";
            }
        }
    }
}