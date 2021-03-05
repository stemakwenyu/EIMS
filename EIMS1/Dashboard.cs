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
    public partial class Dashboard : Form
    {
        private int childFormNumber = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       /* private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }*/

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Frm2sPLASH man = new Frm2sPLASH();
            man.MdiParent = this;
            man.Visible = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Visible = true;
            this.Dispose();
        }

        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUniversity uni = new frmUniversity();
            uni.MdiParent = this;
            uni.Visible = true;
            
        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCenter cen = new frmCenter();
            cen.MdiParent = this;
            cen.Visible = true;
        }

        private void academicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademicYear acd = new frmAcademicYear();
            acd.MdiParent = this;
            acd.Visible = true;
        }

        private void yearOfStudyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYear_Of_Study yos = new frmYear_Of_Study();
            yos.MdiParent = this;
            yos.Visible = true;
        }

        private void facultyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFaculty fac = new frmFaculty();
            fac.MdiParent = this;
            fac.Visible = true;
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment dept = new frmDepartment();
            dept.MdiParent = this;
            dept.Visible = true;
        }

        private void programToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProgram prog = new frmProgram();
            prog.MdiParent = this;
            prog.Visible = true;
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse cou = new frmCourse();
            cou.MdiParent = this;
            cou.Visible = true;
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent std = new frmStudent();
            std.MdiParent = this;
            std.Visible = true;
        }

        private void examToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExam exam = new frmExam();
            exam.MdiParent = this;
            exam.Visible = true;
        }

        private void examinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExaminer examn = new frmExaminer();
            examn.MdiParent = this;
            examn.Visible = true;
        }

        private void studentExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentExam stdExa = new frmStudentExam();
            stdExa.MdiParent = this;
            stdExa.Visible = true;
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmnistrator admin = new frmAdmnistrator();
            admin.MdiParent = this;
            admin.Visible = true;
        }
    }
}
