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
    public partial class frmDepartment : Form
    {
        string query;
        string deptCode;
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            gboDepartment.Left = (this.Width - gboDepartment.Width) / 2;
            gboDepartment.Top = (this.Height - gboDepartment.Height) / 2;

            gboData.Visible = false;
            gboSearch.Visible = false;

            cboDepartmentCode.Visible =false;
            GetDepartmentCode();
            
        }
        private void GetDepartmentCode()
           {

            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM Department ORDER BY Dept_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboFacultyCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Dept_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboDepartmentCode.Items.Add(dataReader["Dept_Code"].ToString());

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
            txtDepartmentCode.Text = "";
            if (cboDepartmentCode.Visible == true)
            {
                cboDepartmentCode.Focus();
            }
            else
            {
               txtDepartmentCode.Focus();
            }
            rtxtDescription.Text = "";
            cboDepartmentName.Text = "";
            cboFacultyCode.Text = "";
            //txtDepartmentCode.Focus();
        }

        private void cboDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartmentCode.Text == "" && cboDepartmentCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartmentCode.Focus();
            }
            else if (cboDepartmentCode.Text == "" && cboDepartmentCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartmentCode.Focus();
            }
            else if (rtxtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtDescription.Focus();
            }
            else if (cboDepartmentName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartmentName.Focus();
            }
            else if (cboFacultyCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFacultyCode.Focus();
            }

            else
            {
                if (cboDepartmentCode.Visible == true)
                {
                    query = "UPDATE department SET Dept_Code='" + cboDepartmentCode.Text + "',Dept_Name='" + cboDepartmentName.Text + "' ,Description='" + rtxtDescription.Text + "',Faculty_Code='" + cboFacultyCode.Text + "' WHERE Dept_Code='" + deptCode + "'";

                }
                else
                {


                    query = "INSERT INTO department(Dept_Code, Dept_Name, Description, Faculty_Code ) VALUES('" + txtDepartmentCode.Text + "', '" + cboDepartmentName.Text + "', '" + rtxtDescription.Text + "', '" + cboFacultyCode.Text + "')";

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
                        MessageBox.Show("successful");
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
            if (cboDepartmentCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboDepartmentCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM department WHERE Dept_Code='" + cboDepartmentCode.Text + "'";
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
            cboDepartmentCode.Visible = true;
            cboDepartmentCode.Focus();
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboDepartmentCode.Visible = false;
            txtDepartmentCode.Focus();
            Reset();
        }

        private void cboDepartmentCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartmentCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartmentCode.Focus();
            }
            else
            {
                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM department WHERE Dept_Code LIKE '" + cboDepartmentCode.Text + "' ORDER BY Dept_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    if (dataReader.Read())
                    {

                        this.cboDepartmentName.Text = dataReader["Dept_Name"].ToString();
                        this.rtxtDescription.Text = dataReader["Description"].ToString();
                        this.cboFacultyCode.Text = dataReader["Faculty_Code"].ToString();

                        deptCode = dataReader["Dept_Code"].ToString();
                    }
                    connect.CloseConnection();



                }
            }
        }

        private void gboDepartment_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible=true;
            txtSearchValue.Text = "";
            cboCriteria.Text = ""; ;
        }

        private void gboData_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
            txtSearchValue.Text = "";
            cboCriteria.Text = "";
        }

        private void tbnAdvanceSearch_Click(object sender, EventArgs e)
        {

            if (cboCriteria.Text == "")
            {

                MessageBox.Show("Ensure all fields are filled");
                cboCriteria.Focus();

            }
            if (txtSearchValue.Text == "" && cboCriteria.Text != "ALL")
            {

                MessageBox.Show("Ensure all fields are filled");
                txtSearchValue.Focus();

            }
            else
            {
                if (cboCriteria.Text == "Dept_Code")
                {
                    query = "SELECT * FROM department WHERE Dept_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Dept_Name")
                {
                    query = "SELECT * FROM department WHERE Dept_Name LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Description")
                {
                    query = "SELECT * FROM department WHERE Description LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Faculty_Code")
                {
                    query = "SELECT * FROM department WHERE Faculty_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else
                {
                    query = "SELECT * FROM department";
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

                        string[] row = new string[] { dataReader["Dept_Code"].ToString(), dataReader["Dept_Name"].ToString(), dataReader["Description"].ToString(), dataReader["Faculty_Code"].ToString() };
                        dataGridView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible = true;
                    gboSearch.Visible = false;
                }

            }
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboDepartmentCode.Visible = true;
            cboDepartmentCode.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            deptCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSearchValue.Visible = false;
            gboData.Visible = false;
        }
    }
}
