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
    public partial class frmExam : Form
    {
        string query;
        string xamCode;
        public frmExam()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            cbnExamCode.Visible = true;
            cbnExamCode.Focus();
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            gboExam.Left = (this.Width - gboExam.Width) / 2;
            gboExam.Top = (this.Height - gboExam.Height)/2;

            gbosearch.Visible = false;
            gboData.Visible = false;
            cbnExamCode.Visible = false;
            GetcboExamCode();
        }
        private void GetcboExamCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM Exam ORDER BY Exam_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cbnExamCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Exam_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cbnExamCode.Items.Add(dataReader["Exam_Code"].ToString());

                    }
                }
                connect.CloseConnection();
            }
        }
        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
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
            txtCourseCode.Text = "";
            if (cbnExamCode.Visible == false)
            {
                cbnExamCode.Focus();
            }
            else
            {
                txtExamCode.Focus();
            }
            txtE_ExaminerCode.Text = "";
            txtExamCode.Text = "";
            txtExaminerCode.Text = "";
            txtRegNo.Text = "";
            cboExamType.Text = "";
            dtpExamDate.Text = "";
            //txtExamCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourseCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseCode.Focus();
            }
            else if (txtE_ExaminerCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtE_ExaminerCode.Focus();
            }
            else if (txtExamCode.Text == "" && cbnExamCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExamCode.Focus();
            }
            else if (cbnExamCode.Text == "" && cbnExamCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbnExamCode.Focus();
            
            }
            else if (txtExaminerCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExaminerCode.Focus();
            }
            else if (txtRegNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();
            }

            else if (txtExaminerCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExaminerCode.Focus();
            }
            else if (cboExamType.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboExamType.Focus();
            }
            else if (dtpExamDate.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpExamDate.Focus();
            }


            else
            {
                if (cboExamType.Visible == true)
                {
                    query = "UPDATE exam SET Exam_Code='" + cbnExamCode.Text + "',Course_COde= '" + txtCourseCode.Text + "',Reg_No ='" + txtRegNo.Text + "', Examiner_Code='" + txtExaminerCode.Text + "', E_Examiner_Code='" + txtE_ExaminerCode.Text + "', Exam_Type='" + cboExamType.Text + "', Exam_Date='" + dtpExamDate.Text + "' WHERE Exam_Code='" + xamCode + "'";

                }
                else
                {

                    query = "INSERT INTO Exam(Exam_Code, Reg_No, Course_Code, Examiner_Code, E_Examiner_COde, Exam_Type, Exam_Date) VALUES('" + txtExamCode.Text + "', '" + txtExaminerCode.Text + "', '" + txtRegNo.Text + "', '" + txtE_ExaminerCode + "', '" + txtCourseCode.Text + "', '" + cboExamType.Text + "', '" + dtpExamDate.Text + "')";

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
                        MessageBox.Show("Successful" );
                        Reset();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed" + ex);
                }
            }
        }

        private void dtpExamDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbnExamCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbnExamCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM exam WHERE Exam_Code LIKE '" + cbnExamCode.Text + "' ORDER BY University_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.txtCourseCode.Text = dataReader["Course_Code"].ToString();
                        this.txtRegNo.Text = dataReader["Reg_No"].ToString();
                        this.txtExaminerCode.Text = dataReader["Examiner_Code"].ToString();
                        this.txtE_ExaminerCode.Text = dataReader["E_Examiner_Code"].ToString();
                        this.cboExamType.Text = dataReader["Exam_Type"].ToString();
                        this.dtpExamDate.Text = dataReader["Exam_Date"].ToString();
                        

                    }
                    connect.CloseConnection();
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //cbnExamCode.Visible = false;
            if (cbnExamCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cbnExamCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM exam WHERE Exam_Code='" + cbnExamCode.Text + "'";
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
            gbosearch.Visible = true;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbnExamCode.Visible = false;
            cbnExamCode.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            xamCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSearch.Visible = false;
            gboData.Visible = false;
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gbosearch.Visible = false;
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
                if (cboCriteria.Text == "Exam_Code")
                {
                    query = "SELECT * FROM exam WHERE Exam_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Course_Code")
                {
                    query = "SELECT * FROM exam WHERE Course_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Reg_No")
                {
                    query = "SELECT * FROM exam WHERE Reg_No LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Exan_Type")
                {
                    query = "SELECT * FROM exam WHERE Exan_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else
                {
                    query = "SELECT * FROM exam";
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
                    txtSearch.Visible = false;
                }

            }
        }

        private void btnSearchQuit_Click_1(object sender, EventArgs e)
        {

        }

        private void tbnAdvanceSearch_Click_1(object sender, EventArgs e)
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
                if (cboCriteria.Text == "Exam_Code")
                {
                    query = "SELECT * FROM exam WHERE Exam_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Course_Code")
                {
                    query = "SELECT * FROM exam WHERE Course_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Reg_No")
                {
                    query = "SELECT * FROM exam WHERE Reg_No LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Exam_Type")
                {
                    query = "SELECT * FROM exam WHERE Exam_Type LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else
                {
                    query = "SELECT * FROM exam";
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

                        string[] row = new string[] { dataReader["Exam_Code"].ToString(), dataReader["Course_Code"].ToString(), dataReader["Reg_No"].ToString(), dataReader["Exam_Type"].ToString() };
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
