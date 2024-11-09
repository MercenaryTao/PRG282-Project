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
using TestPrep1.PresentationLayer;


namespace TestPrep1
{    
    public partial class UpdateFrm : Form1
    {
      
        List<Student> student = new List<Student>();
        string filepath = @"C:\Users\Kumar\Desktop\Project PRG282 Repo\bin\dataFile.txt";
        public UpdateFrm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txtBxSearch.Text;
               

                var lines = File.ReadAllLines("students.txt");
                foreach (var line in lines) {
                    var data = line.Split(',');
                    if (data[0]==studentID) {
                        Student newStudent = new Student(data[0], data[1], data[2], data[3], data[4]);
                        student.Add(newStudent);
                        //student.Add(new Student {

                        //    StudentID = data[0],
                        //    Name = data[1],
                        //    Surname = data[2],
                        //    Age = data[3],
                        //    Course = data[4]    
                            
                            
                            
                        //    });
                        break;
                    }
                
                }
                if (student.Count>0) {
                
                dataGridView1.DataSource = student; 
                   
                
                }

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txtBxStudentID.Text;
                bool studentFound=false;
                var lines = File.ReadAllLines("students.txt");
                var updatedLines= new List<string>();   
                foreach (var line in lines) {
                    var data = line.Split(',');
                    if (data[0]==studentID) {

                        data[1]= txtBxName.Text;
                        data[2]= txtBxSurname.Text;
                        data[3]= txtBxCourse.Text;  
                        studentFound = true;
                        MessageBox.Show("Students updated successfully");
                         
                        
                            
                            
                            }
                    updatedLines.Add(string.Join(",", data));  
                
                }

                if (studentFound) {
                    File.WriteAllLines("students.txt",updatedLines);
                    btnSearch_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


           




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_SelectionChanged() {

            if (dataGridView1.SelectedRows.Count>0) {
            var selectedRow= dataGridView1.SelectedRows[0];
                txtBxStudentID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtBxName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtBxSurname.Text = selectedRow.Cells["Surname"].Value.ToString();
                txtBxCourse.Text = selectedRow.Cells["Course"].Value.ToString();
            
            
            }
        
        
        }
    }
}
