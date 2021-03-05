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
    public partial class frmUniversity : Form
    {
        string query;
        string uniCode;//global variable
        public frmUniversity()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUniversityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gboUniversity_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmUniversity_Load(object sender, EventArgs e)
        {
            gboUniversity.Left = (this.Width - gboUniversity.Width) / 2;
            gboUniversity.Top = (this.Height - gboUniversity.Height) / 2;
            gboSearch.Visible = false;
            gboData.Visible = false;
            cboUniversityCode.Visible = false;
            GetUniversityCode();

        }
        private void GetUniversityCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM University ORDER BY University_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboUniversityCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["University_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboUniversityCode.Items.Add(dataReader["University_Code"].ToString());

                    }
                }
                connect.CloseConnection();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Application.Exit();


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
            txtUniversityCode.Text = "";
            txtUniversityName.Text = "";
            txtZipCode.Text = "";
            txtTown.Text = "";
            txtPostalAddress.Text = "";
            txtLocation.Text = "";

            if (cboUniversityCode.Visible == false)
            {
                cboUniversityCode.Focus();
            }
            else
            {
                txtUniversityCode.Focus();
            }
            txtUniversityCode.Focus();
            GetUniversityCode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUniversityCode.Text == "" && cboUniversityCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityCode.Focus();
            }
            if (cboUniversityCode.Text == "" && cboUniversityCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUniversityCode.Focus();
            }
            else if (txtUniversityName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityName.Focus();
            }
            else if (txtZipCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZipCode.Focus();
            }
            else if (txtTown.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
            }


            else
            {
                if (cboUniversityCode.Visible == true)
                {

                    query = "UPDATE university SET University_Code='" + cboUniversityCode.Text + "', University_Name='" + txtUniversityName.Text + "', Location= '" + txtLocation.Text + "', Postal_Code='" + txtPostalAddress.Text + "', Zip_Code='" + txtZipCode.Text + "', Town='" + txtTown.Text + "' WHERE University_Code= '" + uniCode + "'";

                }

                else
                {

                    query = "INSERT INTO University(University_Code, University_Name, Location, Postal_Code, Zip_Code, Town) VALUES('" + txtUniversityCode.Text + "', '" + txtUniversityName.Text + "', '" + txtLocation.Text + "', '" + txtPostalAddress.Text + "', '" + txtZipCode.Text + "', '" + txtTown.Text + "')";

                }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboUniversityCode.Visible = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboUniversityCode.Visible = false;
            Reset();
            txtUniversityCode.Focus();
        }

        private void cboUniversityCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboUniversityCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUniversityCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM University WHERE University_Code LIKE '" + cboUniversityCode.Text + "' ORDER BY University_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.txtUniversityName.Text = dataReader["University_Name"].ToString();
                        this.txtPostalAddress.Text = dataReader["Postal_Code"].ToString();
                        this.txtLocation.Text = dataReader["Location"].ToString();
                        this.txtZipCode.Text = dataReader["Zip_Code"].ToString();
                        this.txtTown.Text = dataReader["Town"].ToString();
                        uniCode = dataReader["University_Code"].ToString();       //for editing


                    }
                    connect.CloseConnection();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //for deletion
            if (cboUniversityCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboUniversityCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM university WHERE University_Code='" + cboUniversityCode.Text + "'";
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gboSearch_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboUniversityCode.Visible = true;
            cboUniversityCode.Text = this.dataGrideView1.Rows[this.dataGrideView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            uniCode = this.dataGrideView1.Rows[this.dataGrideView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            gboSearch.Visible = false;
            gboData.Visible = false;
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
            if(cboCriteria.Text == "University_Code")
            {
            query="SELECT * FROM university WHERE University_Code LIKE '"  + "%" + txtSearch.Text +"%"+"'";
            }
            else if (cboCriteria.Text == "University_Name")
            {
                query = "SELECT * FROM university WHERE University_Name LIKE '" + "%" + txtSearch.Text + "%" + "'";
            }
            else if (cboCriteria.Text == "Location")
            {
                query = "SELECT * FROM university WHERE Location LIKE '" + "%" + txtSearch.Text + "%" + "'";
            }
            else if (cboCriteria.Text == "Town")
            {
                query = "SELECT * FROM university WHERE Town LIKE '" + "%" + txtSearch.Text + "%" + "'";
            }
            else
            {
                query = "SELECT * FROM university";
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

                      string [] row = new string[] {dataReader["University_Code"].ToString(),dataReader["University_Name"].ToString(), dataReader["Location"].ToString(), dataReader["Town"].ToString() };
                       dataGrideView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible =true;
                    //gboSearch.Visible =false;
                }

            }
            }
            

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
          gboData.Visible =false;
            
        }

        private void gboData_Enter(object sender, EventArgs e)
        {

        }
        }

    }




