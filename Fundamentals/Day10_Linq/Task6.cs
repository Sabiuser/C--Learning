using System;

// → All passing marks (>= 50)
// → All failing marks (< 50)
// → Highest mark
// → Lowest mark
// → Average mark
// → Total of passing marks
// → Count of failing students
// → Top 3 marks
// → Marks sorted descending
// → Any mark above 95?
// → All marks above 30?
namespace Day10_Linq
{
    public class LinqTask
    {
        public static void Run()
        {
            int[] marks = { 90, 45, 78, 32, 88, 56, 92, 41, 76, 65 };

            int[] passingMarks = marks.Where(m=>m>=50).ToArray();

            foreach(var mark in passingMarks)
            {
                Console.WriteLine($"Passing Marks : {mark}");
            }

            
            int[] failingMarks = marks.Where(m=> m<=50).ToArray();
            foreach(var mark in failingMarks)
            {
                Console.WriteLine($"Passing Marks : {mark}");
            }

            int highestMark = marks.Max();
            Console.WriteLine($"Highest Mark : {highestMark}");
            
            
            int lowestMark = marks.Min();
            Console.WriteLine($"Lowest Mark : {lowestMark}");

             
            double avgMark = marks.Average();
            Console.WriteLine($"Lowest Mark : {avgMark}");

            int totalSum = marks.Where(m => m >=50).Sum();
            Console.WriteLine($"Total sum : {totalSum}");

            int[] count = marks.Where(f => f < 50).ToArray();
            Console.WriteLine($"Count : {count.Count()}");

            int[] topMarks = marks.OrderByDescending(m=>m).Take(3).ToArray();
            foreach(var top in topMarks)
            {
                Console.WriteLine($"Top Mark : {topMarks}");
            }

            int[] markByDesc = marks.OrderByDescending(m =>m).ToArray();
            foreach(var mark in markByDesc)
            {
                Console.WriteLine($"Descending Order : {mark}");
            }

            bool passMark = marks.Any(m => m >=95);
            Console.WriteLine($"Result : {passMark}");

            
            bool Mark = marks.Any(m => m <=35);
            Console.WriteLine($"Result : {Mark}");

        }
    }
}