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
    public partial class calculator : Form
    {
        string operation = "";
        double firstnum, secoundnum;
        public calculator()
        {

            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void numericvalue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(textdisplay.Text=="0")
            {
                textdisplay.Text = "";

            }
            if (b.Text == ".")
            {
                if (!textdisplay.Text.Contains("."))
                    textdisplay.Text = textdisplay.Text + b.Text;

            }
            else
                textdisplay.Text = textdisplay.Text + b.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textdisplay.Text = "0";
        }

        private void operatot(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnum = double.Parse(textdisplay.Text);
            operation = b.Text;
            textdisplay.Text = "";

        }

        private void equal_Click(object sender, EventArgs e)
        {
            secoundnum = double.Parse(textdisplay.Text);
            switch(operation)
            {
                case "+":
                    textdisplay.Text = Convert.ToString(firstnum + secoundnum);
                    break;

                case "-":
                    textdisplay.Text = Convert.ToString(firstnum - secoundnum);
                    break;

                case "*":
                    textdisplay.Text = Convert.ToString(firstnum * secoundnum);
                    break;

                case "/":
                    textdisplay.Text = Convert.ToString(firstnum / secoundnum);
                    break;

                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("آیا می خواهید ماشین حساب را ببندید؟","بستن",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                this.Close();
            else
                this.Show();
                
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textdisplay.Text = "0";
            string first, secound;
            first = Convert.ToString(firstnum);
            secound = Convert.ToString(secoundnum);
            first = "";
            secound = "";
        }
    }
}
