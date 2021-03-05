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
    public partial class frmStudentExam : Form
    {
        string query;
        string stdxamCode;
        public frmStudentExam()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void picBackground_Click(object sender, EventArgs e)
        {

        }

        private void frmStudentExam_Load(object sender, EventArgs e)
        {
            gboStudentExam.Left = (this.Width - gboStudentExam.Width) / 2;
            gboStudentExam.Top = (this.Height - gboStudentExam.Height) / 2;

            gboSearch.Visible = false;
            gboData.Visible = false;
            GetProgramCode();


        }
        private void GetProgramCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM student_Exam ORDER BY Stud_Exam_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboStudentExamCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Stud_Exam_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboStudentExamCode.Items.Add(dataReader["Stud_Exam_Code"].ToString());

                    }
                }
                connect.CloseConnection();
            }
        }
        private void gboStudentExam_Enter(object sender, EventArgs e)
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
            txtExamCode.Text = "";
            if (cboStudentExamCode.Visible == false)
            {
                cboStudentExamCode.Focus();
            }
            else
            {
                txtStudentExamCode.Focus();
            }
            txtExternalCat.Text = "";
            txtExternalSemester.Text = "";
            txtInternalCat.Text = "";
            txtInternalSemester.Text = "";
            txtRegNo.Text = "";
            txtStudentExamCode.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtExamCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExamCode.Focus();
            }
            else if (txtExternalCat.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExternalCat.Focus();
            }
            else if (txtExternalSemester.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExternalSemester.Focus();
            }
            else if (txtInternalCat.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInternalCat.Focus();
            }
            else if (txtInternalSemester.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInternalSemester.Focus();
            }
            else if (txtRegNo.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Focus();
            }
            else if (txtStudentExamCode.Text == "" && cboStudentExamCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentExamCode.Focus();
            }
            else if (cboStudentExamCode.Text == "" && cboStudentExamCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStudentExamCode.Focus();
            }
            


            else
            {
                query = "INSERT INTO student_exam(Stud_Exam_Code, Reg_No, Exam_Code, I_CAT, I_Semester, E_CAT, E_Semester) VALUES('" + txtStudentExamCode.Text + "', '" + txtRegNo.Text + "', '" + txtExamCode.Text + "', '" + txtInternalCat.Text + "', '" + txtInternalSemester.Text + "',  '" + txtExternalSemester.Text + "', '" + txtExternalSemester.Text + "')";

                //string query = "SELECT * FROM user WHERE Username='" + textUsername.Text.ToString() + "' AND Passsword='" + textPassword.Text.ToString() + "' AND Status=1";
                //open connection
                try
                {
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        MessageBox.Show("Am there!");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboStudentExamCode.Text == "")
            {
                MessageBox.Show("Ensure that all fields are filled!", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStudentExamCode.Focus();
            }
            else
            {

                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM student_exam WHERE Stud_Exam_Code LIKE '" + cboStudentExamCode.Text + "' ORDER BY Stud_Exam_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list

                    if (dataReader.Read())
                    {

                        this.txtRegNo.Text = dataReader["Reg_No"].ToString();
                        this.txtExamCode.Text = dataReader["Exam_Code"].ToString();
                        this.txtInternalCat.Text = dataReader["I_CAT"].ToString();
                        this.txtInternalSemester.Text = dataReader["I_Semester"].ToString();
                        this.txtExternalCat.Text = dataReader["E_CAT"].ToString();
                        this.txtExternalSemester.Text = dataReader["E_Semester"].ToString();
                        stdxamCode = dataReader["Stud_Exam_Code"].ToString();       //for editing


                    }
                    connect.CloseConnection();
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboStudentExamCode.Visible = true;
            cboStudentExamCode.Focus();
            Reset();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboStudentExamCode.Visible = false;
            Reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboStudentExamCode.Visible = true;
            cboStudentExamCode.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            stdxamCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtSearch.Visible = false;
            gboData.Visible = false;
        }

        private void btnDataQuit_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
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
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
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
                if (cboCriteria.Text == "Stud_Exam_Code")
                {
                    query = "SELECT * FROM student_exam WHERE Stud_Exam_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Reg_No")
                {
                    query = "SELECT * FROM student_exam WHERE Reg_No LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Exam_Code")
                {
                    query = "SELECT * FROM student_exam WHERE Exam_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                
                else
                {
                    query = "SELECT * FROM student_exam";
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

                        string[] row = new string[] { dataReader["Stud_Exam_Code"].ToString(), dataReader["Reg_No"].ToString(), dataReader["Exam_Code"].ToString()};
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
