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
            LoadCategories();
        }

        public void LoadCategories()
        {
            List<Category> list = DBCategoryHelper.GetCategories();

            if(list.Count > 0)
            {
                foreach (var item in list)
                {
                    comboBoxCategory.Items.Add(item.Name);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text != "" && comboBoxCategory.SelectedItem != "")
            {
                Category cat = DBCategoryHelper.GetCategoryByName(comboBoxCategory.SelectedItem.ToString());
                
                Product p = new Product();
                p.Name = txtProduct.Text;
                p.Active = true;
                p.Categoria = cat;
                DBProductHelper.Create(p);
                MessageBox.Show(Helpers.Helper.Product());

            }
            else
            {
                MessageBox.Show(Helpers.Helper.Erro());
            }
        }

        private void TxtProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewProductADM_Load(object sender, EventArgs e)
        {

        }
    }
}
