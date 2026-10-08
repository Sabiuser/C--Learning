using System;

namespace Fundamentals.Day03_Methods
{
    public class Methods
    {
        public static void Run()
        {
            PrintWelcome();
            PrintName("Sabi");
            
            int result = AddSum(23,23);
            Console.WriteLine($"Sum : {result}");

            int year = Getyear();
            Console.WriteLine($"Year : {year}");

            //Task 2
            int sum = Add(45,45);
            Console.WriteLine($"Sum : {sum}");

            int sub = Subtract(95,45);
            Console.WriteLine($"Subtract : {sub}");

            int multiply = Multiply(45,45);
            Console.WriteLine($"Multiply : {multiply}");

            double divide = Divide(45,45);
            Console.WriteLine($"Divide : {divide}");

            //Task 3
            string result1 = GetGrades(95);
            Console.WriteLine($"Result1 : {result1}");

            string result2 = GetGrades(85);
            Console.WriteLine($"Result2 : {result2}");

            string result3 = GetGrades(65);
            Console.WriteLine($"Result3 : {result3}");

            string result4 = GetGrades(55);
            Console.WriteLine($"Result4 : {result4}");

            string result5 = GetGrades(10);
            Console.WriteLine($"Result5 : {result5}");

            //Task 4
            bool numResult = IsEven(8);
             Console.WriteLine($"Results : {numResult}");

              bool numResult1 = IsEven(87);
             Console.WriteLine($"Results1 : {numResult1}");

              bool numResult2 = IsEven(43);
             Console.WriteLine($"Results2 : {numResult2}");

             //Task 5 
             bool isPalindrome = IsPalindrome("MadaM");
             Console.WriteLine(isPalindrome);
             bool isPalindrome2 = IsPalindrome("Mada");
              Console.WriteLine(isPalindrome2);
             bool isPalindrome3 = IsPalindrome("Treee");
              Console.WriteLine(isPalindrome3);
             bool isPalindrome4 = IsPalindrome("MalaYalam");
              Console.WriteLine(isPalindrome4);
        }

        public static void PrintWelcome()
        {
            Console.WriteLine($"Welcome to C#");
        }

        // Task -1
        public static void PrintName(string name)
        {
            Console.WriteLine($"Hi {name}");
        }

        public static int Getyear()
        {
            return 2026;
        }

        public static int AddSum(int a,int b)
        {
            return a + b;
        }

        //Task 2 -Calculator

        public static int Add(int a,int b)
        {
            return a + b;
        }

          public static int Subtract(int a,int b)
        {
            return a - b;
        }

          public static int Multiply(int a,int b)
        {
            return a * b;
        }

          public static double Divide(double a,double b)
        {
            return a / b;
        }

        //Task 3-  Grade

        public static string GetGrades(int marks)
        {
            return marks switch
            {
                >= 90 => "Distinction",
                >=75 => "First Class",
                >=60 => "Second Class",
                >=50 => "Pass",
                _ => "Fail"
            };
        }

        //Task 4 -ISEven

        public static bool IsEven(int number)
        {
            return number%2 ==0 ? true : false;
        }

        // Task 5 -  Palindrome checker

        public static bool IsPalindrome(string word)
        {
            char [] letters = word.ToCharArray();
            Array.Reverse(letters);
            string reversed  =new string(letters);

            if(word.ToLower() == reversed.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}