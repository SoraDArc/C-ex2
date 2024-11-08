using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharpex2.StudentBooks;

namespace Csharpex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var studentBook = new StudentBook(
            //    new Owner("Ся Дмитрий Цзичэнович", "Иниститут математики и информартики", "ИМФКН", "МОАИС", "541119"),
            //    new List<EduTest>
            //    {
            //        new EduTest("Бурятский язык", "зачтено", "18.12.21", new Teacher("Учитель Бур.Языка")),
            //        new EduTest("Мат. Анализ", "зачтено", "20.12.21", new Teacher("Телешева Л.В.")),
            //        new EduTest("Программирование", "зачтено", "22.12.21", new Teacher("Бадмаева Э.С.")),
            //        new EduTest("Физ-ра", "зачтено", "23.12.21", new Teacher("Доржиева Л.Н.")),
            //        new EduTest("Ан. геометрия", "зачтено", "24.12.21", new Teacher("Антонова Л.В.")),
            //    },
            //    new List<Exam>
            //    {
            //        new Exam("Ан. геометрия", "Отлично", "11.01.22", new Teacher("Антонова Л.В.")),
            //        new Exam("Мат. Анализ", "Отлично", "14.01.22", new Teacher("Телешева Л.В.")),
            //        new Exam("Алгебра", "Отлично", "17.01.22", new Teacher("Мордовской К.С.")),
            //        new Exam("История", "Отлично", "20.01.22", new Teacher("Шагдурова К.Т.")),
            //    },
            //    new List<CourseWork>(),
            //    new DiplomWork()
            //    );


 

            string filePath = "studentBook.xml";
            var k = new InteractionXML();
            var studentBook = k.LoadFromXml(filePath);

            while (true)
            {
                Console.WriteLine("1. Информация владельца\n2. Информация о зачётах\n3. Информация о экзаменах\n4. Информация о курсовых\n5. Информация о ВКР" +
                    "\n6. Изменить инф. владельца\n7. Изменить строку в зачётах\n8. Изменить строку в экз.\n9. Изменить строку в курсовой работе" +
                    "\n10. Изменить инф. о ВКР\n11. Удалить элемент из зачёта\n12. Удалить элемент из экзамена\n13. Удалить элемент из курсовых работ" +
                    "\n14. Удалить инф. о ВКР\n15. Удалить инф. владельца\n16. Добавить инф. владельца\n17. Добавить строку в зачёт\n18. Добавить строку в экз." +
                    "\n19. Добавить строку в курсовые работы\n20. Добавить инф. о ВКР\n0. Сохранить и выйти");
                int DelId;
                string input = Console.ReadLine();
                input = input.Trim();
                // Команды
                switch (input)
                {
                    case "1":
                        studentBook.Owner.GetInfo();
                        break;
                    case "2":
                        studentBook.SeeEduTests();
                        break;
                    case "3":
                        studentBook.SeeExams();
                        break;
                    case "4":
                        studentBook.SeeCW();
                        break;
                    case "5":
                        studentBook.DimplomWork.GetInfo();
                        break;
                    case "6":
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите отдел: ");
                        string dep = Console.ReadLine();
                        Console.Write("Введите факультет: ");
                        string fac = Console.ReadLine();
                        Console.Write("Введите специализацию: ");
                        string spec = Console.ReadLine();
                        Console.Write("Введите номер книги: ");
                        string sbn = Console.ReadLine();
                        studentBook.UpdateOwner(name, dep, fac, spec, sbn);
                        break;
                    case "7":
                        Console.Write("Введите id изменяемого: ");
                        string sid = Console.ReadLine();
                        int id = Convert.ToInt32(sid);
                        Console.Write("Введите название: ");
                        string name1 = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        string score = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        string date = Console.ReadLine();
                        Console.Write("Введите имя преподавателя: ");
                        string prep = Console.ReadLine();
                        studentBook.UpdateEduTest(id - 1, name1, score, date, prep);
                        break;
                    case "8":
                        Console.Write("Введите id изменяемого: ");
                        string sid1 = Console.ReadLine();
                        int id1 = Convert.ToInt32(sid1);
                        Console.Write("Введите название: ");
                        string name2 = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        string score1 = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        string date1 = Console.ReadLine();
                        Console.Write("Введите имя преподавателя: ");
                        string prep1 = Console.ReadLine();
                        studentBook.UpdateExam(id1 - 1, name2, score1, date1, prep1);
                        break;
                    case "9":
                        Console.Write("Введите id изменяемого: ");
                        string sid2 = Console.ReadLine();
                        int id2 = Convert.ToInt32(sid2);
                        Console.Write("Введите название: ");
                        string name3 = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        string score2 = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        string date2 = Console.ReadLine();
                        Console.Write("Введите имя преподавателя: ");
                        string prep2 = Console.ReadLine();
                        studentBook.UpdateCW(id2 - 1, name3, score2, date2, prep2);
                        break;
                    case "10":
                        Console.Write("Введите название: ");
                        string name4 = Console.ReadLine();
                        Console.Write("Введите имя преп.: ");
                        string teachName = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        string score3 = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        string date3 = Console.ReadLine();
                        studentBook.UpdateDW(name4, teachName, date3, score3);
                        break;
                    case "11":
                        Console.Write("Введите id удаляемого эл: ");
                        DelId = Convert.ToInt32(Console.ReadLine());
                        studentBook.DeleteElementEduTest(DelId);
                        break;
                    case "12":
                        Console.Write("Введите id удаляемого эл: ");
                        DelId = Convert.ToInt32(Console.ReadLine());
                        studentBook.DeleteElementExam(DelId);
                        break;
                    case "13":
                        Console.Write("Введите id удаляемого эл: ");
                        DelId = Convert.ToInt32(Console.ReadLine());
                        studentBook.DeleteElementCW(DelId);
                        break;
                    case "14":
                        studentBook.DeleteDW();
                        Console.WriteLine("ВКР удалён");
                        break;
                    case "15":
                        studentBook.DeleteOwner();
                        Console.WriteLine("Инф.о владельце удалена");
                        break;
                    case "16":
                        var own = new Owner();
                        Console.Write("Введите имя: ");
                        own.Name = Console.ReadLine();
                        Console.Write("Введите отделение: ");
                        own.Department = Console.ReadLine();
                        Console.Write("Введите факультет: ");
                        own.Faculty = Console.ReadLine();
                        Console.Write("Введите специализацию: ");
                        own.Specialization = Console.ReadLine();
                        Console.Write("Введите номер книги: ");
                        own.StudentBookNumber = Console.ReadLine();
                        studentBook.AddOwner(own);
                        break;
                    case "17":
                        var et = new EduTest();
                        Console.Write("Введите название: ");
                        et.Name = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        et.Score = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        et.Date = Console.ReadLine();
                        Console.Write("Введите имя преподавателя:");
                        var teachName1 = Console.ReadLine();
                        et.Teacher = new Teacher(name: teachName1);
                        studentBook.AddEduTest(et);
                        break;
                    case "18":
                        var ex = new Exam();
                        Console.Write("Введите название: ");
                        ex.Name = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        ex.Score = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        ex.Date = Console.ReadLine();
                        Console.Write("Введите имя преподавателя:");
                        var teachName2 = Console.ReadLine();
                        ex.Teacher = new Teacher(name: teachName2);
                        studentBook.AddExam(ex);
                        break;
                    case "19":
                        var cw = new CourseWork();
                        Console.Write("Введите название: ");
                        cw.Name = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        cw.Score = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        cw.Date = Console.ReadLine();
                        Console.Write("Введите имя преподавателя:");
                        var teachName3 = Console.ReadLine();
                        cw.Teacher = new Teacher(name: teachName3);
                        studentBook.AddCourseWork(cw);
                        break;
                    case "20":
                        var dw = new DiplomWork();
                        Console.Write("Введите название: ");
                        dw.Name = Console.ReadLine();
                        Console.Write("Введите отметку: ");
                        dw.Score = Console.ReadLine();
                        Console.Write("Введите дату: ");
                        dw.Date = Console.ReadLine();
                        Console.Write("Введите имя преподавателя:");
                        var teachName4 = Console.ReadLine();
                        dw.Teacher = new Teacher(name: teachName4);
                        studentBook.AddDimplomWord(dw);
                        break;
                    case "0":
                        k.SaveToXml(filePath, studentBook);
                        return;
                }
            }
            
        }
    }
}
/*
             Name = name;
            Department = department;
            Faculty = faculty;
            Specialization = specialization;
            StudentBookNumber = studentBookNumber;
 */