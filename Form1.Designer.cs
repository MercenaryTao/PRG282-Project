namespace TestPrep1
{
    partial class Form1
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
            this.stuName = new System.Windows.Forms.TextBox();
            this.stuSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stuCourse = new System.Windows.Forms.TextBox();
            this.addToList = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // stuName
            // 
            this.stuName.Location = new System.Drawing.Point(165, 44);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(100, 20);
            this.stuName.TabIndex = 0;
            this.stuName.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // stuSurname
            // 
            this.stuSurname.Location = new System.Drawing.Point(165, 78);
            this.stuSurname.Name = "stuSurname";
            this.stuSurname.Size = new System.Drawing.Size(100, 20);
            this.stuSurname.TabIndex = 1;
            this.stuSurname.TextChanged += new System.EventHandler(this.surnameInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course";
            // 
            // stuCourse
            // 
            this.stuCourse.Location = new System.Drawing.Point(362, 46);
            this.stuCourse.Name = "stuCourse";
            this.stuCourse.Size = new System.Drawing.Size(100, 20);
            this.stuCourse.TabIndex = 4;
            // 
            // addToList
            // 
            this.addToList.Location = new System.Drawing.Point(486, 61);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(75, 37);
            this.addToList.TabIndex = 6;
            this.addToList.Text = "Add to List";
            this.addToList.UseVisualStyleBackColor = true;
            this.addToList.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(486, 12);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(75, 36);
            this.saveToFile.TabIndex = 7;
            this.saveToFile.Text = "Save to File";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // readFromFile
            // 
            this.readFromFile.Location = new System.Drawing.Point(486, 112);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(106, 23);
            this.readFromFile.TabIndex = 8;
            this.readFromFile.Text = "View All Students";
            this.readFromFile.UseVisualStyleBackColor = true;
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
            this.dataDisplay.Location = new System.Drawing.Point(92, 141);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.Size = new System.Drawing.Size(542, 284);
            this.dataDisplay.TabIndex = 9;
            this.dataDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDisplay1_CellContentClick);
            this.dataDisplay.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDisplay_CellClick);
            this.dataDisplay.Click += new System.EventHandler(this.Form1_Load);
            // 
            // studentID
            // 
            this.studentID.HeaderText = "StudentID";
            this.studentID.Name = "studentID";
            // 
            // pName
            // 
            this.pName.HeaderText = "Name";
            this.pName.Name = "pName";
            // 
            // pSurname
            // 
            this.pSurname.HeaderText = "Surname";
            this.pSurname.Name = "pSurname";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Age";
            // 
            // stuAge
            // 
            this.stuAge.Location = new System.Drawing.Point(362, 12);
            this.stuAge.Name = "stuAge";
            this.stuAge.Size = new System.Drawing.Size(100, 20);
            this.stuAge.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "StudentID";
            // 
            // stuID
            // 
            this.stuID.Location = new System.Drawing.Point(165, 9);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(100, 20);
            this.stuID.TabIndex = 13;
            // 
            // summaryReport
            // 
            this.summaryReport.Location = new System.Drawing.Point(11, 361);
            this.summaryReport.Name = "summaryReport";
            this.summaryReport.Size = new System.Drawing.Size(75, 37);
            this.summaryReport.TabIndex = 15;
            this.summaryReport.Text = "Report";
            this.summaryReport.UseVisualStyleBackColor = true;
            this.summaryReport.Click += new System.EventHandler(this.summaryReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summaryReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stuAge);
            this.Controls.Add(this.dataDisplay);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.addToList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stuCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stuSurname);
            this.Controls.Add(this.stuName);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button addToList;
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
    }
}

