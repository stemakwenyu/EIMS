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
    public partial class frmFaculty : Form
    {
        string query;
        string facCode;
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            gboFaculty.Left = (this.Width - gboFaculty.Width) / 2;
            gboFaculty.Top = (this.Height - gboFaculty.Height) / 2;

            gboData.Visible = false;
            gboSearch.Visible = false;

            cbo1FacultyCode.Visible = false;
            
            GetFacultyCode();
        }
        private void GetFacultyCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM Faculty ORDER BY Faculty_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboFacultyCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Faculty_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboFacultyCode.Items.Add(dataReader["Faculty_Code"].ToString());

                    }
                }
                connect.CloseConnection();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            cboFacultyCode.Text = "";
            if (cbo1FacultyCode.Visible == true)
            {
                cbo1FacultyCode.Focus();
            }
            else
            {
                cboFacultyCode.Focus();
            }
            cboFacultyName.Text = "";
            txtUniversityCode.Text = "";
            rtxtDescription.Text = "";
            GetFacultyCode();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cboFacultyCode.Text == "" && cbo1FacultyCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFacultyCode.Focus();
            }
            else  if (cbo1FacultyCode.Text == "" && cbo1FacultyCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo1FacultyCode.Focus();
            }
            else if (cboFacultyName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFacultyName.Focus();
            }
            else if (txtUniversityCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityCode.Focus();
            }
            else if (rtxtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtDescription.Focus();
            }


            else
            {
                if (cbo1FacultyCode.Visible == true)
            
                {
                    query = "UPDATE faculty SET Faculty_Code='" + cboFacultyCode.Text + "',Faculty_Name='" + cboFacultyName.Text + "' ,Description='" + rtxtDescription.Text + "' WHERE Faculty_Code='" + facCode + "'";

                }
                else 
                {

                query = "INSERT INTO Faculty(Faculty_Code, Faculty_Name, Description, University_Code) VALUES('" + cboFacultyCode.Text + "', '" + cboFacultyName.Text + "', '" + rtxtDescription.Text + "', '" + txtUniversityCode.Text + "')";

                }
                try
                {
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        cmd.ExecuteNonQuery();
                        connect.CloseConnection();
                        MessageBox.Show("Successful");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboFacultyCode.Visible = true;
            cboFacultyCode.Focus();
        }

        private void cboFacultyName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbo1FacultyCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cbo1FacultyCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM faculty WHERE Faculty_Code='" + cbo1FacultyCode.Text + "'";
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

        private void cboFacultyCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboFacultyCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFacultyCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM Faculty WHERE Faculty_Code LIKE '" + cboFacultyCode.Text + "' ORDER BY Faculty_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.cboFacultyCode.Text = dataReader["Faculty_Code"].ToString();
                        this.cboFacultyName.Text = dataReader["Faculty_Name"].ToString();
                        this.rtxtDescription.Text = dataReader["Description"].ToString();
                        this.txtUniversityCode.Text = dataReader["University_Code"].ToString();
                        
                       facCode = dataReader["University_Code"].ToString();       //for editing


                    }
                    connect.CloseConnection();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbo1FacultyCode.Visible = false;
            cboFacultyCode.Focus();
            Reset();
        }

        private void cbo1FacultyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo1FacultyCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo1FacultyCode.Focus();
            }
            else
            {
                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM faculty WHERE Faculty_Code LIKE '" + cbo1FacultyCode.Text + "' ORDER BY Faculty_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    if (dataReader.Read())
                    {

                        this.cboFacultyName.Text = dataReader["Faculty_Name"].ToString();
                        this.txtUniversityCode.Text = dataReader["University_Code"].ToString();
                        this.rtxtDescription.Text = dataReader["Cescription"].ToString();

                        facCode = dataReader["Faculty_Code"].ToString();
                    }
                    connect.CloseConnection();



                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            txtSearch.Text = "";
            cboCriteria.Text = "";
            
        }

        private void gboSearch_Enter(object sender, EventArgs e)
        {

        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
            cboCriteria.Text = "";
            txtSearch.Text = "";
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
                if (cboCriteria.Text == "Faculty_Code")
                {
                    query = "SELECT * FROM faculty WHERE Faculty_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Faculty_Name")
                {
                    query = "SELECT * FROM faculty WHERE Faculty_Name LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Description")
                {
                    query = "SELECT * FROM faculty WHERE Description LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "University_Code")
                {
                    query = "SELECT * FROM faculty WHERE University_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else
                {
                    query = "SELECT * FROM faculty";
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

                        string[] row = new string[] { dataReader["Faculty_Code"].ToString(), dataReader["Faculty_Name"].ToString(), dataReader["Description"].ToString(), dataReader["University_Code"].ToString() };
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
