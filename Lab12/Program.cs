using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person testPerson = new Person("test name person", "test@person.test");
            Student testStudent = new Student("test program", 2000, 15.31, "test name student", "test@student.test");
            Staff testStaff = new Staff("school test name", 25.15, "test name staff", "test@staff.test");
            //wasnt entirely sure how exactly it wanted the strings to look, directions werent clear so i went with
            Console.WriteLine($"{testPerson.ToString()}" +//what the UML diagram looked like, square brackets in the console are ugly i guess
                $"\n\n{testStudent.ToString()}" +
                $"\n\n{testStaff.ToString()}");
        }
    }
}
