using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpex2.StudentBooks
{
    [Serializable]
    public class Owner
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public string StudentBookNumber { get; set; }


        public Owner() { }
        public Owner(string name, string department, string faculty, string specialization, string studentBookNumber)
        {
            Name = name;
            Department = department;
            Faculty = faculty;
            Specialization = specialization;
            StudentBookNumber = studentBookNumber;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Department} {Faculty} {Specialization} {StudentBookNumber}");
            Console.WriteLine();
        }
    }
}
