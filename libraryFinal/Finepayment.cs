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
    public partial class Finepayment : Form
    {

        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";

        public Finepayment()
        {
            InitializeComponent();
        }

        private void Finepayment_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from fine_payment", con);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);
                dataGridView2.Hide();
                dataGridView1.DataSource = tbl;
                


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. address of sql server

            // added a slash and terminator at the end

            // 2.establish connection
            // import this lib at the top using System.Data.SqlClient;
            // create an object 
            SqlConnection connection = new SqlConnection(connectionString);

            // 3.open coonection
            connection.Open();

            //4. prepare query 
            String fine_payment_id = textBox1.Text;




            String query = "DELETE fine_payment   WHERE fine_payment_id=@fine_payment_id ";
            SqlCommand cmd = new SqlCommand(query, connection)
            {
                Parameters =
    {
        new SqlParameter("@fine_payment_id", fine_payment_id)


    }
            };

            //5. execute query 

            cmd.ExecuteNonQuery();
            //6. close connection 
            connection.Close();

            // show msg when data added
            //MessageBox.Show("data deleted :)");
            dataGridView1.Hide();
            dataGridView2.Show();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from fine_payment", con);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);

                dataGridView2.DataSource = tbl;



            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
