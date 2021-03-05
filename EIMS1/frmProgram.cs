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
    public partial class frmProgram : Form
    {
        string query;
        string proCode;
        public frmProgram()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmProgram_Load(object sender, EventArgs e)
        {
            gboProgram.Left = (this.Width - gboProgram.Width) / 2;
            gboProgram.Top = (this.Height - gboProgram.Height) / 2;

            gboSearch.Visible = false;
            gboData.Visible = false;

            cboProgramCode.Visible = true;
            GetProgramCode();
        }
        private void GetProgramCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM Program ORDER BY Prog_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboProgramCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Prog_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboProgramCode.Items.Add(dataReader["Prog_Code"].ToString());

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboProgramCode.Text == "" && cbo2ProgramCode.Visible ==false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramCode.Focus();
            }
            else if (cbo2ProgramCode.Text == "" && cbo2ProgramCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo2ProgramCode.Focus();
            }
            else if (cboProgramName.Text == "" )
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramName.Focus();
            }
            else if (cboDepartmentCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartmentCode.Focus();
            }
            else if (cboDuration.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDuration.Focus();
            }
            else if (rtxtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtDescription.Focus();
            }


            else
            {

                if (cbo2ProgramCode.Visible == true)
                {
                    query = "UPDATE program SET Prog_Code='" + cbo2ProgramCode.Text + "',Prog_Name='" + cboProgramName.Text + "' ,Description='" + rtxtDescription.Text + "',Description='" + rtxtDescription.Text + "',Description='" + rtxtDescription.Text + "' WHERE Prog_Code='" + proCode + "'";

                }
                else
                {
                    query = "INSERT INTO Program(Prog_Code, Prog_Name, Description, Duration, Dept_Code) VALUES('" + cboProgramCode.Text + "', '" + cboProgramName.Text + "', '" + rtxtDescription.Text + "', '" + cboDepartmentCode.Text + "', '" + cboDuration.Text + "')";
                }
                try
                {
                   // MessageBox.Show("Am there");
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        cmd.ExecuteReader();
                        connect.CloseConnection();
                        MessageBox.Show("Successfull");
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
        /*private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            cboDepartmentCode.Text = "";
            cboProgramCode.Text = "";
            cboProgramName.Text = "";
            cboDuration.Text = "";
            rtxtDescription.Text = "";
        }*/

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cboProgramCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboProgramCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM program WHERE Program_Code LIKE '" + cboProgramCode.Text + "' ORDER BY Prog_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.cboProgramName.Text = dataReader["Prog_Name"].ToString();
                        this.rtxtDescription.Text = dataReader["Description"].ToString();
                        this.cboDuration.Text = dataReader["Duration"].ToString();
                        this.cboDepartmentCode.Text = dataReader["Dept_COde"].ToString();
                        proCode= dataReader["Prog_Code"].ToString();
                    }
                    connect.CloseConnection();
                }

            }
        }

       // private void button2_Click(object sender, EventArgs e)
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboProgramCode.Visible = true;
            cboProgramCode.Focus();
            Reset();

       
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            if (cboProgramCode.Text == "" && cbo2ProgramCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramCode.Focus();
            }
            else if (cbo2ProgramCode.Text == "" && cbo2ProgramCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo2ProgramCode.Focus();
            }
            else if (cboProgramName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramName.Focus();
            }
            else if (rtxtDescription.Text =="")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtDescription.Focus();
            }
            else if (cboDuration.Text=="")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDuration.Focus();
            }
            else if (cboDepartmentCode.Text=="")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartmentCode.Focus();
            }


            else
            {
                if (cboProgramCode.Visible == false)
                {
                    query = "UPDATE program SET Prog_Code='" + cboProgramCode.Text + "',Prog_Name= '" + cboProgramName.Text + "',Description ='" + rtxtDescription.Text + "', Duration='" + cboDuration.Text + "', Dept_Code='" + cboDepartmentCode.Text + "' WHERE Prog_Code='" + proCode + "'";

                }
                else
                {
                    query = "INSERT INTO program (Prog_Code, Prog_Name, Description, Duration, Dept_Code) VALUES('" + cboProgramCode.Text + "', '" + cboProgramName.Text + "', '" + rtxtDescription.Text + "', '" + cboDuration.Text + "', '" + cboDepartmentCode.Text + "')";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //for deletion
            if (cboProgramCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboProgramCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM program WHERE Prog_Code='" + cboProgramCode.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
        
        private void Reset()
        {
            cboProgramCode.Text = "";
            cboProgramName.Text = "";
            cboDuration.Text = "";
            rtxtDescription.Text = "";
            cboDepartmentCode.Text = "";
            cboProgramCode.Focus();
            GetProgramCode();
            
        }

            private void button1_Click(object sender, EventArgs e)
            {
                 if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

            private void cboProgramCode_SelectedIndexChanged_1(object sender, EventArgs e)
            {
                if (cbo2ProgramCode.Text == "")
                {
                    MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo2ProgramCode.Focus();
                }
                else
                {

                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        query = "SELECT * FROM program WHERE Prog_Code LIKE '" + cbo2ProgramCode.Text + "' ORDER BY Prog_Code ASC";
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        //Read the data and store them in the list

                        if (dataReader.Read())
                        {

                            this.cboProgramCode.Text = dataReader["Prog_Code"].ToString();
                            this.cboProgramName.Text = dataReader["Prog_Code"].ToString();
                            this.rtxtDescription.Text = dataReader["Description"].ToString();
                            this.cboDuration.Text = dataReader["Duration"].ToString();
                            this.cboDepartmentCode.Text = dataReader["Dept_Code"].ToString();
                            
                            proCode = dataReader["Prog_Code"].ToString();       //for editing


                        }
                        connect.CloseConnection();
                    }

                }
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                cbo2ProgramCode.Visible = false;
                cboProgramCode.Focus();
                Reset();
            }

            private void button2_Click_1(object sender, EventArgs e)
            {

            }

            private void btn1Reset_Click(object sender, EventArgs e)
            {
                cboProgramCode.Text = "";
                if (cbo2ProgramCode.Visible == true)
                {

                    cbo2ProgramCode.Focus();
                }
                else
                {
                    cboProgramCode.Focus();
                }
                cboProgramName.Text = "";
                cboDepartmentCode.Text = "";
                cboDuration.Text = "";
                rtxtDescription.Text = "";
                
            }

            private void gboSearch_Enter(object sender, EventArgs e)
            {

            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                gboSearch.Visible = true;
                cboCriteria.Text = "";
                txtSearch.Text="";
            }

            private void btnDataQuit_Click(object sender, EventArgs e)
            {
                gboData.Visible = false;
            }

            private void btnSearchQuit_Click(object sender, EventArgs e)
            {
                gboSearch.Visible = false;
            }

            private void tbnAdvanceSearch_Click(object sender, EventArgs e)
            {
                if (cboCriteria.Text == "")
                {

                    MessageBox.Show("Ensure all fields are filled");
                    cboCriteria.Focus();

                }
                if (txtSearch.Text == "" && cboCriteria.Text != "ALL")
                {

                    MessageBox.Show("Ensure all fields are filled");
                    txtSearch.Focus();

                }
                else
                {
                    if (cboCriteria.Text == "Prog_Code")
                    {
                        query = "SELECT * FROM program WHERE Prog_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                    }
                    else if (cboCriteria.Text == "Prog_Name")
                    {
                        query = "SELECT * FROM program WHERE Prog_Name LIKE '" + "%" + txtSearch.Text + "%" + "'";
                    }
                    else if (cboCriteria.Text == "Duration")
                    {
                        query = "SELECT * FROM program WHERE Duration LIKE '" + "%" + txtSearch.Text + "%" + "'";
                    }
                    else if (cboCriteria.Text == "Dept_Code")
                    {
                        query = "SELECT * FROM program WHERE Dept_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                    }
                    else
                    {
                        query = "SELECT * FROM program";
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

                            string[] row = new string[] { dataReader["Prog_Code"].ToString(), dataReader["Prog_Name"].ToString(), dataReader["Duration"].ToString(), dataReader["Dept_Code"].ToString() };
                            dataGridView1.Rows.Add(row);

                        }
                        connect.CloseConnection();
                        gboData.Visible = true;
                        gboSearch.Visible = false;
                    }

                }
            }
      }
    }

