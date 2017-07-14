using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaPustaka.net.Models
{
    public class InvoiceModel
    {
        public int ID { get; set; }

        public string User { get; set; }

        public int Jumlah_Buku { get; set; }

        public decimal Jumlah_Harga { get; set; }

        public decimal Diskon { get; set; }

        public double Total { get; set; }

        public string Kasir { get; set; }

        public DateTime Tanggal { get; set; }
    }
}