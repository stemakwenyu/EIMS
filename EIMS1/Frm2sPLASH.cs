using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIMS1
{
    public partial class Frm2sPLASH : Form
    {
        public Frm2sPLASH()
        {
            InitializeComponent();
        }

        private void Frm2sPLASH_Load(object sender, EventArgs e)
        {
            this.Width = this.MdiParent.Width;
            this.Height = this.MdiParent.Height;
            gboMain.Left = (this.Width - gboMain.Width) / 2;
            gboMain.Top = (this.Height - gboMain.Height) / 2;
           
            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
