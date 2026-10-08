using System;
// Using same student list:
// → IT students with CGPA > 8 sorted by CGPA
// → Top 2 students by CGPA
// → Department wise average CGPA
// → Youngest student
// → Names of students with CGPA > 7 in uppercase
namespace Day10_LinqChaining
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public double CGPA { get; set; }

        public string Department { get; set; } = string.Empty;

    }

    public class LinqTask
    {
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
             var itStudents = student.Where(s=>s.Department=="TT")
                                     .OrderBy(s=>s?.CGPA)
                                     .Where(s=>s?.CGPA>8)
                                     .Select(s=>s?.Name)
                                     .ToList();

                foreach(var it in itStudents)
            {
                Console.WriteLine($"Students : {it}");
            }  

            var topStudents = student.OrderByDescending(s=>s?.CGPA).Take(2);
            foreach(var std in topStudents)
            {
                Console.WriteLine($"Students : {std.Name} CGPA : {std.CGPA}");
            }                   

            // var groupWiseDept = student.GroupBy(s=>s.Department).Average().
            var youngestStudent = student.OrderBy(n=>n.Age).Take(1).Select(s=>s.Name).ToList();
            foreach(var std in youngestStudent)
            {
                Console.WriteLine($"Youngest Student : {std}");

            }

            var uppercaseStd = student.Where(s=>s.CGPA >7).Select(s=>s.Name.ToUpper()).ToList();
            foreach(var std in uppercaseStd)
            {
                Console.WriteLine($"Student : {std}");
            }
                                                    
        }
    }

}