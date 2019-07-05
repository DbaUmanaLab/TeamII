using CsvHelper;
using FinestraArticoli.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinestraArticoli
{
    public class Store
    {
        //public void MarkOutOfStockProducts(List<Articolo> articles)
        //{
        //    foreach (Articolo article in articles)  //article diventa la variabile di controllo di Articolo//
        //    {
        //        if (article.Stock < 20)
        //        {
        //            Console.WriteLine($"Articolo in esaurimento. Contatta fornitore per {article.Type},{article.Name},{article.Sku} ");
        //            Console.WriteLine($" {article.Type},{article.Name},{article.Sku} presente in {article.Stock} esemplari  ");

        //            article.OutOfStock = true;

        //        }
        //        else if (article.Stock >= 20 || article.Stock < 30)
        //        {
        //            Console.WriteLine($"{article.Type},{article.Name},{article.Sku} presente ma in esaurimento, contattare il fornitore a breve \n ");

        //            Console.WriteLine($" {article.Type},{article.Name},{article.Sku} presente in {article.Stock} esemplari  ");

        //            article.OutOfStock = true;
        //        }
        //        else if (article.Stock >= 30)
        //        {
        //            Console.WriteLine($" {article.Type},{article.Name},{article.Sku} presente in {article.Stock} esemplari  ");
        //            article.OutOfStock = false;
        //        }
        //    }

        //    foreach (Articolo article in articles)

        //    {
        //        if (article.OutOfStock == true)
        //        {
        //            if (article.Stock < 20)
        //                article.StockRunningOut = "Contattare il fornitore con urgenza";
        //        }
        //        else
        //        {
        //            article.StockRunningOut = "Articolo in via di esaurimento. Contattare il fornitore a breve";
        //        }
        //    }
        //}
        public static void SaveDataGrid(SaveFileDialog saveFileDialog, List<Articolo> articoli)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (!DialogResult.OK.Equals(result))
                return;
            //saveFileDialog.FileName = "Files\\Magazzino\\productsTemp.csv";
            using (var writer = new StreamWriter(saveFileDialog.FileName))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.Delimiter = ",";
                csvWriter.WriteRecords<Articolo>(articoli);
            }
        }
        public Mail GetMail(List<OrdineArticolo> ordine)
        {
            string dateTime = DateTime.Today.ToString();
            var mail = new Mail();
            mail.From = "MiTiToni@gmail.com";
            mail.To = "FornitoreNegozio@gmail.com";
            mail.MailObj = "Rifornimento merce del " + dateTime;
            foreach (OrdineArticolo articolo in ordine)
            {

            }
            return mail;
        }
        internal static void SaveDataGrid(object saveFileDialog, List<Articolo> articoli)
        {
            throw new NotImplementedException();
        }
    }
}
