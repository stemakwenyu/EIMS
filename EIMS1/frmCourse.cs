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
   
    public partial class frmCourse : Form
    {
        string query;
        string courCode;
        public frmCourse()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            gboCourse.Left = (this.Width - gboCourse.Width) / 2;
            gboCourse.Top = (this.Height - gboCourse.Height) / 2;

            gboSearch.Visible = false;
            gboData.Visible = false;
            cboCourseCode.Visible = false;
            GetCourseCode();

        }
        private void GetCourseCode()
        {
            if (cboCourseCode.Visible == true)
                {

                    query = "UPDATE course SET Course_Code='" + cboCourseCode.Text + "', Course_Title='" + txtCourseName.Text + "', Description= '" + rtxtDescription.Text + "', Units='" + txtUnits.Text + "', Prog_Code='" + cboProgramCode.Text + "' WHERE Course_Code= '" + courCode + "'";

                }

                else
                {

                    query = "INSERT INTO course(Course_Code, Course_Title, Description, Units, Prog_Code) VALUES('" + cboCourseCode.Text + "', '" + txtCourseName.Text + "', '" + rtxtDescription.Text + "', '" + txtUnits.Text + "', '" + cboProgramCode.Text + "')";

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
            txtCourseCode.Text="";
            if (cboCourseCode.Visible == true)
            {
                cboCourseCode.Focus();
            }
            else 
            {
            txtCourseCode.Focus();
            }
            txtCourseName.Text="";
            txtUnits.Text="";
            cboProgramCode.Text="";
            rtxtDescription.Text="";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourseCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseCode.Focus();
            }
            else if ( txtCourseName.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtCourseName.Focus();
            }
            else if (txtUnits.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnits.Focus();
            }
                else if (cboProgramCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProgramCode.Focus();
            }
                else if (rtxtDescription.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtDescription.Focus();
            }
            if (cboCourseCode.Visible == true)
            {

                query = "UPDATE course SET Course_Code='" + cboCourseCode.Text + "', Course_Title='" + txtCourseName.Text + "', Description= '" + rtxtDescription.Text + "', Units='" + txtUnits.Text + "', Prog_Code='" + cboProgramCode.Text + "' WHERE Course_Code= '" + courCode + "'";

            }
            else{
            
                conn connect = new conn();
                query = "INSERT INTO course(Course_Code, Course_Title, Description, Units, Prog_Code ) VALUES('" + txtCourseCode.Text + "', '" + txtCourseName.Text + "', '" + rtxtDescription.Text + "', '" + txtUnits.Text + "', '" + cboProgramCode.Text + "' )";  

                //string query = "SELECT * FROM user WHERE Username='" + textUsername.Text.ToString() + "' AND Passsword='" + textPassword.Text.ToString() + "' AND Status=1";
                //open connection
                if (connect.OpenConnection() == true)
                {
                    
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    cmd.ExecuteNonQuery();
                    connect.CloseConnection();
                    MessageBox.Show("Connection successful");
                    Reset();
                }
        }
        }

        private void cboCourseCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCourseCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCourseCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM course WHERE Course_Code LIKE '" + cboCourseCode.Text + "' ORDER BY Course_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.txtCourseName.Text = dataReader["Course_Title"].ToString();
                        this.txtUnits.Text= dataReader["Units"].ToString();
                        this.rtxtDescription.Text = dataReader["Description"].ToString();
                        this.cboProgramCode.Text = dataReader["Prog_Code"].ToString();
                       
                       courCode = dataReader["Course_Code"].ToString();
                    }
                    connect.CloseConnection();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboCourseCode.Visible = true;
            cboCourseCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboCourseCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboCourseCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM course WHERE Course_Code='" + cboCourseCode.Text + "'";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboCourseCode.Visible = false;
            txtCourseCode.Focus();
            Reset();
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;

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
            cboCourseCode.Visible = true;
            cboCourseCode.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            courCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSearch.Visible = false;
            gboData.Visible = false;
        }

        private void tbnAdvanceSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
