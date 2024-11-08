using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csharpex2.StudentBooks
{
    [Serializable]
    public class StudentBook
    {
        public Owner Owner;
        public List<EduTest> EduTests;
        public List<Exam> Exams;
        public List<CourseWork> CourseWorks;
        public DiplomWork DimplomWork;

        public StudentBook() { }
        public StudentBook(Owner owner, List<EduTest> eduTest, List<Exam> exam, List<CourseWork> courseWorks, DiplomWork diplomWork)
        {
            Owner = owner;
            EduTests = eduTest;
            Exams = exam;
            CourseWorks = courseWorks;
            DimplomWork = diplomWork;
        }
        
        public void SeeEduTests()
        {
            for (var i = 0; i < EduTests.Count; i++) 
            {
                Console.WriteLine($"{i+1}. {EduTests[i].Name} {EduTests[i].Score} {EduTests[i].Date} {EduTests[i].Teacher.GetName()}");
            }
            Console.WriteLine();
        }
        public void SeeExams()
        {
            for (var i = 0; i < Exams.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Exams[i].Name} {Exams[i].Score} {Exams[i].Date} {Exams[i].Teacher.GetName()}");
            }
            Console.WriteLine();
        }
        public void SeeCW()
        {
            for (var i = 0; i < CourseWorks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {CourseWorks[i].Name} {CourseWorks[i].Score} {CourseWorks[i].Date} {CourseWorks[i].Teacher.GetName()}");
            }
            Console.WriteLine();
        }

        // Добавление
        public void AddOwner(Owner own)
        {
            Owner = own;
        }
        public void AddEduTest(EduTest et)
        {
            EduTests.Add(et);
        }

        public void AddExam(Exam exam)
        {
            Exams.Add(exam);
        }

        public void AddCourseWork(CourseWork courseWork)
        {
            CourseWorks.Add(courseWork);
        }

        public void AddDimplomWord(DiplomWork dw)
        {
            DimplomWork = dw;
        }

        //Изменение
        public void UpdateOwner(string name, string dep, string fac, string spec, string sbn)
        {
            Owner = new Owner(name, dep, fac, spec, sbn);
        }

        public void UpdateEduTest(int id, string name, string score, string date, string teachName)
        {
            EduTests[id] = new EduTest(name, score, date, new Teacher(teachName));
        }

        public void UpdateExam(int id, string name, string score, string date, string teachName)
        {
            Exams[id] = new Exam(name, score, date, new Teacher(teachName));
        }
        public void UpdateCW(int id, string name, string score, string date, string teachName)
        {
            CourseWorks[id] = new CourseWork(name, new Teacher(teachName), date, score);
        }

        public void UpdateDW(string name, string teachName, string date, string score)
        {
            DimplomWork = new DiplomWork(name, new Teacher(teachName), date, score);
        }

        // Удаление
        public void DeleteOwner()
        {
            Owner = new Owner();
        }

        public void DeleteElementEduTest(int id)
        {
            EduTests.RemoveAt(id - 1);
        }

        public void DeleteElementExam(int id)
        {
            Exams.RemoveAt(id - 1);
        }

        public void DeleteElementCW(int id)
        {
            CourseWorks.RemoveAt(id - 1);
        }

        public void DeleteDW()
        {
            DimplomWork = new DiplomWork();
        }
    }
}