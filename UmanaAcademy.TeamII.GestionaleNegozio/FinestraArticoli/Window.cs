using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinestraArticoli
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }
        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((tabControl.SelectedTab == tabPageVisual) || (tabControl.SelectedTab == tabPageProvision) || (tabControl.SelectedTab == tabPageSelling))
            {
                tabControl.SelectedTab = tabPageInitial;
                MessageBox.Show("Seleziona un pulsante.");
            }
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

        }

        private void ProvisionButton_Click(object sender, EventArgs e)
        {

        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }
}
