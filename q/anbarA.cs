using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace q
{

    public partial class anbarA : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LLCN5CO;Initial Catalog=Fooroushgah;Integrated Security=True");
       
        public anbarA()
        {
            InitializeComponent();
        }

        public string code;


        private void tabale_of_anbar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //tabale_of_anbar.Rows[e.RowIndex].Cells["radif"].Value = e.RowIndex + 1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            anbar1TableAdapter.Insert(int.Parse(ID_anb.Text), name_anb.Text, nameManagement_anb.Text, family_management_anb.Text, tell_anb.Text, add_anb.Text);
            anbar1TableAdapter.Fill(fooroushgahDataSet.anbar1);

        }



        private void anbarA_Load(object sender, EventArgs e)
        {
            this.anbar1TableAdapter.Fill(this.fooroushgahDataSet.anbar1);
        }

        private void name_anb_find_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void name_management_find_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void add_find_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM anbar1 WHERE name_anbar like N'%'+@name_anb+'%' and name_management like N'%'+@name_manage+'%'";
            cmd.Parameters.AddWithValue("@name_anb", name_anb_find.Text);
            cmd.Parameters.AddWithValue("@name_manage", name_management_find.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabale_of_anbar.DataSource = dt;
            con.Close();
        }

        private void deletRecord()
        {
            DialogResult dialogResult = MessageBox.Show("آیا میخواهید این سطر را حذف کتید؟", "حذف", MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            {
                SqlCommand cmd = new SqlCommand("delete   from anbar1  where ID_anbar=@ID_anb ");
                cmd.Parameters.AddWithValue("@ID_anb", ID_anb.Text);
                cmd.Connection = con;
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("رکورد با موفقیت حذف شد ");
                else
                    MessageBox.Show("رکورد حذف نشد");
                anbar1TableAdapter.Fill(fooroushgahDataSet.anbar1);

                con.Close();
            }
        }
        private void updateRecord()
        {
            SqlCommand cmd = new SqlCommand("update anbar1  set ID_anbar=@ID_anb, name_anbar =@name_anb  , name_management =@name_manage , family_management =@familymanage , tell =@tell  , addres =@add  where ID_anbar=@ID_anb ");
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@ID_anb", ID_anb.Text);
            cmd.Parameters.AddWithValue("@name_anb", name_anb.Text);
            cmd.Parameters.AddWithValue("@name_manage", nameManagement_anb.Text);
            cmd.Parameters.AddWithValue("@familymanage", family_management_anb.Text);
            cmd.Parameters.AddWithValue("@tell", tell_anb.Text);
            cmd.Parameters.AddWithValue("@add", add_anb.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
          
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("رکورد با موفقیت آپدیت شد");
            else
                MessageBox.Show("update notsucces");
            anbar1TableAdapter.Fill(fooroushgahDataSet.anbar1);

            con.Close();
           

        }
        private void delet_Click(object sender, EventArgs e)
        {

            deletRecord();
        }


        private void edit_Click(object sender, EventArgs e)
        {
             updateRecord();
      //anbar1TableAdapter.UpdateQuery1(int.Parse(ID_anb.Text),name_anb.Text,nameManagement_anb.Text,family_management_anb.Text,tell_anb.Text,add_anb.Text,code);
        }

        private void tabale_of_anbar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //ID_anb.Text = (tabale_of_anbar.Rows[e.RowIndex].Cells[1].Value.ToString());
            //this.code = (tabale_of_anbar.Rows[e.RowIndex].Cells[1].Value.ToString());
            //name_anb.Text = tabale_of_anbar.Rows[e.RowIndex].Cells[2].Value.ToString();
            //nameManagement_anb.Text = tabale_of_anbar.Rows[e.RowIndex].Cells[3].Value.ToString();
            //family_management_anb.Text = tabale_of_anbar.Rows[e.RowIndex].Cells[4].Value.ToString();
            //tell_anb.Text = tabale_of_anbar.Rows[e.RowIndex].Cells[5].Value.ToString();
            //add_anb.Text = tabale_of_anbar.Rows[e.RowIndex].Cells[6].Value.ToString();

        }



        

        

        private void tabale_of_anbar_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex;
            if (e.Button == MouseButtons.Right)
            {
                //this.tabale_of_anbar.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
  
                contextMenuStrip1.Show(Cursor.Position);
            }

        }

       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            deletRecord();
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult res = printDialog1.ShowDialog();
            if (res == DialogResult.OK)
                printDocument1.Print();
        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        ////{
        ////    Graphics graphics = e.Graphics;
        ////    Font font = new Font("Courier New ", 14);
        //    float fontweight = font.GetHeight();
        //    int startx = 190;
        //    int starty = 40;
        //    int offset = 20;
        //    float leftmargin = e.MarginBounds.Left;
        //    float topmargin = e.MarginBounds.Top;
        //        //graphics.DrawString("welcom to Harko market Shop Report",new Font("couier new ",20),new SolidBrush(Color.Black),startx,starty);
        //    }
        } 
    }
    
