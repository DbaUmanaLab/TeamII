using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
    public    class Articolo
    {
        [Index(0)]
        public string Type { get; set; }

        [Index(1)]
        public string Sku { get; set; }

        [Index(2)]
        public string Name { get; set; }

        [Index(5)]
        public string Visibility{ get; set; }

        [Index(7)]
        public string Description { get; set; }

        [Index(12)]
        public int? Stock { get; set; }

        [Index(15)]
        public double? Price { get; set; }

        [Index(21)]
        public double? Categories { get; set; }
        //public bool OutOfStock { get; set; }

        //public string StockRunningOut { get; set; }

    }
}
