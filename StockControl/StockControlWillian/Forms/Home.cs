using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlWillian
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            LoginADM C = new LoginADM();
            C.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login C = new Login();
            C.Show();
            this.Hide();
        }
    }
}
