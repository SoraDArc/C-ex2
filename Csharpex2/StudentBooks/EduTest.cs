using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpex2.StudentBooks
{
    [Serializable]
    public class EduTest
    {
        public string Name { get; set; }
        public string Score { get; set; }
        public string Date { get; set; }
        public Teacher Teacher { get; set; }

        public EduTest() { }
         public EduTest(string name, string score, string date, Teacher teacher)
        {
            Name = name;
            Score = score;
            Date = date;
            Teacher = teacher;
        }
    }
}
