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
            if (txtCEmail.Text != "" && txtEmail.Text != "" && txtCSenha.Text != "" && txtSenha.Text != "" && txtNome.Text != "")
            {
                if (txtCEmail.Text == txtEmail.Text)
                {
                    if (txtCSenha.Text == txtSenha.Text)
                    {
                        User u = new User();
                        u.Name = txtNome.Text;
                        u.Email = txtCEmail.Text;
                        u.Password = txtSenha.Text;
                        u.Active = true;
                        DBUserHelper.Create(u);
                        MessageBox.Show(Helpers.Helper.User());
                    }
                    else
                    {
                        MessageBox.Show(Helpers.Helper.Password());
                    }
                }
                else
                {
                    MessageBox.Show(Helpers.Helper.Email());
                }
            }            
            else
            {
                MessageBox.Show(Helpers.Helper.Erro());
            }                        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginADM L = new LoginADM();
            L.Show();
            this.Hide();
        }

        private void TxtCSenha_TextChanged(object sender, EventArgs e)
        {
            //if (txtSenha.Text == txtCSenha.Text)
            //{
            //    btnOk.Enabled = true;
            //}
            //else
            //{
            //    btnOk.Enabled = false;
            //}

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            //if (txtCEmail.Text == txtEmail.Text)
            //{
            //    btnOk.Enabled = true;
            //}
            //else
            //{
            //    btnOk.Enabled = false;
            //}
        }
    }
}
