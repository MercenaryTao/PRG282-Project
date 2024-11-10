namespace TestPrep1
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPw
            // 
            this.txtPw.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtPw.Location = new System.Drawing.Point(58, 380);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(246, 27);
            this.txtPw.TabIndex = 7;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.Transparent;
            this.lblPW.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblPW.Location = new System.Drawing.Point(54, 355);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(170, 22);
            this.lblPW.TabIndex = 6;
            this.lblPW.Text = "Choose Password:";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtFName.Location = new System.Drawing.Point(180, 238);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(124, 27);
            this.txtFName.TabIndex = 9;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblFName.Location = new System.Drawing.Point(54, 238);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(120, 22);
            this.lblFName.TabIndex = 8;
            this.lblFName.Text = "First Name:";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtLName.Location = new System.Drawing.Point(170, 271);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(134, 27);
            this.txtLName.TabIndex = 11;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Transparent;
            this.lblLName.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblLName.Location = new System.Drawing.Point(54, 271);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(110, 22);
            this.lblLName.TabIndex = 10;
            this.lblLName.Text = "Last Name:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.txtAge.Location = new System.Drawing.Point(110, 304);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(194, 27);
            this.txtAge.TabIndex = 13;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.lblAge.Location = new System.Drawing.Point(54, 304);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 22);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.btnRegister.Location = new System.Drawing.Point(58, 427);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(246, 38);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.btnLogin.Location = new System.Drawing.Point(206, 510);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 27);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Log-In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.label3.Location = new System.Drawing.Point(40, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Already registered?";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.lblPW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register |Student Management System";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
    }
}