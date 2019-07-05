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
        public static void VisualSaveDataGrid(SaveFileDialog saveFileDialog, List<Articolo> articoli)
        {
            saveFileDialog.FileName = "Files\\Magazzino\\products.csv";
            using (var writer = new StreamWriter(saveFileDialog.FileName))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.Delimiter = ",";
                csvWriter.Flush();
                csvWriter.WriteRecords<Articolo>(articoli);
            }
        }
        public static bool SaveDataGrid(SaveFileDialog saveFileDialog, List<OrdineArticolo> articoliTemp, bool add)
        {
            List<Articolo> articoli = new List<Articolo>();
            bool saveOK = true;
            foreach (OrdineArticolo ordArt in articoliTemp)
            {
                if (add)
                {
                    Articolo art = new Articolo()
                    {
                        Type = ordArt.Type,
                        Sku = ordArt.Sku,
                        Name = ordArt.Name,
                        Visibility = ordArt.Visibility,
                        Description = ordArt.Description,
                        Stock = ordArt.Stock + ordArt.Quantity,
                        Price = ordArt.Price,
                        Categories = ordArt.Categories
                    };
                    articoli.Add(art);
                }
                else
                {
                    Articolo art = new Articolo()
                    {
                        Type = ordArt.Type,
                        Sku = ordArt.Sku,
                        Name = ordArt.Name,
                        Visibility = ordArt.Visibility,
                        Description = ordArt.Description,
                        Stock = ordArt.Stock - ordArt.Quantity,
                        Price = ordArt.Price,
                        Categories = ordArt.Categories
                    };
                    articoli.Add(art);
                    if (art.Stock < 0)
                        saveOK = false;
                }
            }
            if (saveOK)
            {
                saveFileDialog.FileName = "Files\\Magazzino\\products.csv";
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                using (var csvWriter = new CsvWriter(writer))
                {
                    csvWriter.Configuration.Delimiter = ",";
                    csvWriter.Flush();
                    csvWriter.WriteRecords<Articolo>(articoli);
                }
            }
            else
            {
                MessageBox.Show("OPERAZIONE IMPOSSIBILE DA ESEGUIRE.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saveOK;
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
    }
}
