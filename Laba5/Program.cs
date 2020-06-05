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
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
            fileName = File.ReadAllText("input.txt");
        }
        public Student(string lineWithAllData)
        {
            // TODO   you SHOULD IMPLEMENT constructor with exactly this signature
            // lineWithAllData is string contating all data about one student, as described in statement
            for (int i = 0; i < ; i++)
            {

            }
        }
        static void runMenu(Student[] studs)
        {
            // TODO   implement this method
            // It should call method(s) for concrete variant(s)
        }
        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
