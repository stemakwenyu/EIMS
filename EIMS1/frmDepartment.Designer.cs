namespace EIMS1
{
    partial class frmDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboDepartment = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDepartmentCode = new System.Windows.Forms.ComboBox();
            this.cboFacultyCode = new System.Windows.Forms.ComboBox();
            this.cboDepartmentName = new System.Windows.Forms.ComboBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtDepartmentCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDataQuit = new System.Windows.Forms.Button();
            this.btnSearchQuit = new System.Windows.Forms.Button();
            this.tbnAdvanceSearch = new System.Windows.Forms.Button();
            this.gboDepartment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboDepartment
            // 
            this.gboDepartment.BackColor = System.Drawing.Color.DarkCyan;
            this.gboDepartment.Controls.Add(this.groupBox2);
            this.gboDepartment.Controls.Add(this.groupBox1);
            this.gboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDepartment.Location = new System.Drawing.Point(136, 25);
            this.gboDepartment.Name = "gboDepartment";
            this.gboDepartment.Size = new System.Drawing.Size(829, 449);
            this.gboDepartment.TabIndex = 0;
            this.gboDepartment.TabStop = false;
            this.gboDepartment.Text = "Department Details";
            this.gboDepartment.Enter += new System.EventHandler(this.gboDepartment_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnQuit);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(57, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(306, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(518, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnEdit.Location = new System.Drawing.Point(213, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnQuit.Location = new System.Drawing.Point(614, 25);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 36);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(117, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(22, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gboData);
            this.groupBox1.Controls.Add(this.gboSearch);
            this.groupBox1.Controls.Add(this.cboDepartmentCode);
            this.groupBox1.Controls.Add(this.cboFacultyCode);
            this.groupBox1.Controls.Add(this.cboDepartmentName);
            this.groupBox1.Controls.Add(this.rtxtDescription);
            this.groupBox1.Controls.Add(this.txtDepartmentCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gboData
            // 
            this.gboData.Controls.Add(this.dataGridView1);
            this.gboData.Controls.Add(this.btnDataQuit);
            this.gboData.Location = new System.Drawing.Point(41, 31);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(610, 236);
            this.gboData.TabIndex = 6;
            this.gboData.TabStop = false;
            this.gboData.Text = "gboData";
            this.gboData.Enter += new System.EventHandler(this.gboData_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentCode,
            this.deptname,
            this.descri,
            this.faccode});
            this.dataGridView1.Location = new System.Drawing.Point(-19, -13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 127);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.HeaderText = "Department Code";
            this.DepartmentCode.Name = "DepartmentCode";
            // 
            // deptname
            // 
            this.deptname.HeaderText = "Department Name";
            this.deptname.Name = "deptname";
            // 
            // descri
            // 
            this.descri.HeaderText = "Description";
            this.descri.Name = "descri";
            // 
            // faccode
            // 
            this.faccode.HeaderText = "Faculty Code";
            this.faccode.Name = "faccode";
            // 
            // gboSearch
            // 
            this.gboSearch.Controls.Add(this.btnSearchQuit);
            this.gboSearch.Controls.Add(this.tbnAdvanceSearch);
            this.gboSearch.Controls.Add(this.txtSearchValue);
            this.gboSearch.Controls.Add(this.cboCriteria);
            this.gboSearch.Controls.Add(this.label6);
            this.gboSearch.Controls.Add(this.label5);
            this.gboSearch.Location = new System.Drawing.Point(22, 22);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(643, 251);
            this.gboSearch.TabIndex = 5;
            this.gboSearch.TabStop = false;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(259, 115);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(201, 26);
            this.txtSearchValue.TabIndex = 3;
            this.txtSearchValue.Text = "All";
            // 
            // cboCriteria
            // 
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "All",
            "Department Code",
            "Department Name",
            "Description",
            "Faculty Code"});
            this.cboCriteria.Location = new System.Drawing.Point(259, 33);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(201, 28);
            this.cboCriteria.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search Criteria";
            // 
            // cboDepartmentCode
            // 
            this.cboDepartmentCode.FormattingEnabled = true;
            this.cboDepartmentCode.Location = new System.Drawing.Point(272, 31);
            this.cboDepartmentCode.Name = "cboDepartmentCode";
            this.cboDepartmentCode.Size = new System.Drawing.Size(283, 28);
            this.cboDepartmentCode.TabIndex = 1;
            this.cboDepartmentCode.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentCode_SelectedIndexChanged);
            // 
            // cboFacultyCode
            // 
            this.cboFacultyCode.FormattingEnabled = true;
            this.cboFacultyCode.Items.AddRange(new object[] {
            "Select",
            "SCAI",
            "FESS",
            "FS",
            "SOBE",
            "POST GRADUATE"});
            this.cboFacultyCode.Location = new System.Drawing.Point(272, 151);
            this.cboFacultyCode.Name = "cboFacultyCode";
            this.cboFacultyCode.Size = new System.Drawing.Size(283, 28);
            this.cboFacultyCode.TabIndex = 3;
            // 
            // cboDepartmentName
            // 
            this.cboDepartmentName.FormattingEnabled = true;
            this.cboDepartmentName.Location = new System.Drawing.Point(272, 94);
            this.cboDepartmentName.Name = "cboDepartmentName";
            this.cboDepartmentName.Size = new System.Drawing.Size(283, 28);
            this.cboDepartmentName.TabIndex = 2;
            this.cboDepartmentName.SelectedIndexChanged += new System.EventHandler(this.cboDepartmentName_SelectedIndexChanged);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(272, 196);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(283, 43);
            this.rtxtDescription.TabIndex = 4;
            this.rtxtDescription.Text = "";
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.Location = new System.Drawing.Point(275, 33);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(280, 26);
            this.txtDepartmentCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Faculty Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Code";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Image = global::EIMS1.Properties.Resources.Webp4;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(396, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 36);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDataQuit
            // 
            this.btnDataQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnDataQuit.Image = global::EIMS1.Properties.Resources.Webp1;
            this.btnDataQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataQuit.Location = new System.Drawing.Point(256, 194);
            this.btnDataQuit.Name = "btnDataQuit";
            this.btnDataQuit.Size = new System.Drawing.Size(84, 33);
            this.btnDataQuit.TabIndex = 0;
            this.btnDataQuit.Text = "Quit";
            this.btnDataQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDataQuit.UseVisualStyleBackColor = false;
            this.btnDataQuit.Click += new System.EventHandler(this.btnDataQuit_Click);
            // 
            // btnSearchQuit
            // 
            this.btnSearchQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnSearchQuit.Image = global::EIMS1.Properties.Resources.Webp_net_resizeimage__1_;
            this.btnSearchQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchQuit.Location = new System.Drawing.Point(374, 196);
            this.btnSearchQuit.Name = "btnSearchQuit";
            this.btnSearchQuit.Size = new System.Drawing.Size(86, 34);
            this.btnSearchQuit.TabIndex = 5;
            this.btnSearchQuit.Text = "Quit";
            this.btnSearchQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchQuit.UseVisualStyleBackColor = false;
            this.btnSearchQuit.Click += new System.EventHandler(this.btnSearchQuit_Click);
            // 
            // tbnAdvanceSearch
            // 
            this.tbnAdvanceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbnAdvanceSearch.Image = global::EIMS1.Properties.Resources.Webp3;
            this.tbnAdvanceSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnAdvanceSearch.Location = new System.Drawing.Point(122, 197);
            this.tbnAdvanceSearch.Name = "tbnAdvanceSearch";
            this.tbnAdvanceSearch.Size = new System.Drawing.Size(97, 33);
            this.tbnAdvanceSearch.TabIndex = 4;
            this.tbnAdvanceSearch.Text = "Search";
            this.tbnAdvanceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnAdvanceSearch.UseVisualStyleBackColor = false;
            this.tbnAdvanceSearch.Click += new System.EventHandler(this.tbnAdvanceSearch_Click);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 519);
            this.Controls.Add(this.gboDepartment);
            this.Name = "frmDepartment";
            this.Text = "Department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.gboDepartment.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboSearch.ResumeLayout(false);
            this.gboSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboDepartmentName;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtDepartmentCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFacultyCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboDepartmentCode;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.Button btnSearchQuit;
        private System.Windows.Forms.Button tbnAdvanceSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.Button btnDataQuit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptname;
        private System.Windows.Forms.DataGridViewTextBoxColumn descri;
        private System.Windows.Forms.DataGridViewTextBoxColumn faccode;
        private System.Windows.Forms.Button btnSearch;
    }
}