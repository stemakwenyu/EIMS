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
    public partial class frmAdmnistrator : Form
    {
        string query;
        string usrCode;
        public frmAdmnistrator()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmAdmnistrator_Load(object sender, EventArgs e)
        {
            gboAdministrator.Left = (this.Width - gboAdministrator.Width) / 2;
            gboAdministrator.Top = (this.Height - gboAdministrator.Height) / 2;

            gboSearch.Visible = false;
            gboData.Visible = false;
            cboUserCode.Visible = false;
            cboUserCode.Focus();
            GetcboUserCode();

        }
        private void GetcboUserCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM user ORDER BY User_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboUserCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["User_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboUserCode.Items.Add(dataReader["User_Code"].ToString());

                    }
                }
                connect.CloseConnection();
            }
        }
        private void picLogo_Click(object sender, EventArgs e)
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
            txtEmailAddress.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNo.Text = "";
            txtPostalAddress.Text = "";
            txtUserCode.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserCode.Focus();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int user;
            if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
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
            else if (txtUserCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserCode.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (cboPriviledges.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPriviledges.Focus();
            }
            else if (dtpDateOfRegistration.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateOfRegistration.Focus();
            }
           /* else if (rbtnActive.Text == "")
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
                    user = 1;
                }
                else
                {
                   user = 0;
                }
                if (cboUserCode.Visible == true)
                {
                    query = "UPDATE user SET User_Code='" + cboUserCode.Text + "', F_Name='" + txtFirstName.Text + "', L_Name='" + txtLastName.Text + "', Postal_Address='" + txtPostalAddress.Text + "', Phone_No='" + txtPhoneNo.Text + "',Priviledges='" + cboPriviledges.Text + "',Passsword='" + txtPassword.Text + "',Date_Of_Reg='" + dtpDateOfRegistration.Text + "', '" + user + "' WHERE University_Code= '" + usrCode + "'";

                }
                else
                {
                    query = "INSERT INTO user(User_Code, Username, F_Name, L_Name, Postal_Address, Phone_No, Priviledges, Passsword, Date_Of_Reg, Satus) VALUES('" + txtUserName + "', '" + txtUserCode + "', '" + txtFirstName + "', '" + txtLastName + "', '" + txtPassword + "', '" + txtPhoneNo + "', '" + txtPostalAddress + "', '" + cboPriviledges + "', '" + dtpDateOfRegistration + "', '" + user + "')";

                }
                try
                {
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
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
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboUserCode.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboUserCode.Visible = true;
            cboUserCode.Focus();
        }

        private void cboUserCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUserCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUserCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM user WHERE User_Code LIKE '" + cboUserCode.Text + "' ORDER BY User_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.txtUserName.Text = dataReader["Username"].ToString();
                        this.txtFirstName.Text = dataReader["F_Name"].ToString();
                        this.txtLastName.Text = dataReader["F_Name"].ToString();
                        this.txtPostalAddress.Text = dataReader["Postal_Address"].ToString();
                        this.txtPhoneNo.Text = dataReader["Phone_No"].ToString();
                        this.txtPassword.Text = dataReader["Previledges"].ToString();
                        this.txtPassword.Text = dataReader["Passsword"].ToString();
                        this.dtpDateOfRegistration.Text = dataReader["Date_Of_Reg"].ToString();
                         dataReader["Status"].ToString();
                        
                        usrCode= dataReader["User_Code"].ToString();


                    }
                    connect.CloseConnection();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //for deletion
            if (cboUserCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboUserCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM user WHERE User_Code='" + cboUserCode.Text + "'";
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

        private void rbtnActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboUserCode.Visible = true;
            cboUserCode.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            usrCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSearchValue.Visible = false;
            gboData.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            txtSearchValue.Text = "";
            cboCriteria.Text = "";
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
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
                if (cboCriteria.Text == "cboUserCode")
                {
                    query = "SELECT * FROM user WHERE User_Code LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Username")
                {
                    query = "SELECT * FROM user WHERE Username LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "F_Name")
                {
                    query = "SELECT * FROM user WHERE F_Name LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "L_Name")
                {
                    query = "SELECT * FROM user WHERE L_Name LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Passsword")
                {
                    query = "SELECT * FROM user WHERE Passsword LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Status")
                {
                    query = "SELECT * FROM user WHERE Status LIKE '" + "%" + txtSearchValue.Text + "%" + "'";
                }


                else
                {
                    query = "SELECT * FROM user";
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

                        string[] row = new string[] { dataReader["User_Code"].ToString(), dataReader["Username"].ToString(), dataReader["F_Name"].ToString(), dataReader["L_Name"].ToString(), dataReader["Passsword"].ToString(), dataReader["Status"].ToString() };
                        dataGridView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible = true;
                    //gboSearch.Visible = false;
                }

            }
        }
    }
}

