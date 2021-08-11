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

namespace q
{
    public partial class forget_password : Form
    {
        public forget_password()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //نام فرستنده
                mail.From = new MailAddress("donya00713@gmail.com");
                //آدرس گیرنده یا گیرندگان
                mail.To.Add("donya9811811247@gmail.com");
                //عنوان ایمیل
                mail.Subject = "Test Mail";
                //بدنه ایمیل
                mail.Body = "This is for testing SMTP mail from GMAIL";
                //مشخص کرن پورت 
                SmtpServer.Port = 587;
                //username : به جای این کلمه نام کاربری ایمیل خود را قرار دهید
                //password : به جای این کلمه رمز عبور ایمیل خود را قرار دهید
                SmtpServer.Credentials = new System.Net.NetworkCredential("donya00713@gmail.com", "dashtbayaz.donya9811811247");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
        