using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;
using Kavenegar;
using Kavenegar.Utils;
using Kavenegar.Models;
using System.Web;


namespace q
{
    public partial class forgetpass : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LLCN5CO;Initial Catalog=Fooroushgah;Integrated Security=True");

       
        Random rand = new Random();

        string randomcode;
        public forgetpass()
        {
            InitializeComponent();
        }

        private void send_sms_Click(object sender, EventArgs e)
        {

        }


        private void send_email_Click(object sender, EventArgs e)
        {
            randomcode = (rand.Next(999999)).ToString();

            try {
                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587;
                bool enableSSL = true;

                string emailFrom = "donya00713@gmail.com";
                string password = "afzali.donya9811811247";
                //string emailTo = email.Text;
                string subject = "Hello";
                string body = "salam!";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                  //  mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                }
            }catch(Exception ex)
            {

            }
        }
    }
}