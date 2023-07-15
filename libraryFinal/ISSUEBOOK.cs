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
    public partial class ISSUEBOOK : Form
    {
        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";


        public ISSUEBOOK()
        {
            InitializeComponent();
        }

        int count=0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
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
                String text1 = textBox1.Text;
                //query 1 to print the name of stu in texbox 4
                String query = "select * from member where member_id ='"+text1+"'";
                SqlCommand cmd = new SqlCommand(query, connection);
                
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                Da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    textBox4.Text = ds.Tables[0].Rows[0][1].ToString()+" "+ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    textBox4.Clear();
                    MessageBox.Show("Invalid id","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                // query 2 to count how many books is issued by this student 
                String query1 = "select count(member_id) from issue where member_id ='" + text1 + "' and return_date is null ";
                cmd.CommandText = query1;
                SqlDataAdapter Da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                Da1.Fill(ds1);
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //MessageBox.Show("count",count.ToString());
                //5. execute query 

                cmd.ExecuteNonQuery();
                //6. close connection 
                connection.Close();

                // show msg when data updated
                //MessageBox.Show("data updated :)");


            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox3.Text != "" && count < 2)
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
                    String stuid = textBox1.Text;
                    String issueid = textBox2.Text;
                    String bookid = textBox3.Text;
                    String stuName = textBox4.Text;
                    String issueDate = dateTimePicker1.Text;
                    String returndate = null;
                    //query 1 to print the name of stu in texbox 4
                    String query = "insert into issue (issue_id,book_id,member_id,issue_date) values('" + issueid + "','" + bookid + "','" + stuid + "','" + issueDate + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //5. execute query 

                    cmd.ExecuteNonQuery();
                    //6. close connection 
                    connection.Close();

                    // show msg when data updated
                    MessageBox.Show("Book issued ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Maximum number of Book has been issued ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("Enter valid student information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ISSUEBOOK_Load(object sender, EventArgs e)
        {

        }
    }
}
