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
    public partial class Form2 : Form
    {
        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != ""  && textBox5.Text != "")
            {// 1. address of sql server

                // added a slash and terminator at the end

                // 2.establish connection
                // import this lib at the top using System.Data.SqlClient;
                // create an object 
                SqlConnection connection = new SqlConnection(connectionString);

                // 3.open coonection
                connection.Open();

                //4. prepare query 
                String book_id = textBox1.Text;
                String title = textBox2.Text;
                String categoryid = comboBox1.Text;
                String publication_date = dateTimePicker1.Text;
                int copies_owned = int.Parse(textBox5.Text);

                // Validate and convert publication_date string to DateTime
                DateTime parsedDate;
                if (!DateTime.TryParse(publication_date, out parsedDate))
                {
                    // Invalid date format, show an error message
                    MessageBox.Show("Invalid publication date format. Please enter a valid date.");
                    return;
                }


                String query = "insert into book  values (@book_id,@title,@categoryid,@publication_date,@copies_owned)";
                SqlCommand cmd = new SqlCommand(query, connection)
                {
                    Parameters =
    {
        new SqlParameter("@book_id", book_id),
        new SqlParameter("@title", title),
        new SqlParameter("@categoryid", categoryid),
        new SqlParameter("@publication_date", parsedDate),
        new SqlParameter("@copies_owned", copies_owned)
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
                
                
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("EMPTY TEXTBOXES CANNOT BE PROCESSED");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will delete your unsaved data","ARE YOU SURE?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
