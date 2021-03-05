namespace EIMS1
{
    partial class frmExam
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbosearch = new System.Windows.Forms.GroupBox();
            this.gboData = new System.Windows.Forms.GroupBox();
            this.btnDataQuit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.examcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchQuit = new System.Windows.Forms.Button();
            this.tbnAdvanceSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbnExamCode = new System.Windows.Forms.ComboBox();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.cboExamType = new System.Windows.Forms.ComboBox();
            this.txtExaminerCode = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtE_ExaminerCode = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtExamCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gboExam = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbosearch.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.gboExam.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.picLogo);
            this.groupBox2.Location = new System.Drawing.Point(98, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 301);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::EIMS1.Properties.Resources.e5c6aeb82f4b1e8d0cf64e00bc5add242;
            this.picLogo.Location = new System.Drawing.Point(29, 16);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(159, 243);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.gbosearch);
            this.groupBox3.Controls.Add(this.cbnExamCode);
            this.groupBox3.Controls.Add(this.dtpExamDate);
            this.groupBox3.Controls.Add(this.cboExamType);
            this.groupBox3.Controls.Add(this.txtExaminerCode);
            this.groupBox3.Controls.Add(this.txtCourseCode);
            this.groupBox3.Controls.Add(this.txtE_ExaminerCode);
            this.groupBox3.Controls.Add(this.txtRegNo);
            this.groupBox3.Controls.Add(this.txtExamCode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(316, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 301);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // gbosearch
            // 
            this.gbosearch.Controls.Add(this.gboData);
            this.gbosearch.Controls.Add(this.btnSearchQuit);
            this.gbosearch.Controls.Add(this.tbnAdvanceSearch);
            this.gbosearch.Controls.Add(this.txtSearch);
            this.gbosearch.Controls.Add(this.cboCriteria);
            this.gbosearch.Controls.Add(this.label8);
            this.gbosearch.Controls.Add(this.label9);
            this.gbosearch.Location = new System.Drawing.Point(-199, 14);
            this.gbosearch.Name = "gbosearch";
            this.gbosearch.Size = new System.Drawing.Size(653, 275);
            this.gbosearch.TabIndex = 14;
            this.gbosearch.TabStop = false;
            // 
            // gboData
            // 
            this.gboData.Controls.Add(this.btnDataQuit);
            this.gboData.Controls.Add(this.dataGridView1);
            this.gboData.Location = new System.Drawing.Point(0, 0);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(664, 269);
            this.gboData.TabIndex = 13;
            this.gboData.TabStop = false;
            this.gboData.Text = "gboData";
            // 
            // btnDataQuit
            // 
            this.btnDataQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnDataQuit.Image = global::EIMS1.Properties.Resources.Webp1;
            this.btnDataQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataQuit.Location = new System.Drawing.Point(354, 225);
            this.btnDataQuit.Name = "btnDataQuit";
            this.btnDataQuit.Size = new System.Drawing.Size(84, 33);
            this.btnDataQuit.TabIndex = 1;
            this.btnDataQuit.Text = "Quit";
            this.btnDataQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDataQuit.UseVisualStyleBackColor = false;
            this.btnDataQuit.Click += new System.EventHandler(this.btnDataQuit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examcode,
            this.coursecode,
            this.reg,
            this.examtype});
            this.dataGridView1.Location = new System.Drawing.Point(205, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // examcode
            // 
            this.examcode.HeaderText = "Exam Code";
            this.examcode.Name = "examcode";
            // 
            // coursecode
            // 
            this.coursecode.HeaderText = "Coorse Code";
            this.coursecode.Name = "coursecode";
            // 
            // reg
            // 
            this.reg.HeaderText = "Reg No";
            this.reg.Name = "reg";
            // 
            // examtype
            // 
            this.examtype.HeaderText = "Exam Type";
            this.examtype.Name = "examtype";
            // 
            // btnSearchQuit
            // 
            this.btnSearchQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnSearchQuit.Image = global::EIMS1.Properties.Resources.Webp_net_resizeimage__1_;
            this.btnSearchQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchQuit.Location = new System.Drawing.Point(542, 179);
            this.btnSearchQuit.Name = "btnSearchQuit";
            this.btnSearchQuit.Size = new System.Drawing.Size(86, 34);
            this.btnSearchQuit.TabIndex = 12;
            this.btnSearchQuit.Text = "Quit";
            this.btnSearchQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchQuit.UseVisualStyleBackColor = false;
            this.btnSearchQuit.Click += new System.EventHandler(this.btnSearchQuit_Click_1);
            // 
            // tbnAdvanceSearch
            // 
            this.tbnAdvanceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbnAdvanceSearch.Image = global::EIMS1.Properties.Resources.Webp_net_resizeimage__3_;
            this.tbnAdvanceSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnAdvanceSearch.Location = new System.Drawing.Point(279, 179);
            this.tbnAdvanceSearch.Name = "tbnAdvanceSearch";
            this.tbnAdvanceSearch.Size = new System.Drawing.Size(97, 33);
            this.tbnAdvanceSearch.TabIndex = 11;
            this.tbnAdvanceSearch.Text = "Search";
            this.tbnAdvanceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnAdvanceSearch.UseVisualStyleBackColor = false;
            this.tbnAdvanceSearch.Click += new System.EventHandler(this.tbnAdvanceSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(440, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "All";
            // 
            // cboCriteria
            // 
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "All",
            "Exam Code",
            "Course Code ",
            "Reg No",
            "Exam Type"});
            this.cboCriteria.Location = new System.Drawing.Point(440, 11);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(201, 28);
            this.cboCriteria.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search values";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Search Criteria";
            // 
            // cbnExamCode
            // 
            this.cbnExamCode.FormattingEnabled = true;
            this.cbnExamCode.Location = new System.Drawing.Point(276, 14);
            this.cbnExamCode.Name = "cbnExamCode";
            this.cbnExamCode.Size = new System.Drawing.Size(178, 28);
            this.cbnExamCode.TabIndex = 1;
            this.cbnExamCode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExamDate.Location = new System.Drawing.Point(276, 251);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(178, 26);
            this.dtpExamDate.TabIndex = 13;
            this.dtpExamDate.ValueChanged += new System.EventHandler(this.dtpExamDate_ValueChanged);
            // 
            // cboExamType
            // 
            this.cboExamType.FormattingEnabled = true;
            this.cboExamType.Items.AddRange(new object[] {
            "select",
            "MAIN",
            "SPECIAL",
            "SUPLIMENTARY",
            "RETAKE"});
            this.cboExamType.Location = new System.Drawing.Point(276, 204);
            this.cboExamType.Name = "cboExamType";
            this.cboExamType.Size = new System.Drawing.Size(178, 28);
            this.cboExamType.TabIndex = 6;
            // 
            // txtExaminerCode
            // 
            this.txtExaminerCode.Location = new System.Drawing.Point(276, 131);
            this.txtExaminerCode.Name = "txtExaminerCode";
            this.txtExaminerCode.Size = new System.Drawing.Size(178, 26);
            this.txtExaminerCode.TabIndex = 4;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(276, 56);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(178, 26);
            this.txtCourseCode.TabIndex = 2;
            // 
            // txtE_ExaminerCode
            // 
            this.txtE_ExaminerCode.Location = new System.Drawing.Point(276, 167);
            this.txtE_ExaminerCode.Name = "txtE_ExaminerCode";
            this.txtE_ExaminerCode.Size = new System.Drawing.Size(178, 26);
            this.txtE_ExaminerCode.TabIndex = 5;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(276, 93);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(178, 26);
            this.txtRegNo.TabIndex = 3;
            // 
            // txtExamCode
            // 
            this.txtExamCode.Location = new System.Drawing.Point(276, 16);
            this.txtExamCode.Name = "txtExamCode";
            this.txtExamCode.Size = new System.Drawing.Size(121, 26);
            this.txtExamCode.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Exam Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Exam Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "External_Examiner Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Examiner Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reg No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Code";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnQuit);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Location = new System.Drawing.Point(98, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(702, 66);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Image = global::EIMS1.Properties.Resources.Webp2;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(373, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(585, 23);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 35);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(483, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(264, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(137, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(29, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gboExam
            // 
            this.gboExam.BackColor = System.Drawing.Color.DarkCyan;
            this.gboExam.Controls.Add(this.groupBox4);
            this.gboExam.Controls.Add(this.groupBox3);
            this.gboExam.Controls.Add(this.groupBox2);
            this.gboExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboExam.Location = new System.Drawing.Point(56, 26);
            this.gboExam.Name = "gboExam";
            this.gboExam.Size = new System.Drawing.Size(852, 436);
            this.gboExam.TabIndex = 0;
            this.gboExam.TabStop = false;
            this.gboExam.Text = "Exam Details";
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 474);
            this.Controls.Add(this.gboExam);
            this.Name = "frmExam";
            this.Text = "Exam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExam_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbosearch.ResumeLayout(false);
            this.gbosearch.PerformLayout();
            this.gboData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.gboExam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboExamType;
        private System.Windows.Forms.TextBox txtExaminerCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtE_ExaminerCode;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtExamCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gboExam;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cbnExamCode;
        private System.Windows.Forms.GroupBox gbosearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn examcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn examtype;
        private System.Windows.Forms.Button btnSearchQuit;
        private System.Windows.Forms.Button tbnAdvanceSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDataQuit;

    }
}