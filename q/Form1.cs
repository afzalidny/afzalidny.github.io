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
using Kavenegar;
using Kavenegar.Utils;
using Kavenegar.Models;

using System.Web;


namespace q
{
    public partial class Form1 : Form
    {
        public static string to;
        string messeagebody;
        Random rand = new Random();

        string randomcode;
        public Form1()
        {
            InitializeComponent();
        }

        private void sendemail_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 25;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("donya00713@gmail.com", "dashtbayaz.donya9811811247");
                MailMessage msg = new MailMessage();
              //  msg.To.Add(email.Text);
                msg.From = new MailAddress("donya00713@gmail.com");
                msg.Subject = "salam";
                msg.Body = messeagebody;
                // Attachment data = new Attachment(textBox3.Text);
                // msg.Attachments.Add(data);

                client.Send(msg);
                MessageBox.Show("Successfully Sent Message.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sendsms_Click(object sender, EventArgs e)
        {
            randomcode = (rand.Next(999999)).ToString();

            messeagebody = " your reset code is " + randomcode;
            var send = "1000596446";
          //  var receptor = num.Text;
            var message = messeagebody;
            var api = new Kavenegar.KavenegarApi("4251374B69646951333671656279554A6D31792B32484B43347A574A7542467450594B455058622F3048733D");
          
           // api.Send(send, receptor, message);
        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        //    if (vrf.Text == randomcode)
        //    {
        //        MessageBox.Show("ok");

        //    }
        //    else
        //        MessageBox.Show("not ok");
        }

    }

}
    