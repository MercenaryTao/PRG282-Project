﻿namespace TestPrep1
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBxCourse = new System.Windows.Forms.TextBox();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.txtBxSurname = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.pName,
            this.pSurname,
            this.age,
            this.course});
            this.dataGridView1.Location = new System.Drawing.Point(26, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(356, 181);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // txtBxSearch
            // 
            this.txtBxSearch.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.txtBxSearch.Location = new System.Drawing.Point(26, 181);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(257, 21);
            this.txtBxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.btnSearch.Location = new System.Drawing.Point(288, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label1.Location = new System.Drawing.Point(471, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Age";
            // 
            // txtBxAge
            // 
            this.txtBxAge.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtBxAge.Location = new System.Drawing.Point(507, 273);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(224, 23);
            this.txtBxAge.TabIndex = 12;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblCourse.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblCourse.Location = new System.Drawing.Point(471, 304);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(56, 18);
            this.lblCourse.TabIndex = 11;
            this.lblCourse.Text = "Course";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblID.Location = new System.Drawing.Point(471, 191);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 18);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblSurname.Location = new System.Drawing.Point(471, 247);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 18);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblName.Location = new System.Drawing.Point(471, 219);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 18);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // txtBxCourse
            // 
            this.txtBxCourse.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtBxCourse.Location = new System.Drawing.Point(530, 301);
            this.txtBxCourse.Name = "txtBxCourse";
            this.txtBxCourse.Size = new System.Drawing.Size(202, 23);
            this.txtBxCourse.TabIndex = 7;
            // 
            // txtBxID
            // 
            this.txtBxID.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtBxID.Location = new System.Drawing.Point(500, 188);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(232, 23);
            this.txtBxID.TabIndex = 6;
            // 
            // txtBxSurname
            // 
            this.txtBxSurname.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtBxSurname.Location = new System.Drawing.Point(537, 245);
            this.txtBxSurname.Name = "txtBxSurname";
            this.txtBxSurname.Size = new System.Drawing.Size(194, 23);
            this.txtBxSurname.TabIndex = 5;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUndo.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.btnUndo.Location = new System.Drawing.Point(654, 341);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(98, 63);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Recover";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.btnDelete.Location = new System.Drawing.Point(550, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 63);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBxName.Location = new System.Drawing.Point(514, 217);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(217, 23);
            this.txtBxName.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(447, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 63);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.btnBack.Location = new System.Drawing.Point(716, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.button1.Location = new System.Drawing.Point(26, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtBxCourse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtBxSurname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.txtBxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update |Student Management System";
            this.Load += new System.EventHandler(this.UpdateFrm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBxCourse;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.TextBox txtBxSurname;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}