using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpex2.StudentBooks
{
    [Serializable]
    public class Teacher
    {
        public string Name { get; set; }
        public Teacher() { }

        public Teacher(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
