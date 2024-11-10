namespace TestPrep1
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.stuName = new System.Windows.Forms.TextBox();
            this.stuSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stuCourse = new System.Windows.Forms.TextBox();
            this.saveToFile = new System.Windows.Forms.Button();
            this.readFromFile = new System.Windows.Forms.Button();
            this.dataDisplay = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.stuAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stuID = new System.Windows.Forms.TextBox();
            this.summaryReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // stuName
            // 
            this.stuName.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.stuName.Location = new System.Drawing.Point(86, 113);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(158, 23);
            this.stuName.TabIndex = 0;
            this.stuName.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // stuSurname
            // 
            this.stuSurname.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.stuSurname.Location = new System.Drawing.Point(109, 141);
            this.stuSurname.Name = "stuSurname";
            this.stuSurname.Size = new System.Drawing.Size(135, 23);
            this.stuSurname.TabIndex = 1;
            this.stuSurname.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label2.Location = new System.Drawing.Point(41, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label3.Location = new System.Drawing.Point(41, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course";
            // 
            // stuCourse
            // 
            this.stuCourse.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.stuCourse.Location = new System.Drawing.Point(100, 198);
            this.stuCourse.Name = "stuCourse";
            this.stuCourse.Size = new System.Drawing.Size(144, 23);
            this.stuCourse.TabIndex = 4;
            // 
            // saveToFile
            // 
            this.saveToFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveToFile.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.saveToFile.Location = new System.Drawing.Point(32, 237);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(211, 37);
            this.saveToFile.TabIndex = 7;
            this.saveToFile.Text = "Save";
            this.saveToFile.UseVisualStyleBackColor = false;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // readFromFile
            // 
            this.readFromFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.readFromFile.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.readFromFile.Location = new System.Drawing.Point(670, 144);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(107, 23);
            this.readFromFile.TabIndex = 8;
            this.readFromFile.Text = "View All Students";
            this.readFromFile.UseVisualStyleBackColor = false;
            this.readFromFile.Click += new System.EventHandler(this.readFromFile_Click);
            // 
            // dataDisplay
            // 
            this.dataDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.pName,
            this.pSurname,
            this.age,
            this.course});
            this.dataDisplay.Location = new System.Drawing.Point(277, 178);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.RowHeadersWidth = 51;
            this.dataDisplay.Size = new System.Drawing.Size(500, 247);
            this.dataDisplay.TabIndex = 9;
            this.dataDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDisplay_CellClick);
            this.dataDisplay.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDisplay_CellClick);
            this.dataDisplay.Click += new System.EventHandler(this.Form1_Load);
            // 
            // studentID
            // 
            this.studentID.HeaderText = "StudentID";
            this.studentID.MinimumWidth = 6;
            this.studentID.Name = "studentID";
            this.studentID.Width = 125;
            // 
            // pName
            // 
            this.pName.HeaderText = "Name";
            this.pName.MinimumWidth = 6;
            this.pName.Name = "pName";
            this.pName.Width = 125;
            // 
            // pSurname
            // 
            this.pSurname.HeaderText = "Surname";
            this.pSurname.MinimumWidth = 6;
            this.pSurname.Name = "pSurname";
            this.pSurname.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.MinimumWidth = 6;
            this.course.Name = "course";
            this.course.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label4.Location = new System.Drawing.Point(41, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Age";
            // 
            // stuAge
            // 
            this.stuAge.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.stuAge.Location = new System.Drawing.Point(78, 170);
            this.stuAge.Name = "stuAge";
            this.stuAge.Size = new System.Drawing.Size(166, 23);
            this.stuAge.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label5.Location = new System.Drawing.Point(41, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "StudentID";
            // 
            // stuID
            // 
            this.stuID.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.stuID.Location = new System.Drawing.Point(122, 84);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(122, 23);
            this.stuID.TabIndex = 13;
            // 
            // summaryReport
            // 
            this.summaryReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.summaryReport.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.summaryReport.Location = new System.Drawing.Point(490, 144);
            this.summaryReport.Name = "summaryReport";
            this.summaryReport.Size = new System.Drawing.Size(83, 23);
            this.summaryReport.TabIndex = 15;
            this.summaryReport.Text = "Report";
            this.summaryReport.UseVisualStyleBackColor = false;
            this.summaryReport.Click += new System.EventHandler(this.summaryReport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.btnUpdate.Location = new System.Drawing.Point(580, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Edit Students";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignOut.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.btnSignOut.Location = new System.Drawing.Point(98, 362);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(145, 32);
            this.btnSignOut.TabIndex = 18;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.summaryReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stuAge);
            this.Controls.Add(this.dataDisplay);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stuCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stuSurname);
            this.Controls.Add(this.stuName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard |Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stuName;
        private System.Windows.Forms.TextBox stuSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stuCourse;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.DataGridView dataDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stuAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.Button summaryReport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSignOut;
    }
}

