using Csharpex2.StudentBooks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Csharpex2
{
    internal class InteractionXML
    {
        public void SaveToXml(string filePath, StudentBook sb)
        {
            var serializer = new XmlSerializer(typeof(StudentBook));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, sb);
                Console.WriteLine("СОХРАНЕНО");
            }
        }

        public StudentBook LoadFromXml(string filePath)
        {
            var serializer = new XmlSerializer(typeof(StudentBook));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (StudentBook)serializer.Deserialize(fs);
            }
        }
    }
}
