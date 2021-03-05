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
    public partial class frmYear_Of_Study : Form
    {
        string query;
        string yearCode;
        public frmYear_Of_Study()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void frmYear_Of_Study_Load(object sender, EventArgs e)
        {
            gboYearOfStudy.Left = (this.Width - gboYearOfStudy.Width) / 2;
            gboYearOfStudy.Top = (this.Height - gboYearOfStudy.Height) / 2;

            gboData.Visible =false;
            gboSearch.Visible =false;

            cboYearCode.Visible = false;
            txtYearCode.Focus();
            GetYearCode();

        }
        private void GetYearCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM year_of_study ORDER BY Year_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboYearCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Year_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboYearCode.Items.Add(dataReader["Year_Code"].ToString());
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
            txtYearCode.Text = "";
            if (cboYearCode.Visible == true)
            {
                cboYearCode.Focus();
            }
            else
            {
                txtYearCode.Focus();
            }
            
            cbn1YearOfStudy.Text = "";
            cbn2Semester.Text = "";
            
           // txtYearCode.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int status;
            if (cbn1YearOfStudy.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbn1YearOfStudy.Focus();
            }
            else if (cbn2Semester.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbn2Semester.Focus();
            }
            else if (txtYearCode.Text == "" && cboYearCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearCode.Focus();
            }
            else if (cboYearCode.Text == "" && cboYearCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYearCode.Focus();
            }
            /*else if (rbtn1Active.Text == "")
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
                status = 0;
                if (rbtn1Active.Checked == true)
                {
                    status = 1;
                }
                else if(rbtn2Inactive.Checked == true)
                {
                    status = 0;
                }
               
                   if (cboYearCode.Visible == true)
                    {
                        query = "UPDATE year_of_study SET Year_Code='" + cboYearCode.Text + "',Yos='" + cbn1YearOfStudy.Text + "', Semester='" + cbn2Semester.Text  + "',Status='" + status + "' WHERE Year_Code='" + yearCode + "'";

                    }
                 else{

                        query = "INSERT INTO year_of_study(Year_Code, Yos,Semester, Status) VALUES('" + cboYearCode.Text + "', '" + cbn1YearOfStudy.Text + "', '"+ cbn2Semester.Text +"', '" + status + "')";
                   }
                       try
                {
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //for deletion
            if (txtYearCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                txtYearCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM year_of_study WHERE Year_Code='" + txtYearCode.Text + "'";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboYearCode.Visible = true;
            cboYearCode.Focus();
            GetYearCode();
            Reset();
        }

        private void gboYearOfStudy_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboYearCode.Visible = false;
            txtYearCode.Focus();
            Reset();
        }

        private void cboYearCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYearCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYearCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM year_of_study WHERE Year_Code LIKE '" + cboYearCode.Text + "' ORDER BY Year_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.cbn1YearOfStudy.Text = dataReader["Yos"].ToString();
                        this.cbn2Semester.Text = dataReader["Semester"].ToString();
                        dataReader["Semester"].ToString();
                        yearCode = dataReader["Year_Code"].ToString();
                    }
                    connect.CloseConnection();
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
             if (cboCriteria.Text=="")
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
            if(cboCriteria.Text == "Year_Code")
            {
            query="SELECT * FROM year_of_study WHERE Year_Code LIKE '"  + "%" + txtSearch.Text +"%"+"'";
            }
            else if (cboCriteria.Text == "Yos")
            {
                query = "SELECT * FROM year_of_study WHERE Yos LIKE '" + "%" + txtSearch.Text + "%" + "'";
            }
            else if (cboCriteria.Text == "Location")
            {
                query = "SELECT * FROM year_of_study WHERE Semmester LIKE '" + "%" + txtSearch.Text + "%" + "'";
            }
            else if (cboCriteria.Text == "Town")
            {
                query = "SELECT * FROM year_of_study WHERE Status LIKE '" + "%" + txtSearch.Text + "%" + "'";
            }
            else
            {
                query = "SELECT * FROM year_of_study";
            }
           
            
                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                   // query = "SELECT * FROM University WHERE University_Code LIKE '" + cboUniversityCode.Text + "' ORDER BY University_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    this.dataGrideView1.Rows.Clear();
                    while (dataReader.Read())
                    {

                        string[] row = new string[] { dataReader["Year_Code"].ToString(), dataReader["Yos"].ToString(), dataReader["Semester"].ToString(), dataReader["Status"].ToString() };
                       dataGrideView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible =true;
                    //gboSearch.Visible =false;
                }

            }
            }

        private void dataGrideView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboYearCode.Visible = true;
            cboYearCode.Text = this.dataGrideView1.Rows[this.dataGrideView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            yearCode = this.dataGrideView1.Rows[this.dataGrideView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            gboSearch.Visible = false;
            gboData.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            cboCriteria.Text="";
            txtSearch.Text="";
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
            txtSearch.Text="";
            cboCriteria.Text="";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
            

        }
    }

