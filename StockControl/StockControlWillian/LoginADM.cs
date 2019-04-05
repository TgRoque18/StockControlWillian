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

namespace StockControlWillian
{
    public partial class LoginADM : Form
    {
        public string user;
        public string password;
        public LoginADM()
        {
            InitializeComponent();
            user = "william";
            password = "123";
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == user && txtPassword.Text == password)
            {
                Cadastro C = new Cadastro();
                C.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Helpers.Helper.EPassword());
                btnOk.Enabled = false;
                btnRPassword.Visible = true;
                btnCriarConta.Enabled = false;
            }            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == user && txtPassword.Text == password)
            {
                MessageBox.Show(Helpers.Helper.SBanco());
                HomeADM HA = new HomeADM();
                HA.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Helpers.Helper.EPassword());
                btnOk.Enabled = false;
                btnRPassword.Visible = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                btnOk.Enabled = true;
                btnCriarConta.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRPassword_Click(object sender, EventArgs e)
        {
            string newPass = "testes@123";
            string newPassHash = UserHelper.GeneratePassword(newPass);
        }
    }
}
