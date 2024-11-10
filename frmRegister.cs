﻿using System;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFName.Text.Trim();
            string lastName = txtLName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string password = txtPw.Text.Trim();

            // Validating input fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(ageText) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Please enter a valid age (numbers only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate unique 4-digit ID
            string uniqueID = GenerateUniqueID();


            string path = @"C:\Users\Kumar\Desktop\RecoverButton\bin\Debug\lecturers.txt";

            // Write data to file
            string newLecturerRecord = $"{uniqueID};{firstName};{lastName};{age};{password}";
            File.AppendAllText(path, newLecturerRecord + Environment.NewLine);

            // Notify user of their unique ID
            MessageBox.Show($"Registration successful! Your unique ID is: {uniqueID}", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            txtFName.Clear();
            txtLName.Clear();
            txtAge.Clear();
            txtPw.Clear();
        }

        //for generating IDs 
        private string GenerateUniqueID()
        {
            Random random = new Random();
            string path = @"C:\Users\Kumar\Desktop\RecoverButton\bin\Debug\lecturers.txt";
            string uniqueID;

            do
            {
                uniqueID = random.Next(1000, 9999).ToString();
            } while (File.ReadAllLines(path).Any(line => line.StartsWith(uniqueID + ";")));

            return uniqueID;
        }
    }
}
