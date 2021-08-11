using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q
{
    public partial class customerfrm : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP - LLCN5CO; Initial Catalog = Fooroushgah; Integrated Security = True");

        public customerfrm()
        {
            InitializeComponent();
        }



        private void save_Click(object sender, EventArgs e)
        {

            customerTableAdapter.Insert(int.Parse(ID.Text),name.Text,family.Text, tell.Text, add.Text);
            customerTableAdapter.Fill(fooroushgahDataSet.Customer);
          

            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void family_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void add_TextChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
        //  customerTableAdapter.search_by_name(fooroushgahDataSet.Customer, name_find.Text , family_find.Text);
            
        }

        private void name_find_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
