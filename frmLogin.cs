using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestPrep1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Change the following string to the database directory as per your system:
                string path = @"C:\Users\Kumar\Desktop\RecoverButton\bin\Debug\lecturers.txt";

            string id = txtID.Text.Trim();
            string password = txtPw.Text.Trim();
            bool lecturerFound = false;

            if (File.Exists(path))
            {
                string[]lines = File.ReadAllLines(path);
                foreach (string line in lines) 
                {
                    string[] details = line.Split(';');

                    if (details.Length >= 5 && details[0] == id && details[4] ==password ) 
                    { 
                        lecturerFound = true;
                        break;
                    }
                }

                if (lecturerFound)
                {
                    frmDashboard dashboard = new frmDashboard();
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Lecturer not found. Please check your ID and Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
