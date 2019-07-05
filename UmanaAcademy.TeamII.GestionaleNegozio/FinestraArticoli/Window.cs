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

        public window()
        {
            InitializeComponent();
        }

        private void VisualButton_Click(object sender, EventArgs e)
        {
            using (var form = new VisualWindow())
            {
                form.ShowDialog();
            }
            //File.WriteAllText("Files\\Magazzino\\products.csv", File.ReadAllText("Files\\Magazzino\\productsTemp.csv").ToString());
            //File.Move("Files\\Magazzino\\productsTemp.csv", "Files\\Magazzino\\products.csv");
            //File.Delete("Files\\Magazzino\\productsTemp.csv");
        }
        private void ProvisionButton_Click(object sender, EventArgs e)
        {
            using (var form = new ProvisionWindow())
            {
                form.ShowDialog();
            }
        }
        private void SellingButton_Click(object sender, EventArgs e)
        {
            using (var form = new SellingWindow())
            {
                form.ShowDialog();
            }
        }

        private void DataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}