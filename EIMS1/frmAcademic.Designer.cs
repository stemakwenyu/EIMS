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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.SuspendLayout();
            // 
            // gbdAcademicYear
            // 
            this.gbdAcademicYear.BackColor = System.Drawing.Color.DarkCyan;
            this.gbdAcademicYear.Controls.Add(this.groupBox3);
            this.gbdAcademicYear.Controls.Add(this.groupBox1);
            this.gbdAcademicYear.Location = new System.Drawing.Point(140, 31);
            this.gbdAcademicYear.Name = "gbdAcademicYear";
            this.gbdAcademicYear.Size = new System.Drawing.Size(624, 282);
            this.gbdAcademicYear.TabIndex = 0;
            this.gbdAcademicYear.TabStop = false;
            this.gbdAcademicYear.Text = "Academic Year Details";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnQuit);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(27, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(433, 20);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(227, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(53, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbtn2Inactive);
            this.groupBox1.Controls.Add(this.rbtn1Active);
            this.groupBox1.Controls.Add(this.cbnAcademicYear);
            this.groupBox1.Controls.Add(this.txtAcademicYearCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtn2Inactive
            // 
            this.rbtn2Inactive.AutoSize = true;
            this.rbtn2Inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2Inactive.Location = new System.Drawing.Point(393, 107);
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
            this.rbtn1Active.TabIndex = 5;
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
            this.cbnAcademicYear.Size = new System.Drawing.Size(121, 21);
            this.cbnAcademicYear.TabIndex = 4;
            // 
            // txtAcademicYearCode
            // 
            this.txtAcademicYearCode.Location = new System.Drawing.Point(313, 33);
            this.txtAcademicYearCode.Name = "txtAcademicYearCode";
            this.txtAcademicYearCode.Size = new System.Drawing.Size(121, 20);
            this.txtAcademicYearCode.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(941, 353);
            this.Controls.Add(this.gbdAcademicYear);
            this.Name = "frmAcademicYear";
            this.Text = "Academic Year";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAcademicYear_Load);
            this.gbdAcademicYear.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}