using System;
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
using System.Drawing.Imaging;
using System.Data.SqlClient;
using TestPrep1.DataLayer;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TestPrep1
{
    public partial class Form1 : Form
    {
        Student student1;
        FileHandler fileHandler;
        FileHandler fileHandler2;

        List<Student> students = new List<Student>();
        
        
       
        public Form1()
        {
            InitializeComponent();
            dataDisplay.AutoGenerateColumns = false;
            fileHandler = new FileHandler(@"C:\Users\Administrator\Desktop\Project PRG282 Repo\students.txt");
            fileHandler2 = new FileHandler(@"C:\Users\Administrator\Desktop\Project PRG282 Repo\dataFile.txt");

        }

        private void Form1_Load(object sender, EventArgs e)
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

                using (StreamWriter sr = new StreamWriter(fileHandler2.StudentFile))
                {
                   

                    foreach (var item in students)
                    {
                        sr.WriteLine(item.SummaryReport());
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {

        }


        private void saveToFile_Click(object sender, EventArgs e)///saves to the file
        {

            //fileHandler.SaveStudentDetails(sID, name, surname, age, course);

            try
            {
                string sID = stuID.Text;
                string name = stuName.Text;
                string surname = stuSurname.Text;
                string age = stuAge.Text;
                string course = stuCourse.Text;


                Student student = new Student(sID, name, surname, age, course);

                foreach (string line in File.ReadLines(fileHandler.StudentFile))
                {

                    string[] data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty or whitespace-only lines

                    // Trim each element to remove extra whitespace
                    string stuID = data[0].Trim();
                    string sName = data[1].Trim();
                    string SSurname = data[2].Trim();
                    string sAge = data[3].Trim();
                    string sCourse = data[4].Trim();

                    if (stuID == sID)
                    {
                        MessageBox.Show($"Student with student ID: {sID} already exists.");
                        //dataDisplay.Rows.Add(student.StudentID, student.Name, student.Surname, student.Age, student.Course);
                        return;
                    }           
                    
                }
          
                students.Add(student);
                using (StreamWriter sr = new StreamWriter(fileHandler.StudentFile))
                {
                    foreach (var item in students)
                    {

                        sr.WriteLine(item);

                    }
                }

               
                dataDisplay.Rows.Add(student.StudentID, student.Name, student.Surname, student.Age, student.Course);
               
                MessageBox.Show("Student Added!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void readFromFile_Click(object sender, EventArgs e)
        {
 
            dataDisplay.Rows.Clear();

            try
            {
                // Read each line from the file
                foreach (string line in File.ReadLines(fileHandler.StudentFile))
                {

                    string[] data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty or whitespace-only lines

                    // Trim each element to remove extra whitespace
                    string sID = data[0].Trim();
                    string name = data[1].Trim();
                    string surname = data[2].Trim();
                    string age = data[3].Trim();
                    string course = data[4].Trim();

                    Student student = new Student(sID, name, surname, age, course);
                    students.Clear();
                    students.Add(student);

                    foreach (var item in students)
                    {
                       
                        dataDisplay.Rows.Add(item.StudentID, item.Name, item.Surname, item.Age, item.Course);
                      
                    }
                   
                }
                
            }
            catch (Exception ex)
            {
       
                MessageBox.Show(ex.Message);
            }

        }


        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void dataDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < students.Count)
            {
                DataGridViewRow row = dataDisplay.Rows[rowIndex];

                students[rowIndex].StudentID = row.Cells[0].Value.ToString();
                students[rowIndex].Name = row.Cells[1].Value.ToString();
                students[rowIndex].Surname = row.Cells[2].Value.ToString();
                students[rowIndex].Age = row.Cells[3].Value.ToString();
                students[rowIndex].Course = row.Cells[4].Value.ToString();

                stuID.Text = students[rowIndex].StudentID.ToString();
                stuName.Text = students[rowIndex].Name.ToString();
                stuSurname.Text = students[rowIndex].Surname.ToString();
                stuAge.Text = students[rowIndex].Age.ToString();
                stuCourse.Text = students[rowIndex].Course.ToString();

            }
        }


        private void summaryReport_Click(object sender, EventArgs e)
        {
            students.Clear();
            int count = 0;
            int avg = 0;
            int ageSum = 0;

            try
            {
                // Read each line from the file
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

                    count++;
                    ageSum = int.Parse(age);
                    using (StreamWriter sr = new StreamWriter(fileHandler2.StudentFile))
                    {
                        avg = ageSum / count;
                        sr.WriteLine($"Average Age: {age}");
                        if (count > 1)
                        {
                            sr.WriteLine($"{count} Records Exist");
                        }
                        else
                        {
                            sr.WriteLine($"Only 1 record exists");
                        }

                        foreach (var item in students)
                        {
                            sr.WriteLine(item.SummaryReport());
                        }
                    }
                }


                MessageBox.Show("operation Successful, summary report has been created.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          UpdateFrm2 updateForm= new UpdateFrm2();
            //Form1 frm1=  new Form1();
            this.Hide();
            updateForm.Show();       
         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                if (dataDisplay.SelectedRows.Count > 0) {
                var selectedRow= dataDisplay.SelectedRows[0];   
                    string studentID= selectedRow.Cells["ID"].Value.ToString();

                    var lines =File.ReadAllLines(studentID);                  
                
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }
    }
}
