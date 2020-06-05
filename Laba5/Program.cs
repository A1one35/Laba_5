using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba5
{
    class Program
    {
        struct Student
        {
            public string surName;
            public string firstName;
            public string patronymic;
            public char sex;
            public string dateOfBirth;
            public char mathematicsMark;
            public char physicsMark;
            public char informaticsMark;
            public int scholarship;
            public Student(string lineWithAllData)
            {
                string[] linesWithDataAboutOneStudent = lineWithAllData.Split(' ');
                this.surName = linesWithDataAboutOneStudent[0];
                this.firstName = linesWithDataAboutOneStudent[1];
                this.patronymic = linesWithDataAboutOneStudent[2];
                this.sex = Convert.ToChar(linesWithDataAboutOneStudent[3]);
                this.dateOfBirth = linesWithDataAboutOneStudent[4];
                this.mathematicsMark = Convert.ToChar(linesWithDataAboutOneStudent[5]);
                this.physicsMark = Convert.ToChar(linesWithDataAboutOneStudent[6]);
                this.informaticsMark = Convert.ToChar(linesWithDataAboutOneStudent[7]);
                this.scholarship = Convert.ToInt32(linesWithDataAboutOneStudent[8]);
            }
        }
        static void Main(string[] args)
        {
            string path = @"input.txt";
            Student[] studs = ReadData(path);
            runMenu(studs);
            Console.ReadKey();
        }
        static void runMenu(Student[] studs)
        {
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].sex == 'M')
                {
                    if ((studs[i].mathematicsMark == '2' && studs[i].physicsMark == '2') || (studs[i].mathematicsMark == '2' && studs[i].physicsMark == '1') || (studs[i].mathematicsMark == '2' && studs[i].physicsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                    if ((studs[i].mathematicsMark == '1' && studs[i].physicsMark == '2') || (studs[i].mathematicsMark == '1' && studs[i].physicsMark == '1') || (studs[i].mathematicsMark == '1' && studs[i].physicsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                    if ((studs[i].mathematicsMark == 45 && studs[i].physicsMark == '2') || (studs[i].mathematicsMark == 45 && studs[i].physicsMark == '1') || (studs[i].mathematicsMark == 45 && studs[i].physicsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }

                    if ((studs[i].physicsMark == '2' && studs[i].informaticsMark == '2') || (studs[i].physicsMark == '2' && studs[i].informaticsMark == '1') || (studs[i].physicsMark == '2' && studs[i].informaticsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                    if ((studs[i].physicsMark == '1' && studs[i].informaticsMark == '2') || (studs[i].physicsMark == '1' && studs[i].informaticsMark == '1') || (studs[i].physicsMark == '1' && studs[i].informaticsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                    if ((studs[i].physicsMark == 45 && studs[i].informaticsMark == '2') || (studs[i].physicsMark == 45 && studs[i].informaticsMark == '1') || (studs[i].physicsMark == 45 && studs[i].informaticsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }

                    if ((studs[i].mathematicsMark == '2' && studs[i].informaticsMark == '2') || (studs[i].mathematicsMark == '2' && studs[i].informaticsMark == '1') || (studs[i].mathematicsMark == '2' && studs[i].informaticsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                    if ((studs[i].mathematicsMark == '1' && studs[i].informaticsMark == '2') || (studs[i].mathematicsMark == '1' && studs[i].informaticsMark == '1') || (studs[i].mathematicsMark == '1' && studs[i].informaticsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                    if ((studs[i].mathematicsMark == 45 && studs[i].informaticsMark == '2') || (studs[i].mathematicsMark == 45 && studs[i].informaticsMark == '1') || (studs[i].mathematicsMark == 45 && studs[i].informaticsMark == 45))
                    {
                        Console.WriteLine("Більше двох екзаменів не здав -" + studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    }
                }
            }
        }
        static Student[] ReadData(string fileName)
        {
            string[] pathForFile = File.ReadAllLines(fileName);
            Student[] ArrayOfStudent = new Student[pathForFile.Length];
            for (int i = 0; i < pathForFile.Length; i++)
            {
                ArrayOfStudent[i] = new Student(pathForFile[i]);
            }
            return ArrayOfStudent;
        }
    }
}
