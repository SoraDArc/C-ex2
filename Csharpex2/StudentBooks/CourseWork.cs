using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpex2.StudentBooks
{
    [Serializable]
    public class CourseWork
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public string Date { get; set; }
        public string Score { get; set; }

        public CourseWork() { }
        public CourseWork(string name, Teacher teacher, string date, string score)
        {
            Name = name;
            Teacher = teacher;
            Date = date;
            Score = score;
        }
    }
}
