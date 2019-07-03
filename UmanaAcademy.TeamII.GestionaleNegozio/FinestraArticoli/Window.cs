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

        private int actualTabPage = 0;

        public window()
        {
            InitializeComponent();
        }
        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((tabControl.SelectedTab == tabPageVisual) || (tabControl.SelectedTab == tabPageProvision) || (tabControl.SelectedTab == tabPageSelling))
            {
                tabControl.SelectedIndex = actualTabPage;
                if(actualTabPage == 0)
                    MessageBox.Show("Seleziona un pulsante.");
                else
                    MessageBox.Show("Torna alla schermata iniziale per selezionare un'altra schermata.");
            }
        }

        private void TabPageInitial_Click(object sender, EventArgs e)
        {
            actualTabPage = 0;
        }

        private void VisualButton_Click(object sender, EventArgs e)
        {
            actualTabPage = 1;
            tabControl.SelectedTab = tabPageVisual;
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

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    SaveDataGrid(saveFileDialog, articoli);
        //}
    }
}
