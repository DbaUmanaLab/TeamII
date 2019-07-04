using CsvHelper;
using FinestraArticoli.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinestraArticoli
{
    public partial class VisualWindow : Form
    {
        private List<Articolo> articoli;
        public VisualWindow()
        {
            InitializeComponent();

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<Articolo>().ToList();
                dataGV.DataSource = articoli;
            }
        }
        private void SaveProductsButton_Click(object sender, EventArgs e)
        {
            Store.SaveDataGrid(saveFileDialog, articoli);

        }

        private void VisualLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
