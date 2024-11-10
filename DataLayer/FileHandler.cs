using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPrep1.PresentationLayer;

namespace TestPrep1.DataLayer
{
    internal class FileHandler
    {
        public string StudentFile { get; set; }
           
        public FileHandler(string filePath)
        {
             this.StudentFile = filePath;
        }

        public List<string> ViewData()
        {
            List<string> info = new List<string>();
            foreach (string line in File.ReadAllLines(StudentFile))
            {
                info.Add(line);
            }

            return info;
        }
  
    }

}
