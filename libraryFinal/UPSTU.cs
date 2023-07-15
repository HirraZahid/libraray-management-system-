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
    public partial class UPSTU : Form
    {
        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";

        public UPSTU()
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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""  && textBox5.Text != "")
            {// 1. address of sql server

                // added a slash and terminator at the end

                // 2.establish connection
                // import this lib at the top using System.Data.SqlClient;
                // create an object 
                SqlConnection connection = new SqlConnection(connectionString);

                // 3.open coonection
                connection.Open();

                //4. prepare query 
                String member_id = textBox1.Text;
                String first_name = textBox2.Text;
                String last_name = textBox3.Text;
                String joining_date = dateTimePicker1.Text;
                String member_status_id = textBox5.Text;

                // Validate and convert publication_date string to DateTime
                DateTime parsedDate;
                if (!DateTime.TryParse(joining_date, out parsedDate))
                {
                    // Invalid date format, show an error message
                    MessageBox.Show("Invalid publication date format. Please enter a valid date.");
                    return;
                }


                String query = "UPDATE member  SET first_name=@first_name,last_name=@last_name,joining_date=@joining_date,member_status_id=@member_status_id WHERE member_id=@member_id ";
                SqlCommand cmd = new SqlCommand(query, connection)
                {
                    Parameters =
    {
        new SqlParameter("@member_id", member_id),
        new SqlParameter("@first_name", first_name),
        new SqlParameter("@last_name", last_name),
        new SqlParameter("@joining_date", parsedDate),
        new SqlParameter("@member_status_id", member_status_id)
    }
                };

                //5. execute query 

                cmd.ExecuteNonQuery();
                //6. close connection 
                connection.Close();

                // show msg when data added
                MessageBox.Show("data added :)");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("EMPTY TEXTBOXES CANNOT BE PROCESSED");
            }
        }
    }
}
