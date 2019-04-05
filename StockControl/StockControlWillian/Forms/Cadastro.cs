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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Helpers.Helper.SBanco());
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginADM L = new LoginADM();
            L.Show();
            this.Hide();
        }
    }
}
