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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsername.Focus();
            }
            else if (textPassword.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "EIMS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Focus();
            }
            else
            {
                try
                {
                    conn connect = new conn();
                    string query = "SELECT * FROM user WHERE Username='" + textUsername.Text.ToString() + "' AND Passsword='" + textPassword.Text.ToString() + "' AND Status=1";
                    //open connection
                    if (connect.OpenConnection() == true)
                    { 
                    //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        
                        //Read the data and store them in the list
                        if (dataReader.Read())
                        {
                           // MessageBox.Show("Authentication successful");
                            Dashboard das = new Dashboard();
                            das.Visible = true;
                            this.Hide();
                        }

                        else
                        {
                            textUsername.Text = "";
                            textPassword.Text = "";
                            textUsername.Focus();
                            MessageBox.Show("password/username mismatch!");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void gboLogin_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            gboLogin.Left = (this.Width - gboLogin.Width) / 2;
            gboLogin.Top = (this.Height - gboLogin.Height) / 2;
            textUsername.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textUsername.Focus();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
