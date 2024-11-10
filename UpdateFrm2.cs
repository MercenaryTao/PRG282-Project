﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPrep1.PresentationLayer;
using System.IO;
using TestPrep1.DataLayer;
using static System.Windows.Forms.AxHost;


namespace TestPrep1
{   
    public partial class UpdateFrm2 : Form
    {
        FileHandler fileHandler;
        FileHandler fileHandler2;
        List<Student> students = new List<Student>();
    
        private List<string> backupData = new List<string>();
        public UpdateFrm2()
        {
            InitializeComponent();
            fileHandler = new FileHandler(@"C:\Users\Kumar\Desktop\Project Updated 2\bin\Debug\students.txt");
            fileHandler2 = new FileHandler(@"C:\Users\Kumar\Desktop\Project Updated 2\bin\Debug\dataFile.txt");

        }
        private void UpdateFrm2_Load(object sender, EventArgs e)
        {
            foreach (string line in File.ReadAllLines(fileHandler.StudentFile))
            {
                string[] data = line.Split(' ');


                if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty or whitespace-only lines

                // Trim each element to remove extra whitespace
                string sID = data[0].Trim();
                string name = data[1].Trim();
                string surname = data[2].Trim();
                string age = data[3].Trim();
                string course = data[4].Trim();

                Student student = new Student(sID, name, surname, age, course);
                //students.Clear();
                students.Add(student);
                dataGridView1.Rows.Add(student.StudentID, student.Name, student.Surname, student.Age, student.Course);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string studentID = txtBxSearch.Text;
            
                bool isSutdentFound = false;
                int studCount = 0;
             

                foreach (string line in File.ReadAllLines(fileHandler.StudentFile))
                {                   
                    string[] data = line.Split(' ');
                 
                        string sID = data[0].Trim();
                        string name = data[1].Trim();
                        string surname = data[2].Trim();
                        string age = data[3].Trim();
                        string course = data[4].Trim();
                    
                    Student student = new Student(sID, name, surname, age, course);
                  
                    if (sID == studentID)
                        {
                        students.Add(student);
                        dataGridView1.Rows.Add(student.StudentID, student.Name, student.Surname, student.Age, student.Course);
                            isSutdentFound = true;
                            MessageBox.Show("Student Record Found!");
                    }                   
                 }
                if (!isSutdentFound)
                {
                    MessageBox.Show("No record found");
                }
           
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           
                throw;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //string studentID = txtBxID.Text;
            //    bool studentFound = false;

            //    var updatedLines = new List<string>();
            //    foreach (string line in File.ReadAllLines(fileHandler.StudentFile))
            //    {
            //        string[] data = line.Split(' ');
            //        string stID = data[0].Trim();
            //        string stName = data[1].Trim();
            //        string stSurname = data[2].Trim();
            //        string stAge = data[3].Trim();
            //        string stCourse = data[4].Trim();


            //            stID = txtBxName.Text;
            //            stName = txtBxSurname.Text;
            //            stSurname  = txtBxCourse.Text;
            //            studentFound = true;
            //            MessageBox.Show("Students updated successfully");

            //        updatedLines.Add(string.Join(",", data));

            //    }

            //    if (studentFound)
            //    {
            //        File.WriteAllLines("students.txt", updatedLines);
            //        btnSearch_Click(sender, e);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Update unsuccessful");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //} 
            if (dataGridView1.SelectedCells.Count>0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                
                string updatedID=txtBxID.Text;
                string updatedName = txtBxName.Text;
                string updatedSurname=txtBxSurname.Text; 
                string updatedAge=txtBxAge.Text;
                string updatedCourse=txtBxCourse.Text;

                dataGridView1.Rows[selectedRowIndex].Cells[0].Value = updatedID;
                dataGridView1.Rows[selectedRowIndex].Cells[1].Value = updatedName;
                dataGridView1.Rows[selectedRowIndex].Cells[2].Value = updatedSurname;
                dataGridView1.Rows[selectedRowIndex].Cells[3].Value = updatedAge;
                dataGridView1.Rows[selectedRowIndex].Cells[4].Value = updatedCourse;

                string[] allLines = File.ReadAllLines("students.txt");
                allLines[selectedRowIndex] = $"{updatedID} {updatedName} {updatedSurname} {updatedAge} {updatedCourse}";
                File.WriteAllLines("students.txt",allLines);

                MessageBox.Show("Student details updated successfully");
            }
            else
            {
                MessageBox.Show("Please enter details to update");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count>0)
            //{
            //    //    string selectedID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


            //    //    backupData=File.ReadAllLines("student.txt").ToList();
            //    //    var newData = backupData.Where(DataGridLineStyle=>!DataGridLineStyle.StartsWith(selectedID+",")).ToList();

            //    //    File.WriteAllLines("students.txt",newData);

            //    //    LoadStudents();
            //    //    MessageBox.Show("Student deleted successfully");
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("Please select a student to delete"); 
            //}  
            if (dataGridView1.SelectedCells.Count>0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                dataGridView1.Rows.RemoveAt(selectedRowIndex);

                List<string> allLines = File.ReadAllLines("students.txt").ToList();
                allLines.RemoveAt(selectedRowIndex);
                File.WriteAllLines("students.txt",allLines);

                MessageBox.Show("Student removed successfully");
            }
            else
            {
                MessageBox.Show("Please select a student to remove");
            }

            /////PART I NEED HELP WITH
            //if (dataGridView1.SelectedCells.Count>0)
            //{ 
            //    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex; 

            //    string sID = dataGridView1.Rows[selectedRowIndex].Cells["StudentID"].Value.ToString();
            //    string name= dataGridView1.Rows[selectedRowIndex].Cells["Name"].Value.ToString(); <=========THIS PART HERE
            //    string surname = dataGridView1.Rows[selectedRowIndex].Cells["Surname"].Value.ToString();
            //    string age = dataGridView1.Rows[selectedRowIndex].Cells["Age"].Value.ToString();
            //    string course = dataGridView1.Rows[selectedRowIndex].Cells["Course"].Value.ToString();

            //    using (StreamWriter sw=new StreamWriter("deletedStudents.txt",true))
            //    {
            //        sw.WriteLine($"{sID} {name} {surname} {age} {course}");
            //    }
            //    List<string> allLines=File.ReadAllLines("students.txt").ToList();
            //    allLines.RemoveAt(selectedRowIndex);
            //    File.WriteAllLines("student.txt",allLines.ToArray());
            //    dataGridView1.Rows.RemoveAt(selectedRowIndex);
            //    MessageBox.Show("Added to recovery file");

            //}


        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //if (backupData.Count > 0)
            //{
            //    File.WriteAllLines("students.txt", backupData);

            //    LoadStudents();
            //    MessageBox.Show("Recover successful. Deleted record restored");

            //}
            //else {
            //    MessageBox.Show("Nothing to recover");

            //}  

            string searchID=txtBxSearch.Text;
            bool studentFound = false;

            List<string>deletedLines=File.ReadAllLines("deletedStudents.txt").ToList();
            foreach  ( string line in deletedLines)
            {
                string[] data=line.Split(' ');
                if (data[0].Trim()==searchID)
                {
                    using (StreamWriter sw=File.AppendText("students.txt"))
                    {
                        sw.WriteLine(line);
                    } 
                    deletedLines.Remove(line);
                    deletedLines.Remove(line);
                    File.WriteAllLines("deletedStudents.txt", deletedLines);
                    MessageBox.Show($"Student with Id:{searchID} has been recovered");
                    studentFound = true;
                    break;
                }
                }
            if (!studentFound)
            {
                MessageBox.Show("Student ID not found in recovery");
            }

            LoadStudents();

        }

        private void LoadStudents() { 
        
        dataGridView1.Rows.Clear();

            var lines = File.ReadAllLines("students.txt");
            foreach ( var line in lines ) {
                var data = line.Split(',');
                dataGridView1.Rows.Add(data[0], data[1], data[2], data[3]);    
            
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < students.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                students[rowIndex].StudentID = row.Cells[0].Value?.ToString() ?? " ";
                students[rowIndex].Name = row.Cells[1].Value?.ToString() ?? " ";
                students[rowIndex].Surname = row.Cells[2].Value?.ToString() ?? " ";
                students[rowIndex].Age = row.Cells[3].Value?.ToString() ?? " ";
                students[rowIndex].Course = row.Cells[4].Value?.ToString() ?? " ";

                txtBxID.Text = students[rowIndex].StudentID.ToString();
                txtBxName.Text = students[rowIndex].Name.ToString();
                txtBxSurname.Text = students[rowIndex].Surname.ToString();
                txtBxAge.Text = students[rowIndex].Age.ToString();
                txtBxCourse.Text = students[rowIndex].Course.ToString();
             

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            //Form1 frm1=  new Form1();
            this.Hide();
            mainForm.Show();
        }
    }
}
