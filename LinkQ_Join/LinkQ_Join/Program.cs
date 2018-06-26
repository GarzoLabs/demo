using System;
using System.Linq;

namespace LinkQ_Join
{
    class Teacher {
        public string Name { get; set; }
    }

    class Student {
        public string Name { get; set;  }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teachers =
            {
                new Teacher() { Name="Hector" },
                new Teacher() { Name="Andres" },
                new Teacher() { Name="Paula" },
                new Teacher() { Name="Laura" },
                new Teacher() { Name="Diana" },
                new Teacher() { Name="Richard" }
            };

            Student[] students =
            {
                new Student() { Name = "Paulita" },
                new Student() { Name = "Sebita" },
                new Student() { Name = "Diana" },
                new Student() { Name = "Laurita" },
                new Student() { Name = "Ricardito" },
                new Student() { Name = "Andrecito" },
                new Student() { Name = "Hector" }
            };

            //Query Syntax
            /*var JoinList = from teacher in teachers
                           join student in students
                           on teacher.Name equals student.Name
                           select teacher;*/

            //Method Syntax
            var JoinList = teachers.Join(students,
                tName => tName.Name,
                sName => sName.Name,
                (tName, sName) => tName);

            if (JoinList.Count() == 0) {
                Console.WriteLine("No result join");
            }

            foreach (var item in JoinList)
            {
                Console.WriteLine("Name = "+item.Name);
            }
        }
    }
}
