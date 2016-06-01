using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using SwissTransportApplication;

namespace SwissTransportTimeTable
{
    public partial class frmSendMail : Form
    {

        string SendConnections;
        public frmSendMail(string Connections)
        {
            InitializeComponent();
            SendConnections = Connections;
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        

        private void SendMail_Click(object sender, EventArgs e)
        {
            
            string From = txtFrom.Text;
            string Password = txtPassword.Text;
            string To = txtTo.Text;
            string Subject = txtSubject.Text;
            string Message = txtMessage.Text;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(From);
                mail.To.Add(To);
                mail.Subject = Subject;

                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(From, Password);
                SmtpServer.EnableSsl = true;
                
                mail.Body = Message + "\r\n" + "\r\n";
                foreach(var connection in SendConnections)
                {
                    mail.Body = mail.Body + connection;
                }

                SmtpServer.Send(mail);
                MessageBox.Show("Mail wurde versendet.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Die Mail konnte nicht versendet werden." + ex);
            }
        }
    }
}
