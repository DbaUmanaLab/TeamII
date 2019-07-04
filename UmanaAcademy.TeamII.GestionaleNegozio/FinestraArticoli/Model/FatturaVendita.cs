using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
    
        public class FatturaVendita
        {
            string Customer;
            List<int> Quantity;
            List<Articolo> Articles;
            List<double> Prices;

            public FatturaVendita(string customer, List<int> quantity, List<Articolo> articles)
            {
                Company = "Mi Ti & Toni \n Via Osteria n.1000 \n  3140 Camalò (TV) \n P.IVA 123456789 \n Tel. 369.2244555 ";
                this.Customer = customer;
                this.Quantity = quantity;
                this.Articles = articles;

                this.Prices = new List<double>();
                foreach (Articolo articolo in articles)
                    this.Prices.Add(articolo.Price ?? 0);

            }

            public string Company { get; set; }

            public double Total
            {
                get { return Total; }

                set { Total = Prices.Sum(); }

            }

            public DateTime Date
            {
                get { return DateTime.Today; }

                set { Date = DateTime.Today; }

            }

        }
    
}
