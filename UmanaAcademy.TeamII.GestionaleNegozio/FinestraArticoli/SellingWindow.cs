using CsvHelper;
using FinestraArticoli.Model;
using System;
using System.Collections.Generic;
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

            using (var reader = new StreamReader("Files\\Magazzino\\products.csv"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.RegisterClassMap<OrdineArticoloMap>();
                csv.Configuration.Delimiter = ",";
                csv.Read();
                articoli = csv.GetRecords<OrdineArticolo>().ToList();
                sellingDataGV.DataSource = articoli;
                for (int i = 0; i < 8; i++)
                    this.sellingDataGV.Columns[i].ReadOnly = true;
            }
        }

        private void SellingWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
