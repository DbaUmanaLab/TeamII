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

<<<<<<< HEAD
        public static void SaveDataGrid(SaveFileDialog saveFileDialog, List<Articolo> articoli)
=======
        public void SaveDataGrid(SaveFileDialog saveFileDialog, Articolo[] articoli)
>>>>>>> bf3a731d1c1d101074d039103387ef9ab23206a5
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (!DialogResult.OK.Equals(result))
                return;
            using (var writer = new StreamWriter(saveFileDialog.FileName))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.Delimiter = ",";
                csvWriter.WriteRecords<Articolo>(articoli);
            }
        }
    }
}
