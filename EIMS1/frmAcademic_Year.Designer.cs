namespace EIMS1
{
    partial class frmAcademicYear
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
            this.gbdAcademicYear = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.gboData = new System.Windows.Forms.GroupBox();
            this.btnDataQuit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acadcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acadyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchQuit = new System.Windows.Forms.Button();
            this.btnAdvanceSearch = new System.Windows.Forms.Button();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAcademicYearCode = new System.Windows.Forms.ComboBox();
            this.rbtn2Inactive = new System.Windows.Forms.RadioButton();
            this.rbtn1Active = new System.Windows.Forms.RadioButton();
            this.cbnAcademicYear = new System.Windows.Forms.ComboBox();
            this.txtAcademicYearCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbdAcademicYear.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboSearch.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdAcademicYear
            // 
            this.gbdAcademicYear.BackColor = System.Drawing.Color.DarkCyan;
            this.gbdAcademicYear.Controls.Add(this.groupBox3);
            this.gbdAcademicYear.Controls.Add(this.groupBox1);
            this.gbdAcademicYear.Location = new System.Drawing.Point(135, 12);
            this.gbdAcademicYear.Name = "gbdAcademicYear";
            this.gbdAcademicYear.Size = new System.Drawing.Size(678, 372);
            this.gbdAcademicYear.TabIndex = 0;
            this.gbdAcademicYear.TabStop = false;
            this.gbdAcademicYear.Text = "Academic Year Details";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnQuit);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(27, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(333, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(435, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(227, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuit.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(533, 18);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(63, 34);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(121, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(20, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gboSearch);
            this.groupBox1.Controls.Add(this.cboAcademicYearCode);
            this.groupBox1.Controls.Add(this.rbtn2Inactive);
            this.groupBox1.Controls.Add(this.rbtn1Active);
            this.groupBox1.Controls.Add(this.cbnAcademicYear);
            this.groupBox1.Controls.Add(this.txtAcademicYearCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gboSearch
            // 
            this.gboSearch.Controls.Add(this.gboData);
            this.gboSearch.Controls.Add(this.txtSearch);
            this.gboSearch.Controls.Add(this.btnSearchQuit);
            this.gboSearch.Controls.Add(this.btnAdvanceSearch);
            this.gboSearch.Controls.Add(this.cboCriteria);
            this.gboSearch.Controls.Add(this.label5);
            this.gboSearch.Controls.Add(this.label4);
            this.gboSearch.Location = new System.Drawing.Point(6, 13);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(602, 225);
            this.gboSearch.TabIndex = 7;
            this.gboSearch.TabStop = false;
            // 
            // gboData
            // 
            this.gboData.Controls.Add(this.btnDataQuit);
            this.gboData.Controls.Add(this.dataGridView1);
            this.gboData.Location = new System.Drawing.Point(6, 6);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(590, 213);
            this.gboData.TabIndex = 0;
            this.gboData.TabStop = false;
            // 
            // btnDataQuit
            // 
            this.btnDataQuit.BackColor = System.Drawing.Color.DarkRed;
            this.btnDataQuit.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataQuit.Location = new System.Drawing.Point(260, 170);
            this.btnDataQuit.Name = "btnDataQuit";
            this.btnDataQuit.Size = new System.Drawing.Size(75, 37);
            this.btnDataQuit.TabIndex = 1;
            this.btnDataQuit.Text = "Quit";
            this.btnDataQuit.UseVisualStyleBackColor = false;
            this.btnDataQuit.Click += new System.EventHandler(this.btnDataQuit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acadcode,
            this.acadyear,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(6, -6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // acadcode
            // 
            this.acadcode.HeaderText = "Academic Code";
            this.acadcode.Name = "acadcode";
            // 
            // acadyear
            // 
            this.acadyear.HeaderText = "Academic Year";
            this.acadyear.Name = "acadyear";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(294, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 30);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearchQuit
            // 
            this.btnSearchQuit.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearchQuit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuit.Location = new System.Drawing.Point(403, 161);
            this.btnSearchQuit.Name = "btnSearchQuit";
            this.btnSearchQuit.Size = new System.Drawing.Size(86, 35);
            this.btnSearchQuit.TabIndex = 7;
            this.btnSearchQuit.Text = "Quit";
            this.btnSearchQuit.UseVisualStyleBackColor = false;
            this.btnSearchQuit.Click += new System.EventHandler(this.btnSearchQuit_Click);
            // 
            // btnAdvanceSearch
            // 
            this.btnAdvanceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdvanceSearch.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanceSearch.Location = new System.Drawing.Point(96, 161);
            this.btnAdvanceSearch.Name = "btnAdvanceSearch";
            this.btnAdvanceSearch.Size = new System.Drawing.Size(93, 35);
            this.btnAdvanceSearch.TabIndex = 5;
            this.btnAdvanceSearch.Text = "Search";
            this.btnAdvanceSearch.UseVisualStyleBackColor = false;
            this.btnAdvanceSearch.Click += new System.EventHandler(this.btnAdvanceSearch_Click);
            // 
            // cboCriteria
            // 
            this.cboCriteria.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "All",
            "Academic Code",
            "Academic Code",
            "Status"});
            this.cboCriteria.Location = new System.Drawing.Point(294, 20);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(195, 32);
            this.cboCriteria.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search Criteria";
            // 
            // cboAcademicYearCode
            // 
            this.cboAcademicYearCode.FormattingEnabled = true;
            this.cboAcademicYearCode.Location = new System.Drawing.Point(313, 32);
            this.cboAcademicYearCode.Name = "cboAcademicYearCode";
            this.cboAcademicYearCode.Size = new System.Drawing.Size(182, 21);
            this.cboAcademicYearCode.TabIndex = 1;
            this.cboAcademicYearCode.SelectedIndexChanged += new System.EventHandler(this.cboAcademicYearCode_SelectedIndexChanged);
            // 
            // rbtn2Inactive
            // 
            this.rbtn2Inactive.AutoSize = true;
            this.rbtn2Inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2Inactive.Location = new System.Drawing.Point(424, 106);
            this.rbtn2Inactive.Name = "rbtn2Inactive";
            this.rbtn2Inactive.Size = new System.Drawing.Size(71, 17);
            this.rbtn2Inactive.TabIndex = 6;
            this.rbtn2Inactive.TabStop = true;
            this.rbtn2Inactive.Text = "Inactive";
            this.rbtn2Inactive.UseVisualStyleBackColor = true;
            // 
            // rbtn1Active
            // 
            this.rbtn1Active.AutoSize = true;
            this.rbtn1Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn1Active.Location = new System.Drawing.Point(313, 107);
            this.rbtn1Active.Name = "rbtn1Active";
            this.rbtn1Active.Size = new System.Drawing.Size(61, 17);
            this.rbtn1Active.TabIndex = 3;
            this.rbtn1Active.TabStop = true;
            this.rbtn1Active.Text = "Active";
            this.rbtn1Active.UseVisualStyleBackColor = true;
            // 
            // cbnAcademicYear
            // 
            this.cbnAcademicYear.AutoCompleteCustomSource.AddRange(new string[] {
            "2021/2022",
            "2020/2021",
            "2019/2020",
            "2018/2019",
            "2017/2018",
            "2016/2017"});
            this.cbnAcademicYear.FormattingEnabled = true;
            this.cbnAcademicYear.Items.AddRange(new object[] {
            "Select",
            "2021/2022",
            "2020/2021",
            "2019/2020",
            "2018/2019",
            "2017/2018",
            "2016/2017"});
            this.cbnAcademicYear.Location = new System.Drawing.Point(313, 72);
            this.cbnAcademicYear.Name = "cbnAcademicYear";
            this.cbnAcademicYear.Size = new System.Drawing.Size(182, 21);
            this.cbnAcademicYear.TabIndex = 2;
            // 
            // txtAcademicYearCode
            // 
            this.txtAcademicYearCode.Location = new System.Drawing.Point(313, 33);
            this.txtAcademicYearCode.Name = "txtAcademicYearCode";
            this.txtAcademicYearCode.Size = new System.Drawing.Size(182, 20);
            this.txtAcademicYearCode.TabIndex = 1;
            this.txtAcademicYearCode.TextChanged += new System.EventHandler(this.txtAcademicYearCose_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Academic Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic Year Code";
            // 
            // frmAcademicYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 417);
            this.Controls.Add(this.gbdAcademicYear);
            this.Name = "frmAcademicYear";
            this.Text = "Academic Year";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAcademicYear_Load);
            this.gbdAcademicYear.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboSearch.ResumeLayout(false);
            this.gboSearch.PerformLayout();
            this.gboData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdAcademicYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn2Inactive;
        private System.Windows.Forms.RadioButton rbtn1Active;
        private System.Windows.Forms.ComboBox cbnAcademicYear;
        private System.Windows.Forms.TextBox txtAcademicYearCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboAcademicYearCode;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdvanceSearch;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDataQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn acadcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn acadyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchQuit;
    }
}