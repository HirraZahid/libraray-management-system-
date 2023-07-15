using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form2")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            
        }

        private void vIEWBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "VIEWBOOK")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                VIEWBOOK vB = new VIEWBOOK();
                vB.Show();
            }

           
        }

        private void uPDATEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FUPDATE")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                FUPDATE FB = new FUPDATE();
                FB.Show();
            }

        }

        private void dELETEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FDEL")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                FDELcs FD = new FDELcs();
                FD.Show();
            }
        }

        private void aDDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ADDSTU")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                ADDSTU AS = new ADDSTU();
                AS.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vIEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "VIEWSTU")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                VIEWSTU VS = new VIEWSTU();
                VS.Show();
            }
        }

        private void uPDATESTUDENTINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "UPSTU")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                UPSTU US = new UPSTU();
                US.Show();
            }
        }

        private void dELETESTUDENTINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "DELSTU")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                DELSTU DS = new DELSTU();
                DS.Show();
            }
        }

        private void iSSUEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ISSUEBOOK")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                ISSUEBOOK IS = new ISSUEBOOK();
                IS.Show();
            }
        }

        private void rETURNBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ReturnBook")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                ReturnBook RS = new ReturnBook();
                RS.Show();
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iSSUEDBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "issuedbooks")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                issuedbooks RS = new issuedbooks();
                RS.Show();
            }
        }

        private void uNISSUEDBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "unissuedbooks")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                unissuedbooks RS = new unissuedbooks();
                RS.Show();
            }
        }

        private void oVERDUEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "overduebooks")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                overduebooks RS = new overduebooks();
                RS.Show();
            }

        }

        private void rETURNEDBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "returnedbooks")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                returnedbooks RS = new returnedbooks();
                RS.Show();
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bOOKSCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "bookcount")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                bookcount RS = new bookcount();
                RS.Show();
            }

        }

        private void fINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Finepayment")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                Finepayment RS = new Finepayment();
                RS.Show();
            }
        }

        private void dELETEBOOKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "FDELcs")
                {
                    isopen = true;
                    f.BringToFront();
                    break;


                }

            }
            if (isopen == false)
            {
                FDELcs RS = new FDELcs();
                RS.Show();
            }
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
