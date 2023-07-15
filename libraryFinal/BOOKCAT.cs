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

namespace libraryFinal
{
    public partial class BOOKCAT : Form
    {

        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";

        public BOOKCAT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BOOKCAT_Load(object sender, EventArgs e)
        {
            dataGridView2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String TEXT = textBox1.Text;
                SqlDataAdapter sda = new SqlDataAdapter("Select * from fine_payment", con);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);
               
                dataGridView2.DataSource = tbl;
                dataGridView2.Show();



            }
        }
    }
}
