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
    public partial class frmStudent : Form
    {
        string query;
        string stdCode;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void gboStudent_Enter(object sender, EventArgs e)
        {
            gboStudent.Left = (this.Width - gboStudent.Width) / 2;
            gboStudent.Top = (this.Height - gboStudent.Height) / 2;

            gboSearch.Visible = false;
            gboData.Visible = false;

            cboRegNo.Visible = false;
            GetRegNo();

        }
        private void GetRegNo()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM Student ORDER BY Reg_No ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboRegNo.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Reg_No"].ToString().Replace(" ", "") != "")
                    {
                        this.cboRegNo.Items.Add(dataReader["Reg_No"].ToString());

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
            txtRegNo.Text = "";
            if (cboRegNo.Visible == true)
            {
                cboRegNo.Focus();
            }
            else
            {
                txtRegNo.Focus();
            }
            txtEmailAddress.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtPhoneNo.Text = "";
            txtPostalAddress.Text = "";
            cboRegNo.Text = "";
            rbtnActive.Text = "";
            rbtnInactive.Text = "";
            

            GetRegNo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stat;
           if (txtRegNo.Text == "" && cboRegNo.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtRegNo.Focus();
            }
           else if (cboRegNo.Text == "" && cboRegNo.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRegNo.Focus();
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
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
            }
            else if (txtPostalAddress.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostalAddress.Focus();
            }
            else if (cboProgramCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramCode.Focus();
            }
            else if (cboAcademicCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAcademicCode.Focus();
            }
            else if (cboYearCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYearCode.Focus();
            }
            /*else if (rbtnActive.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtnActive.Focus();
            }
            else if (rbtnInactive.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtnInactive.Focus();
            }*/
            else
            {
                if (rbtnActive.Checked == true)
                {
                    stat = 1;
                }
                else
                {
                    stat = 0;
                }
                if (cboRegNo.Visible == true)
                {
                    query = "UPDATE student SET Reg_No='" + cboRegNo.Text + "',F_Name='" + txtFirstName.Text + "' ,M_Name='" + txtMiddleName.Text + "',L_Name='" + txtLastName.Text + "',Status='" + stat + "',Phone_No='" + txtPhoneNo.Text + "',Email_Address='" + txtEmailAddress.Text + "',Postal_Address='" + txtPostalAddress.Text + "',Prog_Code='" + cboProgramCode.Text + "',Acad_Code='" + cboAcademicCode.Text + "',Year_Code='" + cboYearCode.Text + "' WHERE Reg_No='" + stdCode + "'";

                }
                else
                {
                    query = "INSERT INTO student(Reg_No, F_Name, M_Name, L_Name, Status, Phone_No,Email_Address, Postal_Address, Prog_Code, Acad_Code, Year_Code) VALUES('" + txtRegNo.Text + "', '" + txtFirstName.Text + "', '" + txtMiddleName.Text + "', '" + txtLastName.Text + "', '" + stat + "', '" + txtPhoneNo.Text + "', '" + txtEmailAddress.Text + "','" + txtPostalAddress.Text + "', '" + cboProgramCode.Text + "', '" + cboAcademicCode.Text + "', '" + cboYearCode.Text + "')";
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

                        MessageBox.Show("Record Successfully saved!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed!" + ex);
                }
            }
        }

        private void cboAcademicCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboRegNo.Visible = false;
            cboRegNo.Focus();
        }

        private void cboRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboRegNo.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRegNo.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM student WHERE Reg_No LIKE '" + cboRegNo.Text + "' ORDER BY Reg_No ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.txtFirstName.Text = dataReader["F_Name"].ToString();
                        this.txtMiddleName.Text = dataReader["M_Name"].ToString();
                        this.txtLastName.Text = dataReader["L_Name"].ToString();
                        this.txtEmailAddress.Text = dataReader["Email_Address"].ToString();
                        this.txtPhoneNo.Text = dataReader["Phone_No"].ToString();
                        this.txtPostalAddress.Text = dataReader["Postal_Address"].ToString();
                        //this.rbtnActive.Text = dataReader["Status"].ToString();
                        //this.rbtnInactive.Text = dataReader["Status"].ToString();
                        dataReader["Status"].ToString();
                       
                    }
                    connect.CloseConnection();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           cboRegNo.Visible = true;
           cboRegNo.Focus();
           Reset();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboRegNo.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboRegNo.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM student WHERE Reg_No='" + cboRegNo.Text + "'";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            txtSearchValue.Text = "";
            cboCriteria.Text = "";
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboRegNo.Visible = true;
            cboRegNo.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            stdCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSearchValue.Visible = false;
            gboData.Visible = false;
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
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
                if (cboCriteria.Text == "cboRegNo")
                {
                    query = "SELECT * FROM student WHERE cboRegNo LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "F_Name")
                {
                    query = "SELECT * FROM student WHERE F_Name LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "L_Name")
                {
                    query = "SELECT * FROM student WHERE L_Name LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Prog_Code")
                {
                    query = "SELECT * FROM student WHERE Prog_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Acad_Code")
                {
                    query = "SELECT * FROM student WHERE Acad_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Year_Code")
                {
                    query = "SELECT * FROM student WHERE Year_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }


                else
                {
                    query = "SELECT * FROM student";
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

                        string[] row = new string[] { dataReader["Reg_No"].ToString(), dataReader["F_Name"].ToString(), dataReader["L_Name"].ToString(), dataReader["Prog_Code"].ToString(), dataReader["Acad_Code"].ToString(), dataReader["Year_Code"].ToString() };
                        dataGridView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible = true;
                    //gboSearch.Visible = false;
                }

            }
        }

        private void btnAdvanceSearch_Click_1(object sender, EventArgs e)
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
                if (cboCriteria.Text == "Reg_No")
                {
                    query = "SELECT * FROM student WHERE Reg_No LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                if (cboCriteria.Text == "F_Name")
                {
                    query = "SELECT * FROM student WHERE F_Name LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                if (cboCriteria.Text == "L_Name")
                {
                    query = "SELECT * FROM student WHERE L_Name LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Prog_Code")
                {
                    query = "SELECT * FROM student WHERE Prog_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Acad_Code")
                {
                    query = "SELECT * FROM student WHERE Acad_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Year_Code")
                {
                    query = "SELECT * FROM student WHERE Year_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else
                {
                    query = "SELECT * FROM student";
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

                        string[] row = new string[] { dataReader["Reg_No"].ToString(), dataReader["F_Name"].ToString(), dataReader["L_Name"].ToString(), dataReader["Prog_Code"].ToString(), dataReader["Acad_Code"].ToString(), dataReader["Year_Code"].ToString() };
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
