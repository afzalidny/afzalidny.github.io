using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace q
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LLCN5CO;Initial Catalog=Fooroushgah;Integrated Security=True");

        public login()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("آیا می خواهیدخارج شوید؟", "بستن", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();

            else
                this.Show();

        }




        private void login_btn_Click(object sender, EventArgs e)
        {

            if (username.Text == "")
            {
                MessageBox.Show("Invalid username or password");
            }
            else if (password.Text == "")
                MessageBox.Show("Invalid username or password");
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AUTH1 WHERE username='" + username.Text + "' AND pass  ='" + password.Text + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    mains main = new mains();
                    main.Show();
                }
                else
                    MessageBox.Show("Invalid username or password");

            }
        }

       



       

        private void login_MouseEnter(object sender, EventArgs e)
        {if (username.Text == null && password.Text == null)
            {
                password.Text = "password";
                username.Text = "username";
            }

           
                
        }

        
        private void login_Load(object sender, EventArgs e)
        {
         
        }

        private void username_Click(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void username_MouseEnter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
                password.isPassword = true;
            else
                password.isPassword = false;
        }
    }
}
