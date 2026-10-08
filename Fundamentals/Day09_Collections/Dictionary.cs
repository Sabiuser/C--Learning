using System;

// Create Dictionary<string, int> studentMarks
// Add 5 students with marks
// → Print all students and marks
// → Find mark of specific student using TryGetValue
// → Update one student's mark
// → Remove one student
// → Print count
// → Print only students who scored > 75
namespace Day09_Dictionary
{
    public  class CollectionTask
    {
       public static void Run()
        {
            Dictionary<string,int> studentMarks = new Dictionary<string, int>();
            studentMarks.Add("Sabi",85);
            studentMarks.Add("Ramji",95);
            studentMarks.Add("Bharani",85);
            studentMarks.Add("Mani",65);
            studentMarks.Add("Vijay",45);

            foreach (var students in studentMarks)
            {
                Console.WriteLine($"Student Name : {students.Key} Marks : {students.Value}");
            }

            foreach(var key in studentMarks.Keys)
            {
                if(studentMarks.TryGetValue(key,out int mark))
                {
                    Console.WriteLine($"{key} : {mark}");

                }
            }

            studentMarks["Mani"] = 88;
            studentMarks.Remove("Vijay");

            Console.WriteLine($"Total Count : {studentMarks.Count}");
            bool result = studentMarks.ContainsKey("Sabi");
            Console.WriteLine($"Result : {result}");
            bool  valueResult = studentMarks.ContainsValue(95);
             Console.WriteLine($"Result : {valueResult}");

             foreach(var filterStudent in studentMarks)
            {
                if(filterStudent.Value > 75)
                {
                    Console.WriteLine($"Passed students : {filterStudent.Key}");
                }
            }
        }
    }
}