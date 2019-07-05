using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinestraArticoli.Model
{
    public class Mail
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTime DateTime { get; set; }

        public string MailObj { get; set; }

        public List<OrdineArticolo> Ordine { get; set; }

        public Mail()
        {
            DateTime = DateTime.Today;
        }

        public override string ToString()
        {
            string mail = "";
            mail = mail + "From: Richieste@MiTiToni.com";
            mail = mail + "\nTo: Fornitura@FornitoreNegozio.com";
            mail = mail + $"\nObject: Rifornimento merce del {DateTime.Date.Day}/{DateTime.Date.Month}/{DateTime.Date.Year}";
            mail = mail + "\n\nLista articoli da fornire:";
            foreach (OrdineArticolo articolo in Ordine)
            {
                mail = mail + $"\nNome: {articolo.Name} - Quantità: {articolo.Quantity}";
            }
            mail = mail + "\nGrazie e Arrivederci.\nMi, Ti e Toni";
            return mail;
        }
    }
}
