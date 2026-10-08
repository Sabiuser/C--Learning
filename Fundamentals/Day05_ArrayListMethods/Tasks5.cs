using System;
using System.Numerics;

namespace Fundamentals.Day05_ArrayListMethods
{
    public class ArrayListMethods
    {
        public static void Run()
        {
            // int [] marks = { 90, 85, 78, 92, 88 };
            // // double result = GetAverage(marks);
            // var passedMarks = new List<int>(){90, 35, 78, 45, 88, 20, 65};
            // List<int> filterMarks = FilterFailing(passedMarks);
            // int count = filterMarks.Count;
            // Console.WriteLine($"Count : {count}");
            // Console.Beep();
            // foreach(var filter in  filterMarks)
            // Console.WriteLine($"Marks : {filter}");
            // int result = GetLowest(marks);
            // Console.WriteLine($"Lowest Number : {result}");
        //  Console.WriteLine($"Average : {result}");
        // int[] marks = { 90, 85, 78, 92, 88 };
        // int target = 7;
        // bool result = ContainsValue(marks,target);
        // Console.WriteLine($"Value : {result}");
        // int[] marks = { 95, 80, 65, 45, 30 };
        // string result = GetAllGrades(95);
        // Console.WriteLine($"Grade : {result}");
        // int[] marks = { 90, 85, 78, 92, 88 };
        // int [] result = ReverseArray(marks);
        // Console.WriteLine($"Reversed Array : {string.Join(",",result)}");
        var list = new List<int>{ 90, 85, 90, 78, 85, 92, 78 };
        List<int> result = RemoveDuplicates(list); 
        Console.WriteLine($"Unique List : {string.Join(",",result)}");
        }

        // public static int GetLowest(int[] marks)
        // {
        //     int lowestNumber = marks[0];

        //     foreach(int mark in marks)
        //     {
        //         if(mark < lowestNumber)
        //         {
        //             lowestNumber = mark;
        //         }
        //     }
        //     return lowestNumber;
        // }
    
        // public static double GetAverage(int[] marks)
        // {
        //         int count = marks.Count();
        //         int total = 0;
      
        //         for(int i = 0; i < marks.Length; i++)
        //     {
                
        //         total+=marks[i];
        //     }

        //     double average = (double)total/marks.Length;
        //     return average;
        // }

        // public static List<int> FilterFailing (List<int> marks){
        //   var newList  =new List<int>();

        //   foreach(var filtermarks in marks)
        //     {
        //         if (filtermarks >= 50)
        //         {
        //             newList.Add(filtermarks);
        //         }

        //     }
        //     return newList;
        // }

        // public static bool ContainsValue(int[] numbers, int target)
        // {
        //    foreach(var number in numbers)
        //     {
        //         if(number == target)
        //         {
        //             return true;
        //         }
        //     } 
        //     return false;
        // }

        // public static string GetAllGrades(int marks)
        // {
        //      return marks switch
        //         {
        //             >=95 =>"Distinction",
        //             >=80 =>"First Class",
        //             >=65 =>"Second Class",
        //             >=45 =>"Fail",
        //             >=30 =>"Fail",
        //             _ =>"Default",


        //          };
            
          
            
        // }

        // public static int[] ReverseArray(int[] marks)
        // {
        //     int start = 0;
        //     int end  = marks.Length -1;

        //     while(start < end)
        //     {
        //         int temp = marks[start];
        //         marks[start] = marks[end];
        //         marks[end] = temp;

        //         start++;
        //         end--;
        //     }
        //     return marks;
        // }

        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            var uniqueElement = new List<int>();
            foreach(var number in numbers)
            {
                if (!uniqueElement.Contains(number))
                {
                    uniqueElement.Add(number);
                }
            }
            return uniqueElement;
        }
    }

}