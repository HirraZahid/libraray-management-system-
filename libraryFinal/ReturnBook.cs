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
    public partial class ReturnBook : Form
    {
        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from issue where member_id='"+textBox1.Text+ "' and return_date is null ", con);
                  DataTable tbl = new DataTable();
                sda.Fill(tbl);
                

                if (tbl.Rows.Count!=0)
                {
                    dataGridView1.DataSource = tbl;

                }
                else
                {
                    MessageBox.Show("Invalid Id or NO Book Issued","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
        String Bid;
        String IDATE;
        String RDATE;
        int rowId; 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Bid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                IDATE = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            textBox2.Text = Bid;
            textBox3.Text = IDATE;

        }

        private void button4_Click(object sender, EventArgs e)
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
            

            


            String query = "UPDATE issue  SET return_date='"+dateTimePicker1.Text+"' WHERE member_id= '"+textBox1.Text+"' and issue_id="+rowId+"";
            SqlCommand cmd = new SqlCommand(query, connection);
           
            //5. execute query 

            cmd.ExecuteNonQuery();
            //6. close connection 
            connection.Close();

            // show msg when data added
            MessageBox.Show("book returned :)");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data", "ARE YOU SURE?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
