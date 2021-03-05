namespace EIMS1
{
    partial class frmYear_Of_Study
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
            this.gboYearOfStudy = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.gboData = new System.Windows.Forms.GroupBox();
            this.dataGrideView1 = new System.Windows.Forms.DataGridView();
            this.Year_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDataQuit = new System.Windows.Forms.Button();
            this.btnSearchQuit = new System.Windows.Forms.Button();
            this.btnAdvanceSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboYearCode = new System.Windows.Forms.ComboBox();
            this.rbtn2Inactive = new System.Windows.Forms.RadioButton();
            this.rbtn1Active = new System.Windows.Forms.RadioButton();
            this.cbn2Semester = new System.Windows.Forms.ComboBox();
            this.cbn1YearOfStudy = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.txtYearCode = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblYearOfStudy = new System.Windows.Forms.Label();
            this.lblTearCode = new System.Windows.Forms.Label();
            this.gboYearOfStudy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboSearch.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboYearOfStudy
            // 
            this.gboYearOfStudy.BackColor = System.Drawing.Color.DarkCyan;
            this.gboYearOfStudy.Controls.Add(this.groupBox2);
            this.gboYearOfStudy.Controls.Add(this.groupBox1);
            this.gboYearOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboYearOfStudy.Location = new System.Drawing.Point(218, 48);
            this.gboYearOfStudy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gboYearOfStudy.Name = "gboYearOfStudy";
            this.gboYearOfStudy.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gboYearOfStudy.Size = new System.Drawing.Size(937, 444);
            this.gboYearOfStudy.TabIndex = 0;
            this.gboYearOfStudy.TabStop = false;
            this.gboYearOfStudy.Text = "Year of Study Details";
            this.gboYearOfStudy.Enter += new System.EventHandler(this.gboYearOfStudy_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnQuit);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(118, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(712, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(428, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(529, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(230, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 32);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnQuit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(619, 16);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(79, 32);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(114, 15);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 32);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(30, 15);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gboSearch);
            this.groupBox1.Controls.Add(this.cboYearCode);
            this.groupBox1.Controls.Add(this.rbtn2Inactive);
            this.groupBox1.Controls.Add(this.rbtn1Active);
            this.groupBox1.Controls.Add(this.cbn2Semester);
            this.groupBox1.Controls.Add(this.cbn1YearOfStudy);
            this.groupBox1.Controls.Add(this.lblSemester);
            this.groupBox1.Controls.Add(this.txtYearCode);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblYearOfStudy);
            this.groupBox1.Controls.Add(this.lblTearCode);
            this.groupBox1.Location = new System.Drawing.Point(118, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(712, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gboSearch
            // 
            this.gboSearch.Controls.Add(this.gboData);
            this.gboSearch.Controls.Add(this.btnSearchQuit);
            this.gboSearch.Controls.Add(this.btnAdvanceSearch);
            this.gboSearch.Controls.Add(this.txtSearch);
            this.gboSearch.Controls.Add(this.label8);
            this.gboSearch.Controls.Add(this.cboCriteria);
            this.gboSearch.Controls.Add(this.label7);
            this.gboSearch.Location = new System.Drawing.Point(30, 7);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(652, 275);
            this.gboSearch.TabIndex = 6;
            this.gboSearch.TabStop = false;
            // 
            // gboData
            // 
            this.gboData.Controls.Add(this.dataGrideView1);
            this.gboData.Controls.Add(this.btnDataQuit);
            this.gboData.Location = new System.Drawing.Point(-22, 0);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(696, 269);
            this.gboData.TabIndex = 6;
            this.gboData.TabStop = false;
            this.gboData.Text = "gboData";
            // 
            // dataGrideView1
            // 
            this.dataGrideView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrideView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Year_Code,
            this.YOS,
            this.Semester,
            this.Status});
            this.dataGrideView1.Location = new System.Drawing.Point(6, 0);
            this.dataGrideView1.Name = "dataGrideView1";
            this.dataGrideView1.Size = new System.Drawing.Size(684, 177);
            this.dataGrideView1.TabIndex = 2;
            this.dataGrideView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrideView1_CellContentClick);
            // 
            // Year_Code
            // 
            this.Year_Code.HeaderText = "Year Code";
            this.Year_Code.Name = "Year_Code";
            // 
            // YOS
            // 
            this.YOS.HeaderText = "YOS";
            this.YOS.Name = "YOS";
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.Name = "Semester";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnDataQuit
            // 
            this.btnDataQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnDataQuit.Location = new System.Drawing.Point(316, 216);
            this.btnDataQuit.Name = "btnDataQuit";
            this.btnDataQuit.Size = new System.Drawing.Size(75, 34);
            this.btnDataQuit.TabIndex = 1;
            this.btnDataQuit.Text = "Quit";
            this.btnDataQuit.UseVisualStyleBackColor = false;
            this.btnDataQuit.Click += new System.EventHandler(this.btnDataQuit_Click);
            // 
            // btnSearchQuit
            // 
            this.btnSearchQuit.BackColor = System.Drawing.Color.Red;
            this.btnSearchQuit.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuit.Location = new System.Drawing.Point(527, 188);
            this.btnSearchQuit.Name = "btnSearchQuit";
            this.btnSearchQuit.Size = new System.Drawing.Size(75, 40);
            this.btnSearchQuit.TabIndex = 5;
            this.btnSearchQuit.Text = "Quit";
            this.btnSearchQuit.UseVisualStyleBackColor = false;
            this.btnSearchQuit.Click += new System.EventHandler(this.btnSearchQuit_Click);
            // 
            // btnAdvanceSearch
            // 
            this.btnAdvanceSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdvanceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanceSearch.Location = new System.Drawing.Point(226, 188);
            this.btnAdvanceSearch.Name = "btnAdvanceSearch";
            this.btnAdvanceSearch.Size = new System.Drawing.Size(75, 40);
            this.btnAdvanceSearch.TabIndex = 4;
            this.btnAdvanceSearch.Text = "Search";
            this.btnAdvanceSearch.UseVisualStyleBackColor = false;
            this.btnAdvanceSearch.Click += new System.EventHandler(this.btnAdvanceSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(294, 120);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 28);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "All";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select Value";
            // 
            // cboCriteria
            // 
            this.cboCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "All",
            "Year Code",
            "YOS",
            "Semester",
            "Status"});
            this.cboCriteria.Location = new System.Drawing.Point(294, 27);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(280, 32);
            this.cboCriteria.TabIndex = 1;
            this.cboCriteria.Text = "All";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select Criteria";
            // 
            // cboYearCode
            // 
            this.cboYearCode.FormattingEnabled = true;
            this.cboYearCode.Location = new System.Drawing.Point(387, 45);
            this.cboYearCode.Name = "cboYearCode";
            this.cboYearCode.Size = new System.Drawing.Size(252, 24);
            this.cboYearCode.TabIndex = 1;
            this.cboYearCode.SelectedIndexChanged += new System.EventHandler(this.cboYearCode_SelectedIndexChanged);
            // 
            // rbtn2Inactive
            // 
            this.rbtn2Inactive.AutoSize = true;
            this.rbtn2Inactive.Location = new System.Drawing.Point(513, 223);
            this.rbtn2Inactive.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtn2Inactive.Name = "rbtn2Inactive";
            this.rbtn2Inactive.Size = new System.Drawing.Size(80, 20);
            this.rbtn2Inactive.TabIndex = 5;
            this.rbtn2Inactive.TabStop = true;
            this.rbtn2Inactive.Text = "Inactive";
            this.rbtn2Inactive.UseVisualStyleBackColor = true;
            // 
            // rbtn1Active
            // 
            this.rbtn1Active.AutoSize = true;
            this.rbtn1Active.Location = new System.Drawing.Point(387, 220);
            this.rbtn1Active.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtn1Active.Name = "rbtn1Active";
            this.rbtn1Active.Size = new System.Drawing.Size(69, 20);
            this.rbtn1Active.TabIndex = 4;
            this.rbtn1Active.TabStop = true;
            this.rbtn1Active.Text = "Active";
            this.rbtn1Active.UseVisualStyleBackColor = true;
            // 
            // cbn2Semester
            // 
            this.cbn2Semester.FormattingEnabled = true;
            this.cbn2Semester.Location = new System.Drawing.Point(387, 166);
            this.cbn2Semester.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbn2Semester.Name = "cbn2Semester";
            this.cbn2Semester.Size = new System.Drawing.Size(252, 24);
            this.cbn2Semester.TabIndex = 3;
            // 
            // cbn1YearOfStudy
            // 
            this.cbn1YearOfStudy.FormattingEnabled = true;
            this.cbn1YearOfStudy.Location = new System.Drawing.Point(387, 109);
            this.cbn1YearOfStudy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbn1YearOfStudy.Name = "cbn1YearOfStudy";
            this.cbn1YearOfStudy.Size = new System.Drawing.Size(252, 24);
            this.cbn1YearOfStudy.TabIndex = 2;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(40, 166);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(71, 18);
            this.lblSemester.TabIndex = 4;
            this.lblSemester.Text = "Semester";
            // 
            // txtYearCode
            // 
            this.txtYearCode.Location = new System.Drawing.Point(387, 46);
            this.txtYearCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYearCode.Name = "txtYearCode";
            this.txtYearCode.Size = new System.Drawing.Size(252, 22);
            this.txtYearCode.TabIndex = 1;
            this.txtYearCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(40, 223);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblYearOfStudy
            // 
            this.lblYearOfStudy.AutoSize = true;
            this.lblYearOfStudy.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearOfStudy.Location = new System.Drawing.Point(40, 109);
            this.lblYearOfStudy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYearOfStudy.Name = "lblYearOfStudy";
            this.lblYearOfStudy.Size = new System.Drawing.Size(114, 18);
            this.lblYearOfStudy.TabIndex = 1;
            this.lblYearOfStudy.Text = "Year Of Study";
            // 
            // lblTearCode
            // 
            this.lblTearCode.AutoSize = true;
            this.lblTearCode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTearCode.Location = new System.Drawing.Point(40, 46);
            this.lblTearCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTearCode.Name = "lblTearCode";
            this.lblTearCode.Size = new System.Drawing.Size(83, 18);
            this.lblTearCode.TabIndex = 0;
            this.lblTearCode.Text = "Year Code";
            // 
            // frmYear_Of_Study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 528);
            this.Controls.Add(this.gboYearOfStudy);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmYear_Of_Study";
            this.Text = "Year_Of_Study";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYear_Of_Study_Load);
            this.gboYearOfStudy.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboSearch.ResumeLayout(false);
            this.gboSearch.PerformLayout();
            this.gboData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboYearOfStudy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txtYearCode;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblYearOfStudy;
        private System.Windows.Forms.Label lblTearCode;
        private System.Windows.Forms.RadioButton rbtn2Inactive;
        private System.Windows.Forms.RadioButton rbtn1Active;
        private System.Windows.Forms.ComboBox cbn2Semester;
        private System.Windows.Forms.ComboBox cbn1YearOfStudy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboYearCode;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.Button btnDataQuit;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.Button btnSearchQuit;
        private System.Windows.Forms.Button btnAdvanceSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGrideView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn YOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}