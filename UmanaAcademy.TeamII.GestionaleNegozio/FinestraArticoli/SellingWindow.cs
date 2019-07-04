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
    public partial class SellingWindow : Form
    {
        private List<Articolo> articoli;
        public SellingWindow()
        {
            InitializeComponent();

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<ArticoloMap>();
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<Articolo>().ToList();

                Store store = new Store();

                store.MarkOutOfStockProducts(articoli);

                sellingDataGV.DataSource = articoli;
            }
        }

        private void SellingWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
