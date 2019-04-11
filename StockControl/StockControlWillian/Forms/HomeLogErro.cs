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
    public partial class HomeLogErro : Form
    {
        public HomeLogErro()
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
            HomeCategoryADM HC = new HomeCategoryADM();
            HC.Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeProductADM HP = new HomeProductADM();
            HP.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeStockADM HS = new HomeStockADM();
            HS.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeUserADM HU = new HomeUserADM();
            HU.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeUserADM HU = new HomeUserADM();
            HU.Show();
            this.Hide();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeLog HL = new HomeLog();
            HL.Show();
            this.Hide();
        }

        private void logErroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeLogErro HLE = new HomeLogErro();
            HLE.Show();
            this.Hide();
        }
    }
}
