using System;
using System.Collections.Generic;
using System.Linq;

namespace Day04_ArraysAndList
{
    public class ArrayList
    {
        public static void Run()
        {

            int[] markss = { 90, 85, 78, 92, 88 };
            int highest = GetHighest(markss);
            Console.WriteLine($"Highest number : {highest}");

            List<int> marksss = new List<int> { 90, 35, 78, 45, 88, 20, 65 };
            List<int> passingMarks = FilterPassing(marksss);
            Console.WriteLine($"Passed Marks : {string.Join(",", passingMarks)}");



            //Create int array with 5 marks
            //Print all using foreach
            //Print highest mark
            //Print lowest mark
            //Print total marks
            //Print average marks
            int[] marks = new int[5];
            marks[0] = 67;
            marks[1] = 677;
            marks[2] = 679;
            marks[3] = 671;
            marks[4] = 667;
            foreach (int mark in marks)
            {
                Console.WriteLine($"Marks : {mark}");
            }
            int highestMark = marks.Max();
            Console.WriteLine($"Highest Marks : {highestMark}");

            int lowestMark = marks.Min();
            Console.WriteLine($"Lowest Marks : {lowestMark}");

            int totalMarks = marks.Sum();
            Console.WriteLine($"Total Marks : {totalMarks}");

            double averageMarks = marks.Average();
            Console.WriteLine($"Average Marks : {averageMarks}");

            // Task 2
            string[] names = new string[5];
            names[0] = "Sabi";
            names[1] = "Ayisha";
            names[2] = "Bharani";
            names[3] = "Ramji";
            names[4] = "Mani";

            Array.Sort(names);
            Console.WriteLine($"Sorted Names : {string.Join(",", names)}");

            Array.Reverse(names);
            Console.WriteLine($"Reversed Names : {string.Join(",", names)}");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Index {i} : {names[i]}");
            }

            //Task 3
            List<string> skills = new List<string>();
            skills.Add("C#");
            skills.Add("Java");
            skills.Add(".Net");
            skills.Add("Angular");
            skills.Add("React");

            foreach (string skill in skills)
            {
                Console.WriteLine($"Skills : {skill}");
            }
            skills.RemoveAt(1);
            skills.Insert(1, "Python");
            int totalCount = skills.Count();
            Console.WriteLine($"Count : {totalCount}");

            foreach (var finallist in skills)
            {
                Console.WriteLine($"Final List : {finallist}");
            }

            // Task 4




        }
        public static int GetHighest(int[] marks)
        {
            int highest = marks[0];


            foreach (var mark in marks)
            {
                if (mark > highest)
                {
                    highest = mark;
                }
            }
            return highest;
        }

        // Task 5
        public static List<int> FilterPassing(List<int> marks)
        {
            List<int> passedMarks = new List<int>();
            foreach (var mark in marks)
            {
            if (mark > 50)
                {
                    passedMarks.Add(mark);
                }
            }
            return passedMarks;
        }


    }
}