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
    public partial class SellingWindow : Form
    {
        private List<OrdineArticolo> articoli;
        public SellingWindow()
        {
            InitializeComponent();
            this.sellingDataGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SellingDataGV_CellFormatting);

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<OrdineArticoloMap>();
                csv.Configuration.Delimiter = ",";
                articoli = csv.GetRecords<OrdineArticolo>().ToList();
                sellingDataGV.DataSource = articoli;
                for (int i = 0; i < 8; i++)
                    this.sellingDataGV.Columns[i].ReadOnly = true;
            }
        }
        private void SellingDataGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrdineArticolo articolo = sellingDataGV.Rows[e.RowIndex].DataBoundItem as OrdineArticolo;

            if (articolo.Stock < articolo.Quantity)
            {
                sellingDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                e.CellStyle.BackColor = Color.Red;
            }
            else
            {
                sellingDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                e.CellStyle.BackColor = Color.White;
            }
        }
        private void SellingButton_Click(object sender, EventArgs e)
        {
            if (Store.SaveDataGrid(saveFileDialog, articoli, false))
                this.Close();
        }

        private void SellingWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
