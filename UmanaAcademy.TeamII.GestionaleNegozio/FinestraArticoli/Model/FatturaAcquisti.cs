using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
    public class FatturaAcquisti
    {

            
            List<int> Quantità;
            List<Articolo> Articoli;
            List<double> Prezzi;

            public FatturaAcquisti(string cliente, int quantità, List<Articolo> articoli)
            {
                Azienda = "Te Fornise Mi S.P.A \n Via Delle Zoccole n.69 \n  3140 Venegazù (TV) \n P.IVA 123454569 \n Tel. 369.2244699 ";
                Cliente = "Mi Ti & Toni S.R.L. \n Via Osteria n.1000 \n  3140 Camalò (TV) \n P.IVA 123456789 \n Tel. 369.2244555 ";
                this.Quantità = new List<int>();
                this.Articoli = articoli;

                this.Prezzi = new List<double>();
                foreach (Articolo articolo in articoli)
                    this.Prezzi.Add(articolo.Price ?? 0);

            }

            public string Azienda { get; set; }
            public string Cliente { get; set; }

            public double Totale
            {
                get { return Totale; }

                set { Totale = Prezzi.Sum(); }

            }

            public DateTime Data
            {
                get { return DateTime.Today; }

                set { Data = DateTime.Today; }

            }

        
    }
}

