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
    public partial class ProvisionWindow : Form
    {
        private List<OrdineArticolo> articoli;
        public ProvisionWindow()
        {
            InitializeComponent();
            this.provisionDataGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProvisionDataGV_CellFormatting);

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<OrdineArticoloMap>();
                csv.Configuration.Delimiter = ",";
                articoli = csv.GetRecords<OrdineArticolo>().ToList();
                provisionDataGV.DataSource = articoli;
                for (int i = 0; i < 8; i++)
                    this.provisionDataGV.Columns[i].ReadOnly = true;
            }
        }
        private void ProvisionDataGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrdineArticolo articolo = provisionDataGV.Rows[e.RowIndex].DataBoundItem as OrdineArticolo;

            if (articolo.Stock <= 10 || articolo.Stock == null)
            {
                provisionDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                e.CellStyle.BackColor = Color.Red;
            }
            else if (articolo.Stock > 10 && articolo.Stock <= 50)
            {
                provisionDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                e.CellStyle.BackColor = Color.Yellow;
            }
            else
            {
                provisionDataGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                e.CellStyle.BackColor = Color.White;
            }
        }
        private void ProvisionDataGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("INSERISCI UN CARATTERE VALIDO.");
        }
        private void ProvisionWindow_Load(object sender, EventArgs e)
        {

        }

        private void ProvisionButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Store.SaveDataGrid(saveFileDialog, articoli, true);
        }

        private void ProvisionLabel_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
