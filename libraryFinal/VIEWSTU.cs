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
    public partial class VIEWSTU : Form
    {
        String connectionString = "Data Source=DESKTOP-CPL34M1\\SQLEXPRESS01;Initial Catalog=db_library;Integrated Security=True";

        public VIEWSTU()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VIEWSTU_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from member", con);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);

                dataGridView1.DataSource = tbl;


            }
        }
    }
}
