using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kavenegar;
using Kavenegar.Utils;
using Kavenegar.Models;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Web;
using System.Web.UI;
using WhatsAppApi;
using System.Web.UI.WebControls;



namespace q
{
    public partial class forget_password : Form
    {
        //Random int rand;
        //public Random randomcode = (Random.Next(999999)).ToString();

        MailMessage maill = new MailMessage();
        public forget_password()
        {
            InitializeComponent();
        }
        

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
        }

        private void vrf_btn_Click(object sender, EventArgs e)
        {
            //if (rand.ToString() == varifycode.Text)
            //{
            //    editinfo m = new editinfo();
            //    m.Show();
            //}
            //else
            //    MessageBox.Show("dsnfjfn");


        }

        private void forget_password_Load(object sender, EventArgs e)
        {
            vrf_btn.Enabled = false;
            vrf_lbl.Enabled = false;
            varifycode.Enabled = false;
        }

        private void send_Click_1(object sender, EventArgs e)
        {
            string to, from, pass;
            MailMessage message = new MailMessage();
            to = txtto.Text;
            from = "donya00713@gmail.com";
            pass = "dny.9811811247";

            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "from:" + "messege" + "body";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                vrf_btn.Enabled = true;
                vrf_lbl.Enabled = true;
                varifycode.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void sendsms_Click(object sender, EventArgs e)
        {
           

            string messeagebody = " your reset code is " ;
            var send = "1000596446";
              var receptor = phon.Text;
            var message = messeagebody;
            var api = new Kavenegar.KavenegarApi("4251374B69646951333671656279554A6D31792B32484B43347A574A7542467450594B455058622F3048733D");

             api.Send(send, receptor, message);

            //string From = "شماره تلفن";

            ////ارسال به
            //string To =phon.Text;

            ////متن پیام
            //string Msg =varifycode.Text;


            //WhatsAppApi.WhatsApp wa = new WhatsAppApi.WhatsApp(From, "پسوورد جنریت شده", "نام نمایشی بر روی کار", false, false);
            //wa.OnConnectSuccess += () =>
            //{
            //    MessageBox.Show("اتصال انجام شد...");

            //    wa.OnLoginSuccess += (phoneNumber, data) =>
            //    {

            //        MessageBox.Show("ارسال شد ...");
            //    };

            //    wa.OnLoginFailed += (data) =>
            //    {
            //        MessageBox.Show("خطا" + data);
            //    };
            //    wa.Login();


            //};
            //wa.OnConnectFailed += (ex) =>
            //{
            //    MessageBox.Show("خطا در اتصال");
            //};
            //wa.Connect();
            //wa.SendMessage(To, Msg);



        }

    }
    //var request = new RestRequest(Method.POST);

    //var client = new RestClient(" https://smspanel.trez.ir/api/smsAPI/GetCredit");

    //client.Authenticator = new HttpBasicAuthenticator(textBox4.Text, textBox3.Text);
    //request.AddHeader("cache-control", "no-cache");
    //request.AddHeader("Content-Type", "application/json");


    //IRestResponse response = client.Execute(request);
    //Response res = JsonConvert.DeserializeObject(response.Content);

}
    
