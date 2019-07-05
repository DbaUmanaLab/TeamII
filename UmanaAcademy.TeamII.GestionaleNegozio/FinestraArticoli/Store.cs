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
        public static void GetMail(List<OrdineArticolo> ordine)
        {
            var mail = new Mail()
            {
                From = "Richieste@MiTiToni.com",
                To = "Fornitura@FornitoreNegozio.com",
                Ordine = ordine
            };
            //string path = $"Files\\MailRifornimento\\{mail.DateTime.Date.Day}{mail.DateTime.Date.Month}/{mail.DateTime.Date.Year}_{mail.DateTime.Date.Hour}{mail.DateTime.Date.Minute}";
            //File.Create(path);
            //File.WriteAllText(path, mail.ToString());
        }
    }
}
