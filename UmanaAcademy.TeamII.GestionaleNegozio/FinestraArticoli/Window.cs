using FinestraArticoli.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;

namespace FinestraArticoli
{
    public partial class window : Form
    {
        private List<Articolo> articoli;

        public window()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisualButton_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<Articolo>().ToList();
            }
        }
    }
}
