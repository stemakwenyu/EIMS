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
        string acadyearCode;
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

            gboData.Visible =false;
            gboSearch.Visible = false;

            cboAcademicYearCode.Visible = false;
            cboAcademicYearCode.Focus();
            GetAcademicYearCode();
        }
        private void GetAcademicYearCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM academic_year ORDER BY Acad_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
               this.txtAcademicYearCode.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Acad_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboAcademicYearCode.Items.Add(dataReader["Acad_Code"].ToString());

                    }
                }
                connect.CloseConnection();
            }
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
            cboAcademicYearCode.Text = "";
            cbnAcademicYear.Text = "";
            rbtn2Inactive.Text = "";
            rbtn1Active.Text = "";
            txtAcademicYearCode.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int status;
            if (txtAcademicYearCode.Text == "" && cboAcademicYearCode.Visible==false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAcademicYearCode.Focus();
            }
            if (cboAcademicYearCode.Text == "" && cboAcademicYearCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAcademicYearCode.Focus();
            }
            else if (cbnAcademicYear.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbnAcademicYear.Focus();
            }
            /* else if (rbtn1Active.Text == "")
             {
                 MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 rbtn1Active.Focus();
             }
             else if (rbtn2Inactive.Text == "")
             {
                 MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 rbtn2Inactive.Focus();
             }*/

            else
            {
                status = 1;
                if (rbtn1Active.Checked == true)
                {
                    status = 1;
                }
                else
                {
                    status = 0;
                }
                      if (cboAcademicYearCode.Visible == true)
                    {
                        query = "UPDATE academic_year SET Acad_Code='" + cboAcademicYearCode.Text + "',Acad_Year='" + cbnAcademicYear.Text + "' ,Status='" + status + "' WHERE Centre_Code='" + acadyearCode + "'";

                    }
                    else
                    {
                        query = "INSERT INTO academic_year (Acad_Code, Acad_Year, Status) VALUES('" + txtAcademicYearCode.Text + "', '" + cbnAcademicYear.Text + "', '" + status + "')";
                    }
                    try
                    {
                        conn connect = new conn();
                        if (connect.OpenConnection() == true)
                        {
                            //MessageBox.Show("Hey");
                            //create command and assign the query and connection from the constructor
                            MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                            //MySqlDataReader dataReader 
                            cmd.ExecuteNonQuery();
                            connect.CloseConnection();
                            MessageBox.Show("Record Successfully saved!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed" + ex);
                    }
                }
            }
        

        private void txtAcademicYearCose_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboAcademicYearCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboAcademicYearCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM academic_year WHERE Acad_Code='" + cboAcademicYearCode.Text + "'";
                try
                {
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        cmd.ExecuteNonQuery();
                        connect.CloseConnection();
                        MessageBox.Show("Record Successfully deleted!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void cboAcademicYearCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAcademicYearCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAcademicYearCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM academic_year WHERE Acad_Code LIKE '" + cboAcademicYearCode.Text + "' ORDER BY Acad_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.cbnAcademicYear.Text = dataReader["Acad_Year"].ToString();
                        dataReader["Status"].ToString();
                        acadyearCode = dataReader["Acad_Code"].ToString();
                    }
                    connect.CloseConnection();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboAcademicYearCode.Visible = true;
            cboAcademicYearCode.Focus();
            Reset();
            //cbnAcademicYear.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbnAcademicYear.Visible = true;
            cbnAcademicYear.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            acadyearCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            gboSearch.Visible = false;
            gboData.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            cboCriteria.Text = "";
            txtSearch.Text = "";
            
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            if (cboCriteria.Text == "")
            {

                MessageBox.Show("Ensure all fields are filled");
                gboSearch.Focus();

            }
            if (txtSearch.Text == "" && cboCriteria.Text != "ALL")
            {

                MessageBox.Show("Ensure all fields are filled");
                txtSearch.Focus();

            }
            else
            {
                if (cboCriteria.Text == "Acad_Code")
                {
                    query = "SELECT * FROM academic_year WHERE Acad_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Acad_Year")
                {
                    query = "SELECT * FROM academic_year WHERE Status LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
               
                else
                {
                    query = "SELECT * FROM academic_year";
                }


                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    // query = "SELECT * FROM University WHERE University_Code LIKE '" + cboUniversityCode.Text + "' ORDER BY University_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    this.dataGridView1.Rows.Clear();
                    while (dataReader.Read())
                    {

                        string[] row = new string[] { dataReader["Acad_Code"].ToString(), dataReader["Acad_Year"].ToString(), dataReader["Status"].ToString() };
                        dataGridView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible = true;
                   // gboSearch.Visible = false;
                }

            }
        }
    }
}
