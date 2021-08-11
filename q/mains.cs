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
    public partial class mains : Form
    {
        public mains()
        {
            InitializeComponent();
            //panel2.Visible =false;
           
        }
        private void movepanel(Control btn)
        {
            panelside.Height = btn.Height;
            panelside.Top = btn.Top;
        }

        private void save_all_Click(object sender, EventArgs e)
        {
           
            movepanel(save_all);
            if (panelmenu.Visible == false)
                panelmenu.Visible = true;
            else
                panelmenu.Visible = false;
            
        }

        private void save_all_MouseEnter(object sender, EventArgs e)
        {
            movepanel(save_all);
            if (panelmenu.Visible == false)
                panelmenu.Visible = true;
            else
                panelmenu.Visible = false;
        }

       

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panelmenu.Visible = false; 
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saller_Click(object sender, EventArgs e)
        {
            movepanel(saller);
        }

        private void saller_MouseEnter(object sender, EventArgs e)
        {
            movepanel(saller);
            panelmenu.Visible = false;
        }

        private void report_Click(object sender, EventArgs e)
        {
           panel2.Visible =true;
            movepanel(report);
            panel_main.Controls.Clear();

            report_anbar rep = new q.report_anbar();
            panel_main.Controls.Add(rep);
            rep.Show();
        }

        private void report_MouseEnter(object sender, EventArgs e)
        {
            movepanel(report);
            panel2.Visible = true;
        }

      

        

      

        private void main_MouseEnter(object sender, EventArgs e)
        {
            panelmenu.Visible = false;
            panel2.Visible = false;
        }

        private void seting_Click(object sender, EventArgs e)
        {
            movepanel(seting);
            calculator c = new calculator();
            c.Show();
        }

        private void seting_MouseEnter(object sender, EventArgs e)
        {
            movepanel(seting);

        }

        private void exit_Click(object sender, FormClosedEventArgs e)
        {
           
            
             
             
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            movepanel(exit);
        }

        private void customer_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            panelmenu.Visible = false;
            customerfrm cus= new customerfrm();
            panel_main.Controls.Add(cus);
            cus.Show();
          
            
        }

        private void anbarlist_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            panelmenu.Visible = false;
            anbarA anb = new anbarA();
            panel_main.Controls.Add(anb);
            anb.Show();
        }

        private void product_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            panelmenu.Visible = false;
            prd prod = new q.prd(); 
            panel_main.Controls.Add(prod);
            prod.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            movepanel(exit);
            DialogResult messege = MessageBox.Show("بستن", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messege == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                mains m = new mains();
                m.Show();
            }
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
