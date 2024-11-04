using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrep1.PresentationLayer
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age {  get; set; }
        public string Course { get; set; }

        public Student(string sID, string name, string surname, string age, string course)
        {
            this.StudentID = sID;
                this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Course = course;
        }

        public override string ToString()
        {
            return $"{StudentID} {Name} {Surname} {Age} {Course}";
           
        }

        public string rawData()
        {
            return $"Student ID: {StudentID} | Name: {Name} | Surname: {Surname} | Age: {Age} | Course Enrolled: {Course}";
        }
           

    }
}
