using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
     public  class OrdineArticolo
    {
        Articolo articolo = new Articolo();

        public string SupplierMail { get; set; }

        public string SupplierName { get; set; }

        public string buyerName { get; set; }

        public int Quantity { get; set; }
        
    }
}
