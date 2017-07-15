using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaPustaka.net.Models
{
    public class ShoppingCart
    {
        public int ID_Cart { get; set; }

        public string _title { get; set; }

        public decimal _price { get; set; }

        public float _discount { get; set; }

        public string _genre { get; set; }

        public string _shelves { get; set; }

        public string Username { get; set; }

        public int Book_ID { get; set; }

        public decimal PriceAD { get; set; }
    }
}