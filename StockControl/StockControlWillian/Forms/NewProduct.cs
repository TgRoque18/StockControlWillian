using StockControlWillian.Classe;
using StockControlWillian.Helpers;
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
    public partial class NewProductADM : Form
    {
        public NewProductADM()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text != "")
            {
                Product c = new Product();
                c.Name = txtProduct.Text;
                c.Active = true;
                DBProductHelper.Create(c);
                MessageBox.Show(Helpers.Helper.Product());

            }
            else
            {
                MessageBox.Show(Helpers.Helper.Erro());
            }
        }
    }
}
