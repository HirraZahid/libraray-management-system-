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
    public partial class FDELcs : Form
    {
        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";


        public FDELcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data", "ARE YOU SURE?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
            String book_id = textBox1.Text;



            String query = "delete  book   where book_id=@book_id";
            SqlCommand cmd = new SqlCommand(query, connection)
            {
                Parameters =
    {
        new SqlParameter("@book_id", book_id)

    }
            };

            //5. execute query 

            cmd.ExecuteNonQuery();
            //6. close connection 
            connection.Close();

            // show msg when data deleted
            MessageBox.Show("data deleted :)");

        }
    }
}
