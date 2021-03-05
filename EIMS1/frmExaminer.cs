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
    public partial class frmExaminer : Form
    {
        string query;
        string exaCode;
        public frmExaminer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cboExaminer_Code.Visible = false;
            txtExaminerCode.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmExaminer_Load(object sender, EventArgs e)
        {
            gboExaminer.Left = (this.Width - gboExaminer.Width) / 2;
            gboExaminer.Top = (this.Height - gboExaminer.Height) / 2;

            gboSearch.Visible = false;
            gboData.Visible = false;
            cboExaminer_Code.Visible = false;
            GetcboExaminer_Code();
        }
        private void GetcboExaminer_Code()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM examiner ORDER BY Examiner_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboExaminer_Code.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Examiner_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboExaminer_Code.Items.Add(dataReader["Examiner_Code"].ToString());

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
            
            txtEmailAddress.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtPhoneNo.Text = "";

            if (cboExaminer_Code.Visible == true)
            {
                cboExaminer_Code.Focus();
            }
            else
            {
                txtExaminerCode.Focus();
            }
            txtExaminerCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtExaminerCode.Text == "" && cboExaminer_Code.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExaminerCode.Focus();
            }
            if (cboExaminer_Code.Text == "" && txtExaminerCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboExaminer_Code.Focus();
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
            }
            else if (txtMiddleName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMiddleName.Focus();
            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
            }
            else if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
            }


            else
            {
                if (cboExaminer_Code.Visible == true)
                {
                    query = "UPDATE examiner SET Examiner_Code='" + cboExaminer_Code.Text + "',F_Name= '" + txtFirstName.Text + "',M_Name ='" + txtMiddleName.Text + "', L_Name='" + txtLastName.Text + "', Phone_No='" + txtPhoneNo.Text + "', Email_Address='" + txtEmailAddress.Text + "' WHERE Examiner_Code='" + exaCode + "'";

                }
                else
                {
                    query = "INSERT INTO examiner (Examiner_Code, F_Name, M_Name, L_Name, Phone_No, Email_Address) VALUES('" + txtExaminerCode.Text + "', '" + txtFirstName.Text + "', '" + txtMiddleName.Text + "', '" + txtLastName.Text + "', '" + txtPhoneNo.Text + "', '" + txtEmailAddress.Text + "')";

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
                        MessageBox.Show("Connection Successful");
                        Reset();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed" + ex);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboExaminer_Code.Visible = true;
            cboExaminer_Code.Focus();
        }

        private void cboExaminer_Code_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboExaminer_Code.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboExaminer_Code.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM examiner WHERE Examiner_Code LIKE '" + cboExaminer_Code.Text + "' ORDER BY Examiner_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.txtFirstName.Text = dataReader["F_Name"].ToString();
                        this.txtMiddleName.Text = dataReader["M_Name"].ToString();
                        this.txtLastName.Text = dataReader["L_Name"].ToString();
                        this.txtPhoneNo.Text = dataReader["Phone_No"].ToString();
                        this.txtEmailAddress.Text = dataReader["Email_Address"].ToString();
                        exaCode = dataReader["Examiner_Code"].ToString();
                    }
                    connect.CloseConnection();
                }

            }
        }

        private void gboExaminer_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboExaminer_Code.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboExaminer_Code.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)   
            {
                query = "DELETE FROM examiner WHERE Examiner_Code='" + cboExaminer_Code.Text + "'";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboExaminer_Code.Visible = false;
            cboExaminer_Code.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            exaCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSearch.Visible = false;
            gboData.Visible = false;
            
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void tbnAdvanceSearch_Click(object sender, EventArgs e)
        {
            if (cboCriteria.Text == "")
            {

                MessageBox.Show("Ensure all fields are filled");
                txtSearch.Focus();

            }
            if (txtSearch.Text == "" && cboCriteria.Text != "ALL")
            {

                MessageBox.Show("Ensure all fields are filled");
                txtSearch.Focus();

            }
            else
            {
                if (cboCriteria.Text == "Examiner_Code")
                {
                    query = "SELECT * FROM examiner WHERE Examiner_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "F_Name")
                {
                    query = "SELECT * FROM examiner WHERE F_Name LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "L_Name")
                {
                    query = "SELECT * FROM examiner WHERE L_Name LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Email_Address")
                {
                    query = "SELECT * FROM examiner WHERE Email_Address LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else
                {
                    query = "SELECT * FROM examiner";
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

                        string[] row = new string[] { dataReader["Examiner_Code"].ToString(), dataReader["F_Name"].ToString(), dataReader["L_Name"].ToString(), dataReader["Email_Address"].ToString() };
                        dataGridView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible = true;
                    txtSearch.Visible = false;
                }

            }
        }
    }
}
