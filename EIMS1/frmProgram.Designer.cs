namespace EIMS1
{
    partial class frmProgram
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
            this.gboProgram = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn1Reset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btbSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboSearch = new System.Windows.Forms.GroupBox();
            this.gboData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDataQuit = new System.Windows.Forms.Button();
            this.btnSearchQuit = new System.Windows.Forms.Button();
            this.tbnAdvanceSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo2ProgramCode = new System.Windows.Forms.ComboBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.cboDepartmentCode = new System.Windows.Forms.ComboBox();
            this.cboDuration = new System.Windows.Forms.ComboBox();
            this.cboProgramName = new System.Windows.Forms.ComboBox();
            this.cboProgramCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboProgram.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboSearch.SuspendLayout();
            this.gboData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboProgram
            // 
            this.gboProgram.BackColor = System.Drawing.Color.DarkCyan;
            this.gboProgram.Controls.Add(this.groupBox3);
            this.gboProgram.Controls.Add(this.groupBox1);
            this.gboProgram.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboProgram.Location = new System.Drawing.Point(133, 12);
            this.gboProgram.Name = "gboProgram";
            this.gboProgram.Size = new System.Drawing.Size(858, 430);
            this.gboProgram.TabIndex = 0;
            this.gboProgram.TabStop = false;
            this.gboProgram.Text = "Program Details";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btn1Reset);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btbSave);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(84, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Image = global::EIMS1.Properties.Resources.Webp2;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(397, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 36);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn1Reset
            // 
            this.btn1Reset.Location = new System.Drawing.Point(118, 15);
            this.btn1Reset.Name = "btn1Reset";
            this.btn1Reset.Size = new System.Drawing.Size(75, 34);
            this.btn1Reset.TabIndex = 22;
            this.btn1Reset.Text = "Reset";
            this.btn1Reset.UseVisualStyleBackColor = true;
            this.btn1Reset.Click += new System.EventHandler(this.btn1Reset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btbSave
            // 
            this.btbSave.Location = new System.Drawing.Point(16, 12);
            this.btbSave.Name = "btbSave";
            this.btbSave.Size = new System.Drawing.Size(75, 36);
            this.btbSave.TabIndex = 18;
            this.btbSave.Text = "Save";
            this.btbSave.UseVisualStyleBackColor = true;
            this.btbSave.Click += new System.EventHandler(this.btbSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(217, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(510, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gboSearch);
            this.groupBox1.Controls.Add(this.cbo2ProgramCode);
            this.groupBox1.Controls.Add(this.rtxtDescription);
            this.groupBox1.Controls.Add(this.cboDepartmentCode);
            this.groupBox1.Controls.Add(this.cboDuration);
            this.groupBox1.Controls.Add(this.cboProgramName);
            this.groupBox1.Controls.Add(this.cboProgramCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(84, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gboSearch
            // 
            this.gboSearch.Controls.Add(this.gboData);
            this.gboSearch.Controls.Add(this.btnSearchQuit);
            this.gboSearch.Controls.Add(this.tbnAdvanceSearch);
            this.gboSearch.Controls.Add(this.txtSearch);
            this.gboSearch.Controls.Add(this.cboCriteria);
            this.gboSearch.Controls.Add(this.label6);
            this.gboSearch.Controls.Add(this.label7);
            this.gboSearch.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboSearch.Location = new System.Drawing.Point(16, 13);
            this.gboSearch.Name = "gboSearch";
            this.gboSearch.Size = new System.Drawing.Size(659, 262);
            this.gboSearch.TabIndex = 11;
            this.gboSearch.TabStop = false;
            this.gboSearch.Enter += new System.EventHandler(this.gboSearch_Enter);
            // 
            // gboData
            // 
            this.gboData.Controls.Add(this.dataGridView1);
            this.gboData.Controls.Add(this.btnDataQuit);
            this.gboData.Location = new System.Drawing.Point(6, 11);
            this.gboData.Name = "gboData";
            this.gboData.Size = new System.Drawing.Size(653, 245);
            this.gboData.TabIndex = 12;
            this.gboData.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.progcode,
            this.progname,
            this.duration,
            this.deptcode});
            this.dataGridView1.Location = new System.Drawing.Point(-6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 127);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnDataQuit
            // 
            this.btnDataQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnDataQuit.Image = global::EIMS1.Properties.Resources.Webp1;
            this.btnDataQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataQuit.Location = new System.Drawing.Point(296, 201);
            this.btnDataQuit.Name = "btnDataQuit";
            this.btnDataQuit.Size = new System.Drawing.Size(84, 33);
            this.btnDataQuit.TabIndex = 1;
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
            this.btnSearchQuit.Location = new System.Drawing.Point(434, 192);
            this.btnSearchQuit.Name = "btnSearchQuit";
            this.btnSearchQuit.Size = new System.Drawing.Size(86, 34);
            this.btnSearchQuit.TabIndex = 11;
            this.btnSearchQuit.Text = "Quit";
            this.btnSearchQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchQuit.UseVisualStyleBackColor = false;
            this.btnSearchQuit.Click += new System.EventHandler(this.btnSearchQuit_Click);
            // 
            // tbnAdvanceSearch
            // 
            this.tbnAdvanceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbnAdvanceSearch.Image = global::EIMS1.Properties.Resources.Webp_net_resizeimage__3_;
            this.tbnAdvanceSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnAdvanceSearch.Location = new System.Drawing.Point(182, 193);
            this.tbnAdvanceSearch.Name = "tbnAdvanceSearch";
            this.tbnAdvanceSearch.Size = new System.Drawing.Size(97, 33);
            this.tbnAdvanceSearch.TabIndex = 10;
            this.tbnAdvanceSearch.Text = "Search";
            this.tbnAdvanceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnAdvanceSearch.UseVisualStyleBackColor = false;
            this.tbnAdvanceSearch.Click += new System.EventHandler(this.tbnAdvanceSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(319, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 30);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "All";
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
            this.cboCriteria.Location = new System.Drawing.Point(319, 29);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(201, 32);
            this.cboCriteria.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search values";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search Criteria";
            // 
            // cbo2ProgramCode
            // 
            this.cbo2ProgramCode.FormattingEnabled = true;
            this.cbo2ProgramCode.Location = new System.Drawing.Point(250, 24);
            this.cbo2ProgramCode.Name = "cbo2ProgramCode";
            this.cbo2ProgramCode.Size = new System.Drawing.Size(319, 26);
            this.cbo2ProgramCode.TabIndex = 10;
            this.cbo2ProgramCode.SelectedIndexChanged += new System.EventHandler(this.cboProgramCode_SelectedIndexChanged_1);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(250, 216);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(319, 42);
            this.rtxtDescription.TabIndex = 9;
            this.rtxtDescription.Text = "";
            // 
            // cboDepartmentCode
            // 
            this.cboDepartmentCode.FormattingEnabled = true;
            this.cboDepartmentCode.Location = new System.Drawing.Point(250, 166);
            this.cboDepartmentCode.Name = "cboDepartmentCode";
            this.cboDepartmentCode.Size = new System.Drawing.Size(319, 26);
            this.cboDepartmentCode.TabIndex = 8;
            // 
            // cboDuration
            // 
            this.cboDuration.FormattingEnabled = true;
            this.cboDuration.Location = new System.Drawing.Point(250, 125);
            this.cboDuration.Name = "cboDuration";
            this.cboDuration.Size = new System.Drawing.Size(319, 26);
            this.cboDuration.TabIndex = 7;
            this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cboProgramName
            // 
            this.cboProgramName.FormattingEnabled = true;
            this.cboProgramName.Items.AddRange(new object[] {
            "Bachelor of Science in Cooperative and Entrepreneurship Management",
            "Bachelor of Commerce (BCOM)",
            "Bachelor of Business Management (BBM)",
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Computer Science",
            "Bachelor of Science in Agriculture Economics and Resource Management",
            "Bachelor of Science (Mathematics)",
            "Bachelor of Science in Bio-resource Conservation and Management",
            "Bachelor of Science in Agriculture Education and Extension",
            "Bachelor of Science in Renewable Energy and Bio-fuels Technology",
            "Bachelor of Science in Physics",
            "Bachelor of Science in Biology",
            "Bachelor of Science in Chemistry",
            "Bachelor of Science in Agriculture and Biotechnology",
            "Bachelor of Education Early Childhood",
            "Bachelor of Journalism and Mass Communication",
            "Bachelor of Criminology",
            "Bachelor of Social Work",
            "Bachelor of Education (Science)",
            "Bachelor of Education (Arts)"});
            this.cboProgramName.Location = new System.Drawing.Point(250, 74);
            this.cboProgramName.Name = "cboProgramName";
            this.cboProgramName.Size = new System.Drawing.Size(319, 26);
            this.cboProgramName.TabIndex = 6;
            this.cboProgramName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboProgramCode
            // 
            this.cboProgramCode.FormattingEnabled = true;
            this.cboProgramCode.Location = new System.Drawing.Point(250, 24);
            this.cboProgramCode.Name = "cboProgramCode";
            this.cboProgramCode.Size = new System.Drawing.Size(319, 26);
            this.cboProgramCode.TabIndex = 5;
            this.cboProgramCode.SelectedIndexChanged += new System.EventHandler(this.cboProgramCode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department Code";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Code";
            // 
            // progcode
            // 
            this.progcode.HeaderText = "Program Code";
            this.progcode.Name = "progcode";
            // 
            // progname
            // 
            this.progname.HeaderText = "Program Name";
            this.progname.Name = "progname";
            // 
            // duration
            // 
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            // 
            // deptcode
            // 
            this.deptcode.HeaderText = "Department Code";
            this.deptcode.Name = "deptcode";
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 496);
            this.Controls.Add(this.gboProgram);
            this.Name = "frmProgram";
            this.Text = "Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProgram_Load);
            this.gboProgram.ResumeLayout(false);
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

        private System.Windows.Forms.GroupBox gboProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.ComboBox cboDepartmentCode;
        private System.Windows.Forms.ComboBox cboDuration;
        private System.Windows.Forms.ComboBox cboProgramName;
        private System.Windows.Forms.ComboBox cboProgramCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btbSave;
        private System.Windows.Forms.ComboBox cbo2ProgramCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn1Reset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gboSearch;
        private System.Windows.Forms.GroupBox gboData;
        private System.Windows.Forms.Button btnSearchQuit;
        private System.Windows.Forms.Button tbnAdvanceSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDataQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn progcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn progname;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptcode;
    }
}