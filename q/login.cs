using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q
{
    public partial class login : Form
    {
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

       

        private void username_MouseLeave(object sender, EventArgs e)
        {
            username.Text = "username";
        }

        private void password_MouseLeave(object sender, EventArgs e)
        {
            password.Text = "password";
        }

      

        private void password_Click(object sender, EventArgs e)
        {
            password.Text = "";
        }

        private void username_Click(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void username_MouseHover(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void password_MouseHover(object sender, EventArgs e)
        {
            password.Text = "";
        }
    }
}
