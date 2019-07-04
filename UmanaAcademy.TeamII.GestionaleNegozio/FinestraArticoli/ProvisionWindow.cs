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
    public partial class ProvisionWindow : Form
    {
        private List<Articolo> articoli;
        public ProvisionWindow()
        {
            InitializeComponent();

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<ArticoloMap>();
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<Articolo>().ToList();
                provisionDataGV.DataSource = articoli;
            }
        }

        private void ProvisionWindow_Load(object sender, EventArgs e)
        {

        }

        private void ProvisionButton_Click(object sender, EventArgs e)
        {

        }

        private void ProvisionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
