

namespace  Fundamentals.Day01_Variables
{
    public class Basics
    {
        public static void Run()
        {
            string name ="Sabi";
            int age = 21;
            double cgpa = 8.5;
            bool isStudent = true;
            char firstLetter = 'S';
            long population = 7668987986695678756L;
            float percentage = 3.6779776f;
            decimal amount = 6.789446543657676m;

            int mark = Convert.ToInt32(cgpa);
            int year = Convert.ToInt32("2022")+4;
            Console.WriteLine($"Mark :{mark}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Student : {isStudent}");
            Console.WriteLine($"FirstLetter : {firstLetter}");
            Console.WriteLine($"Year : {year}");
            Console.WriteLine($"Population : {population}");
            Console.WriteLine($"Percentage : {percentage}");
            Console.WriteLine($"Amount : {amount}");

        }
    }
}