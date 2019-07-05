using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
     public  class OrdineArticolo
    {

        [Index(0)]
        public string Type { get; set; }

        [Index(1)]
        public string Sku { get; set; }

        [Index(2)]
        public string Name { get; set; }

        //[Index(5)]
        [Index(3)]
        public string Visibility { get; set; }

        //[Index(7)]
        [Index(4)]
        public string Description { get; set; }

        //[Index(12)]
        [Index(5)]
        public int? Stock { get; set; }

        //[Index(22)]
        [Index(6)]
        public double? Price { get; set; }

        //[Index(23)]
        [Index(7)]
        public string Categories { get; set; }

        //public string SupplierMail { get; set; }

        //public string SupplierName { get; set; }

        //public string buyerName { get; set; }

        public int Quantity { get; set; }
        
    }
}
