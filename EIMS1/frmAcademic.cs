using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EIMS1
{
    public partial class frmAcademicYear : Form
    {
        string query;
        public frmAcademicYear()
        {
            
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAcademicYear_Load(object sender, EventArgs e)
        {
            gbdAcademicYear.Left = (this.Width - gbdAcademicYear.Width) / 2;
            gbdAcademicYear.Top = (this.Height - gbdAcademicYear.Height) / 2;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            Reset();
           
        }
        private void Reset()
        {
            txtAcademicYearCode.Text = "";
            txtAcademicYearCode.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAcademicYearCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAcademicYearCode.Focus();
            }
            else if (cbnAcademicYear.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbnAcademicYear.Focus();
            }
            else if (rbtn1Active.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtn1Active.Focus();
            }
            else if (rbtn2Inactive.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtn2Inactive.Focus();
            }
            else
            {

                
                query = "INSERT INTO Academic(Acad_Code, Acad_Year, Status) VALUES('" + txtAcademicYearCode.Text + "', '" + cbnAcademicYear.Text + "', '" + rbtn1Active.Text + "', '" + rbtn2Inactive.Text + "')";

                try
                {
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        //MySqlDataReader dataReader 
                        cmd.ExecuteReader();
                        connect.CloseConnection();
                        MessageBox.Show("Record Successfully saved!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void txtAcademicYearCose_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
