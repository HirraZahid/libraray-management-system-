﻿using System;
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
    public partial class returnedbooks : Form
    {
        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";

        public returnedbooks()
        {
            InitializeComponent();
        }

        private void returnedbooks_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM issue WHERE return_date IS not NULL;", con);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);

                dataGridView1.DataSource = tbl;


            }
        }
    }
}
