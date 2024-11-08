using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpex2.StudentBooks
{
    [Serializable]
    public class DiplomWork
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public string Date { get; set; }
        public string Score { get; set; }

        public DiplomWork() {}
        public DiplomWork(string name, Teacher teacher, string date, string score)
        {
            Name = name;
            Teacher = teacher;
            Date = date;
            Score = score;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Teacher.GetName()} {Date} {Score}");
            Console.WriteLine();
        }
    }
}
