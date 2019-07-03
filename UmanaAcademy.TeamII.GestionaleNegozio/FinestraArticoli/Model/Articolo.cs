using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
    class Articolo
    {

        public string Type { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public bool Visibility{ get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public double Categories { get; set; }

    }
}
