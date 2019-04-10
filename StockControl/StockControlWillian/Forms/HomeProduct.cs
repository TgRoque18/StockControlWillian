using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlWillian.Forms
{
    public partial class HomeProduct : Form
    {
        public HomeProduct()
        {
            InitializeComponent();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Helpers.Helper.Help());
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }

        private void sentEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SentEmail SE = new SentEmail();
            SE.Show();
            this.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeCategory HC = new HomeCategory();
            HC.Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeProduct HP = new HomeProduct();
            HP.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeStock HS = new HomeStock();
            HS.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeUser HU = new HomeUser();
            HU.Show();
            this.Hide();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            NewProductADM NP = new NewProductADM();
            NP.Show();
            this.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeUser HU = new HomeUser();
            HU.Show();
            this.Hide();
        }
    }
}
