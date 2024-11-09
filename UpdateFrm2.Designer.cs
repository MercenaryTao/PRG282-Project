namespace TestPrep1
{
    partial class UpdateFrm2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtBxSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(45, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Student by ID";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 191);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(48, 219);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(100, 20);
            this.txtBxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(213, 216);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBxAge);
            this.groupBox2.Controls.Add(this.lblCourse);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.lblSurname);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.txtBxCourse);
            this.groupBox2.Controls.Add(this.txtBxID);
            this.groupBox2.Controls.Add(this.txtBxSurname);
            this.groupBox2.Controls.Add(this.btnUndo);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtBxName);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(422, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 257);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(19, 191);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 11;
            this.lblCourse.Text = "Course";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(19, 108);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // txtBxCourse
            // 
            this.txtBxCourse.Location = new System.Drawing.Point(186, 184);
            this.txtBxCourse.Name = "txtBxCourse";
            this.txtBxCourse.Size = new System.Drawing.Size(100, 20);
            this.txtBxCourse.TabIndex = 7;
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(186, 29);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(100, 20);
            this.txtBxID.TabIndex = 6;
            // 
            // txtBxSurname
            // 
            this.txtBxSurname.Location = new System.Drawing.Point(186, 101);
            this.txtBxSurname.Name = "txtBxSurname";
            this.txtBxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBxSurname.TabIndex = 5;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(249, 216);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Recover";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(135, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(186, 55);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Age";
            // 
            // txtBxAge
            // 
            this.txtBxAge.Location = new System.Drawing.Point(186, 137);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(100, 20);
            this.txtBxAge.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateFrm2";
            this.Text = "UpdateFrm2";
            this.Load += new System.EventHandler(this.UpdateFrm2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}