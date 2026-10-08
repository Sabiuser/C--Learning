using System;
using System.ComponentModel.DataAnnotations;

// Create List<Student> with 5 students
// Properties: Name, Age, CGPA, Department

// Using LINQ:
// → Students with CGPA > 8
// → Students from IT department
// → Average CGPA
// → Topper (highest CGPA)
// → Names of all students
// → Students sorted by CGPA descending
// → Count of students per department
// → Students aged 21
namespace Day10_LinqObj
{
    public class Student
    {
           public string Name {get;set;}
            public int Age {get;set;}

            public double CGPA {get;set;}

            public string Department {get;set;}
        public static void Run()
        {
         
            var student = new List<Student>()
            {
                new Student { Name = "Sabi",   Age = 21, CGPA = 8.8, Department = "IT" },
    new Student { Name = "Kumar",  Age = 22, CGPA = 7.5, Department = "CS" },
    new Student { Name = "Raj",    Age = 21, CGPA = 9.1, Department = "IT" },
    new Student { Name = "Priya",  Age = 23, CGPA = 6.5, Department = "CS" },
    new Student { Name = "Arun",   Age = 22, CGPA = 8.2, Department = "IT" }
            };

            var cgpa = student.Where(s=>s.CGPA >8).ToList();
            foreach(var mark in cgpa)
            {
                Console.WriteLine($"CGPA : {mark}");
            }

            var dept = student.Where(std =>std.Department == "IT");
            foreach(var dep in dept)
            {
                Console.WriteLine($"Department : {dep}");
            }

            var average = student.Average(s=>s.CGPA);
           Console.WriteLine($"Average : {average}");

           var topper = student.OrderByDescending(s=>s.CGPA).First();
           Console.WriteLine($"Topper : {topper}");

           var names = student.Select(s=>s.Name).ToList();
           foreach(var name in names)
            {
                Console.WriteLine($"Names : {name}");
            }

            var cgpaDesc = student.OrderByDescending(s=>s.CGPA);
            Console.WriteLine($"CGPA DESCENDING : {cgpaDesc}");

            var deptCount = student.GroupBy(s=>s.Department).Count();
            Console.WriteLine($"Departments : {deptCount}");

            var age = student.Where(s=>s.Age >21).ToList();
            Console.WriteLine($"Student Age : {age}");
            }
    }
}