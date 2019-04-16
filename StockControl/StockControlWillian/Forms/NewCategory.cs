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
    public partial class NewCategory : Form
    {
        public NewCategory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "")
            {
                Category c = new Category();
                c.Name = txtCategory.Text;
                c.Active = true;
                DBCategoryHelper.Create(c);
                MessageBox.Show(Helpers.Helper.Category());

            }  
            else
            {
                MessageBox.Show(Helpers.Helper.Erro());
            }

        }
    }
}
