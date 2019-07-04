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

        private int actualTabPage = 0;
        private List<Articolo> articoli;

        public window()
        {
            InitializeComponent();
        }
        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((tabControl.SelectedTab == tabPageVisual) || (tabControl.SelectedTab == tabPageProvision) || (tabControl.SelectedTab == tabPageSelling))
            {
                tabControl.SelectedIndex = actualTabPage;
                MessageBox.Show("Cambia scheda nella pagina iniziale.");
            }
            else
                actualTabPage = 0;
        }

        private void TabPageInitial_Click(object sender, EventArgs e)
        {
            actualTabPage = 0;
        }
        private void VisualButton_Click(object sender, EventArgs e)
        {
            actualTabPage = 1;
            tabControl.SelectedTab = tabPageVisual;
            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<Articolo>().ToList();
                dataGV.DataSource = articoli;
            }
        }
        private void ProvisionButton_Click(object sender, EventArgs e)
        {
            actualTabPage = 2;
            tabControl.SelectedTab = tabPageProvision;
        }
        private void SellingButton_Click(object sender, EventArgs e)
        {
            actualTabPage = 3;
            tabControl.SelectedTab = tabPageSelling;
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void DataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void SaveProductsButton_Click(object sender, EventArgs e)
        {
            Store.SaveDataGrid(saveFileDialog, articoli);

        }
    }
}
