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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Name = "Roupas";
            c.Active = true;
            DBCategoryHelper.Create(c);

            Category c1 = new Category();
            c1.ID = 1;
            c1.Name = "Farmácia";
            c1.Active = true;
            DBCategoryHelper.Update(c1);
        }
    }
}
