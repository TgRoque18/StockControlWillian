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
    public partial class Login : Form
    {
        public string user;
        public string password;
        public Login()
        {
            InitializeComponent();
            user = "william";
            password = "123";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == user && txtPassword.Text == password)
            {
                MessageBox.Show(Helpers.Helper.SBanco());
                HomeUser HU = new HomeUser();
                HU.Show();
                this.Show();
            }
            else
            {
                MessageBox.Show(Helpers.Helper.EPassword());
                btnOk.Enabled = false;
                btnRPassword.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                btnOk.Enabled = true;
            }
            
        }
    }
 }