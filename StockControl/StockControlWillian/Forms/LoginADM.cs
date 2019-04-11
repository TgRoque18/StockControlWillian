using StockControlWillian.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlWillian
{
    public partial class LoginADM : Form
    {
        public string user;
        public string password;

        private string To;
        private string SMTP = ConfigurationManager.AppSettings["SMTP"];
        private string PORT = ConfigurationManager.AppSettings["PORT"];
        private string EMAIL = ConfigurationManager.AppSettings["EMAIL"];
        private string PASS = ConfigurationManager.AppSettings["PASS"];

        private MailMessage mail;

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
                HomeUserADM HA = new HomeUserADM();
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
            Home H = new Home();
            H.Show();
            this.Hide();
         }

        private void btnRPassword_Click(object sender, EventArgs e)
        {
            string newPass = "testes@123";
            string newPassHash = UserHelper.GeneratePassword(newPass);

            To = "william.blacutt@gmail.com";
            //Subject = txtSubject.Text;
            //Body = txtMessage.Text;

            mail = new MailMessage();
            mail.To.Add(new MailAddress(this.To));
            mail.From = new MailAddress(EMAIL);
            mail.Subject = "Nova senha";
            mail.Body = "Sua nova senha é " + newPass + ", por favor trocar a senha!";
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient(SMTP, int.Parse(PORT));
            using (client)
            {
                client.Credentials = new System.Net.NetworkCredential(EMAIL, PASS);
                client.EnableSsl = true;
                client.Send(mail);
            }
            MessageBox.Show("Mensaje enviado Exitosamente");
        }
    }
}
