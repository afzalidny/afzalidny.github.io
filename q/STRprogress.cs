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
    public partial class STRprogress : Form
    {
       
        public STRprogress()
        {
           
           
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pro.Value += 1;
            if (pro.Value == 100)
            {
              // label1.Text = pro.Value.ToString() + "%";
                timer1.Stop();
                login l = new login();
                this.Hide();
                l.Show();
            }


        }

        private void STRprogress_Load(object sender, EventArgs e)
        {

        }

      
    }
}
