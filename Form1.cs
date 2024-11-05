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
            fileHandler = new FileHandler(@"C:\Users\Administrator\source\repos\IsITWorking\students.txt");
            fileHandler2 = new FileHandler(@"C:\Users\Administrator\source\repos\IsITWorking\dataFile.txt");

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

        private void button1_Click(object sender, EventArgs e)///adds to the list
        {
           
          
        }

        private void saveToFile_Click(object sender, EventArgs e)///saves to the file
        {
            try
            {

                string sID = stuID.Text;
                string name = stuName.Text;
                string surname = stuSurname.Text;
                string age = stuAge.Text;
                string course = stuCourse.Text;


                Student student = new Student(sID, name, surname, age, course);

                students.Add(student);
                dataDisplay.Rows.Add(student.StudentID, student.Name, student.Surname, student.Age, student.Course);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            using (StreamWriter sr = new StreamWriter(fileHandler.StudentFile))
            {
                foreach (var item in students)
                {                   
                    
                    sr.WriteLine(item);
                }
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
 
            //dataGridView.
        }

        private void dataDisplay1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int tableIndex = e.RowIndex;

                DataGridViewRow dataGridView = new DataGridViewRow();
                var selectedRow = dataGridView.Selected;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void summaryReport_Click(object sender, EventArgs e)
        {
            students.Clear();
            int count = 0;
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

                    using (StreamWriter sr = new StreamWriter(fileHandler2.StudentFile))
                    {
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
    }
}
