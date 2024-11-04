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
namespace TestPrep1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        string filePath = @"C:\Users\Administrator\source\repos\PRG282 Project\dataFile.txt";
        string rawDatafilePath = @"C:\Users\Administrator\source\repos\PRG282 Project\students.txt";
        string dataLink = @"Data Source=MARS\SQLEXPRESS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
            dataDisplay.AutoGenerateColumns = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataHandler handler = new DataHandler();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void surnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)///adds to the list
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

        }

        private void saveToFile_Click(object sender, EventArgs e)///saves to the file
        {
            
            using (StreamWriter sr = new StreamWriter(rawDatafilePath))
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

            students.Clear();

            try
            {
                // Read each line from the file
                foreach (string line in File.ReadLines(rawDatafilePath))
                {

                    string[] data = line.Split(' ');



                    if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty or whitespace-only lines

                    if (data.Length < 7)
                    {                        

                        // Trim each element to remove extra whitespace
                        string sID = data[0].Trim();
                        string name = data[1].Trim();
                        string surname = data[2].Trim();
                        string age = data[3].Trim();
                        string course = data[4].Trim();

                        Student student = new Student(sID, name, surname, age, course);

                        students.Add(student);

                        dataDisplay.Rows.Add(name, student.Surname, student.Age, student.Course);
                    }
                    else { MessageBox.Show(@"Catastrophic Failure",
$"Processing line: {line}"); }
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
    }
}
