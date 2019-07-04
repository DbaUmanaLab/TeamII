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

            this.visualDataGV.CellFormatting += this.VisualDataGV_CellFormatting;

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<ArticoloMap>();
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<Articolo>().ToList();
                visualDataGV.DataSource = articoli;
            }
        }
        private void SaveProductsButton_Click(object sender, EventArgs e)
        {
            Store.SaveDataGrid(saveFileDialog, articoli);
        }

        private void VisualDataGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Articolo articolo = visualDataGV.Rows[e.RowIndex].DataBoundItem as Articolo;

            if (articolo.Stock <= 10 || articolo.Stock == null)
            {
                visualDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                e.CellStyle.BackColor = Color.Red;
            }
            else if (articolo.Stock > 10 && articolo.Stock <= 50)
            {
                visualDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                e.CellStyle.BackColor = Color.Yellow;
            }
            else
            {
                visualDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                e.CellStyle.BackColor = Color.White;
            }
        }

        private void VisualLabel_Click(object sender, EventArgs e)
        {

        }

        private void VisualWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
