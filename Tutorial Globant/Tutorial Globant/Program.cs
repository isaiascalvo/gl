using System;
using System.Collections.Generic;

namespace Tutorial_Globant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Student> students = new List<Student>();
            List<Person> persons = new List<Person>();

            students = LoadStudents();

            Console.WriteLine("Students size: {0}", students.Count);
            foreach (var student in students)
            {
                Console.WriteLine("Student name: {0}, student mail: {1}", student.Name, student.Mail);
            }
            Console.WriteLine("//////////////////////////////////");

            Func<Student, Person> mapFunction = s => new Person { Name = s.Name, Mail = s.Mail };

            persons = students.MapCollection<Student, Person>(mapFunction);

            Console.WriteLine("Persons size: {0}", persons.Count);
            foreach (var person in persons)
            {
                Console.WriteLine("Person name: {0}, person mail: {1}", person.Name, person.Mail);
            }
        }

        private static List<Student> LoadStudents()
        {
            return new List<Student>() {
                new Student { Name = "participant1", Mail = "mail1" },
                new Student { Name = "participant2", Mail = "mail2" },
                new Student { Name = "participant3", Mail = "mail3" },
                new Student { Name = "participant4", Mail = "mail4" },
                new Student { Name = "participant5", Mail = "mail5" }
            };
        }
    }
}
