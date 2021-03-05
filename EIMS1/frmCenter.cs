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
    public partial class frmCenter : Form
    {
        string query;
        string cenCode;
        public frmCenter()
        {
            InitializeComponent();
        }

        private void frmCenter_Load(object sender, EventArgs e)
        {
            gboCenter.Left = (this.Width - gboCenter.Width) / 2;
            gboCenter.Top = (this.Height - gboCenter.Height) / 2;

            gboData.Visible = false;
            gboSearch.Visible = false;

            cboCentreCode.Visible = false;
            txtCenterCode.Focus();
            GetCentreCode();
        }
        private void GetCentreCode()
        {
            conn connect = new conn();
            if (connect.OpenConnection() == true)
            {
                query = "SELECT * FROM centre ORDER BY Centre_Code ASC";
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                this.cboCentreCode.Items.Clear();
                while (dataReader.Read())
                {
                    if (dataReader["Centre_Code"].ToString().Replace(" ", "") != "")
                    {
                        this.cboCentreCode.Items.Add(dataReader["Centre_Code"].ToString());
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

        private void txtUniversityCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtCenterCode.Text = "";
            txtCenterName.Text = "";
            txtLocation.Text = "";
            txtUniversityCode.Text = "";
           
            if (cboCentreCode.Visible == true)
            {
                cboCentreCode.Focus();
            }
            else
            {
                txtCenterCode.Focus();
            }
            GetCentreCode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCenterCode.Text == "" && cboCentreCode.Visible == false)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCenterCode.Focus();
            }
            else if (cboCentreCode.Text == "" && cboCentreCode.Visible == true)
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCentreCode.Focus();
            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
            }
            else if (txtUniversityCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUniversityCode.Focus();
            }
            else
            {
                if (cboCentreCode.Visible == true)
                {
                    query = "UPDATE centre SET Centre_Code='" + cboCentreCode.Text + "',Centre_Name='" + txtCenterName.Text + "' ,Location='" + txtLocation.Text + "',University_Code='" + txtUniversityCode.Text + "' WHERE Centre_Code='" + cenCode + "'";

                }
                else
                {
                    query = "INSERT INTO centre(Centre_Code,Centre_Name,Location, University_Code) VALUES('" + txtCenterCode.Text + "','" + txtCenterName.Text + "', '" + txtLocation.Text + "','" + txtUniversityCode.Text + "')";
                }
                try
                {
                    conn connect = new conn();
                    if (connect.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboCentreCode.Visible = true;
            cboCentreCode.Focus();
            Reset();
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboCentreCode.Visible = false;
            txtCenterCode.Focus();
            Reset();
        }

        private void cboCentreCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCentreCode.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCentreCode.Focus();
            }
            else
            {
                conn connect = new conn();
                if (connect.OpenConnection() == true)
                {
                    query = "SELECT * FROM centre WHERE Centre_Code LIKE '" + cboCentreCode.Text + "' ORDER BY Centre_Code ASC";
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    if (dataReader.Read())
                    {

                        this.txtCenterName.Text = dataReader["Centre_Name"].ToString();
                        this.txtLocation.Text = dataReader["Location"].ToString();
                        this.txtUniversityCode.Text = dataReader["University_Code"].ToString();

                        cenCode = dataReader["Centre_Code"].ToString();
                    }
                    connect.CloseConnection();



                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //for deletion
            if (cboCentreCode.Visible == false)
            {
                MessageBox.Show("Select Details to Edit");
                cboCentreCode.Visible = true;
            }
            else if (MessageBox.Show("Are you sure you want to exit?", "EIMS Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                query = "DELETE FROM centre WHERE Centre_Code='" + cboCentreCode.Text + "'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = true;
            txtSearch.Text = "";
            cboCriteria.Text="";
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
                if (cboCriteria.Text == "Centre_Code")
                {
                    query = "SELECT * FROM centre WHERE Centre_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "Location")
                {
                    query = "SELECT * FROM centre WHERE Location LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }
                else if (cboCriteria.Text == "University_Code")
                {
                    query = "SELECT * FROM centre WHERE University_Code LIKE '" + "%" + txtSearch.Text + "%" + "'";
                }

                else
                {
                    query = "SELECT * FROM centre";
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

                        string[] row = new string[] { dataReader["Centre_Code"].ToString(), dataReader["Centre_Name"].ToString(), dataReader["Location"].ToString(), dataReader["University_Code"].ToString() };
                        dataGridView1.Rows.Add(row);

                    }
                    connect.CloseConnection();
                    gboData.Visible = true;
                    // gboSearch.Visible = false;
                }

            }
        }

        private void btnSearchQuit_Click(object sender, EventArgs e)
        {
            gboSearch.Visible = false;
            txtSearch.Text = "";
            cboCriteria.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboCentreCode.Visible = false;
            txtCenterName.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();

            cenCode = this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            gboSearch.Visible = false;
            gboData.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gboData.Visible = false;
        }
    }
}
    

    


    

