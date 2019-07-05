using CsvHelper;
using FinestraArticoli.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinestraArticoli
{
    public partial class VisualWindow : Form
    {
        private List<Articolo> articoli;
        public VisualWindow()
        {
            InitializeComponent();

            this.visualDataGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.VisualDataGV_CellFormatting);

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                //csv.Configuration.RegisterClassMap<ArticoloMap>();
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<Articolo>().ToList();
                visualDataGV.DataSource = articoli;
                reader.Close();
            }
        }
        private void SaveProductsButton_Click(object sender, EventArgs e)
        {
            Store.SaveDataGrid(saveFileDialog, articoli);
            this.Close();
        }

        private void VisualWindow_Closing(object sender, FormClosingEventArgs e)
        {
            //Store.SaveDataGrid(saveFileDialog, articoli);
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
        //private void VisualDataGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    Articolo articolo = visualDataGV.Rows[e.RowIndex].DataBoundItem as Articolo;
        //    switch (e.ColumnIndex)
        //    {
        //        case 5:
        //            if (!int.TryParse(articolo.Stock.ToString(), out int result))
        //            {
        //                saveDate = articolo.Stock.ToString();
        //            }

        //            break;
        //    }
        //}

        private void VisualDataGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("INSERISCI UN CARATTERE VALIDO.");
        }

        private void VisualLabel_Click(object sender, EventArgs e)
        {

        }

        private void VisualWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
