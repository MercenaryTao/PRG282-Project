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
using TestPrep1.DataLayer;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;


namespace TestPrep1
{   
    public partial class frmUpdate : Form
    {
        FileHandler fileHandler;
        FileHandler fileHandler2;
        List<Student> students = new List<Student>();
        List<string> deletedStudent = new List<string>();
        private List<string> backupData = new List<string>();
        public frmUpdate()
        {
            InitializeComponent();

            //Change the following two string parameters to the file directory as per your system:
                fileHandler = new FileHandler(@"C:\Users\Kumar\Desktop\RecoverButton\bin\Debug\students.txt");
                fileHandler2 = new FileHandler(@"C:\Users\Kumar\Desktop\RecoverButton\bin\Debug\dataFile.txt");

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
            string searchedID = txtBxSearch.Text;
            string id = txtBxID.Text;
            string newName = txtBxName.Text;
            string newSurname = txtBxSurname.Text;
            string newAge = txtBxAge.Text;
            string newCourse = txtBxCourse.Text;
            try
            {
                //string studentID = txtBxID.Text;
                bool studentFound = false;
                students.Clear();
                var updatedLines = new List<string>();
                foreach (string line in File.ReadAllLines(fileHandler.StudentFile))
                {
                    string[] data = line.Split(' ');
                    string stID = data[0].Trim();
                    string stName = data[1].Trim();
                    string stSurname = data[2].Trim();
                    string stAge = data[3].Trim();
                    string stCourse = data[4].Trim();


                    if (string.IsNullOrEmpty(stName) || string.IsNullOrEmpty(stSurname) ||
      string.IsNullOrEmpty(stAge) || string.IsNullOrEmpty(stCourse))
                    {
                        MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!int.TryParse(stAge, out int oldAge))
                    {
                        MessageBox.Show("Please enter a valid age (numbers only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    Student student = new Student(stID, stName, stSurname, stAge, stCourse);
                    students.Add(student);
                }
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].StudentID == id)
                    {
                        students[i].StudentID = id;
                        students[i].Name = newName;
                        students[i].Surname = newSurname;
                        students[i].Age = newAge;
                        students[i].Course = newCourse;
                        studentFound = true;
                        break;
                    }
                }

                if (studentFound)
                {
                    using (StreamWriter sr = new StreamWriter(fileHandler.StudentFile))
                    {
                        foreach (var student in students)
                        {
                            sr.WriteLine(student.ToString());

                        }
                    }

                    dataGridView1.Rows.Clear();
                    foreach (var student in students)
                    {
                        dataGridView1.Rows.Add(student.StudentID, student.Name, student.Surname, student.Age, student.Course);
                    }
                    MessageBox.Show("Students updated successfully");
                }
                else
                {
                    MessageBox.Show("Student record not found.  Failed To Update");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchedID = txtBxSearch.Text;
            string newName = txtBxName.Text;
            string newSurname = txtBxSurname.Text;
            string newAge = txtBxAge.Text;
            string newCourse = txtBxCourse.Text;

            try
            {
                //string studentID = txtBxID.Text;
                bool studentFound = false;
                students.Clear();
                var updatedLines = new List<string>();
                foreach (string line in File.ReadAllLines(fileHandler.StudentFile))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] data = line.Split(' ');
                    string stID = data[0].Trim();
                    string stName = data[1].Trim();
                    string stSurname = data[2].Trim();
                    string stAge = data[3].Trim();
                    string stCourse = data[4].Trim();

                    Student student = new Student(stID, stName, stSurname, stAge, stCourse);
                    students.Add(student);
                }
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].StudentID == searchedID)
                    {
                        students.RemoveAt(i);
                        studentFound = true;
                        break;
                    }
                }

                if (studentFound)
                {
                    using (StreamWriter sr = new StreamWriter(fileHandler.StudentFile))
                    {
                        foreach (var student in students)
                        {
                            sr.WriteLine(student.ToString());

                        }
                    }

                    dataGridView1.Rows.Clear();
                    foreach (var student in students)
                    {
                        dataGridView1.Rows.Add(student.StudentID, student.Name, student.Surname, student.Age, student.Course);
                    }
                    MessageBox.Show("Students Deleted successfully");

                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                        string sID = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                        string name = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                        string surname = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                        string age = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
                        string course = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();

                        using (StreamWriter sw = new StreamWriter("deletedStudents.txt", true))
                        {
                            sw.WriteLine($"{sID} {name} {surname} {age} {course}");
                        }
                        List<string> allLines = File.ReadAllLines("students.txt").ToList();
                        allLines.RemoveAt(selectedRowIndex);
                        File.WriteAllLines("student.txt", allLines.ToArray());
                        dataGridView1.Rows.RemoveAt(selectedRowIndex);
                        MessageBox.Show("Student has been removed successfully");

                    }


                }
                else
                {
                    MessageBox.Show("Student record not found.  Failed To Delete");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            string searchID = txtBxSearch.Text;
            bool studentFound = false;

            List<string> deletedLines = File.ReadAllLines("deletedStudents.txt").ToList();
            foreach (string line in deletedLines)
            {
                string[] data = line.Split(' ');
                if (data[0].Trim() == searchID)
                {
                    using (StreamWriter sw = File.AppendText("students.txt"))
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
                var data = line.Split(' ');
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
                txtBxSearch.Text = students[rowIndex].StudentID.ToString();
                txtBxName.Text = students[rowIndex].Name.ToString();
                txtBxSurname.Text = students[rowIndex].Surname.ToString();
                txtBxAge.Text = students[rowIndex].Age.ToString();
                txtBxCourse.Text = students[rowIndex].Course.ToString();
             

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard mainForm = new frmDashboard();
            //Form1 frm1=  new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                // Read each line from the file
                foreach (string line in File.ReadLines(fileHandler.StudentFile))
                {

                    string[] data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (string.IsNullOrWhiteSpace(line)) continue;

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
                        dataGridView1.Rows.Add(item.StudentID, item.Name, item.Surname, item.Age, item.Course);

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
