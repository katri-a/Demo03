using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student
                {
                   School = "JAMK", Name = "River Jokinen", StudentId = "K2255"
                },
                new Student
                {
                    School = "TAMK", Name = "Sakari Sikke", StudentId = " S6541"
                },
                new Student
                {
                    School = "JAMK", Name = "Helinä Keiju", StudentId = " K1112"
                }

            };

            foreach (Student i in students)
                Console.WriteLine("School: {0}\nName: {1}\nStudentID: {2}\n", i.School, i.Name, i.StudentId);
        }
    }
}
