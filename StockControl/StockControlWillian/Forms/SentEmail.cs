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
    public partial class SentEmail : Form
    {
        private string To;
        private string Subject;
        private string Body;
        private string SMTP = ConfigurationManager.AppSettings["SMTP"];
        private string PORT = ConfigurationManager.AppSettings["PORT"];
        private string EMAIL = ConfigurationManager.AppSettings["EMAIL"];
        private string PASS = ConfigurationManager.AppSettings["PASS"];

        private MailMessage mail;

        public SentEmail()
        {
            InitializeComponent();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtTo.Text.Trim() == "" && !(txtMessage.Text == "")))
                {
                    To = txtTo.Text;
                    Subject = txtSubject.Text;
                    Body = txtMessage.Text;

                    mail = new MailMessage();
                    mail.To.Add(new MailAddress(this.To));
                    mail.From = new MailAddress(EMAIL);
                    mail.Subject = Subject;
                    mail.Body = Body;
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
                else
                {
                    MessageBox.Show("Dados obrigatorios nao preenchidos!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {                 
                throw ex;
            }
        }
    }
}
