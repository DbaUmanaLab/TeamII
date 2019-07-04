using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
    public class FatturaAcquisti
    {
        
            
            List<int> Quantity;
            List<Articolo> Articles;
            List<double> Prices;

            public FatturaAcquisti(string customer, List<Articolo> articles, List<int> quantity)
            {
                Company = "Te Fornise Mi S.P.A \n Via Delle Zoccole n.69 \n  3140 Venegazù (TV) \n P.IVA 123454569 \n Tel. 369.2244699 ";
                Customer = "Mi Ti & Toni S.R.L. \n Via Osteria n.1000 \n  3140 Camalò (TV) \n P.IVA 123456789 \n Tel. 369.2244555 ";
                this.Quantity = quantity;
                this.Articles = articles;

                this.Prices = new List<double>();
                foreach (Articolo articolo in articles)
                    this.Prices.Add(articolo.Price ?? 0);

            }

            public string Company { get; set; }
            public string Customer { get; set; }

            public double Total
            {
                get { return Total; }

                set { Total = Prices.Sum(); }

            }

            public DateTime Date
            {
                get { return DateTime.Today; }

                set { Date= DateTime.Today; }

            }

        
    }
}

