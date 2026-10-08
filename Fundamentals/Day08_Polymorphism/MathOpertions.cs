using System;

// Create class: MathOperations
// Overload these methods:

// Multiply(int a, int b) → int
// Multiply(double a, double b) → double
// Multiply(int a, int b, int c) → int

// Print(string message) → prints message
// Print(string message, int times) → prints message X times
// Print(string message, string color) → prints with color label

// Call all versions
namespace DayO8_Polymorphism
{
    public class MathOperations
    {
        public  int Multiply (int a,int b)
        {
            return a * b;
        }

    public  int Multiply (int a,int b,int c){
            return a *b *c;
        }

        public  double Multiply (double a,double b)
        {
            return a *b;
        }

        public void Print(string message)
        {
            Console.WriteLine($"Message : {message}");
        }

        public void Print(string message,int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine($"Times : {i} {message}");
            }
        }

        public string Print(string message,string color)
        {
            return message+color;
        }


    }

    public class OverLoad
    {
        public static void Run()
        {
            MathOperations math = new MathOperations();
            Console.WriteLine("===== Multiply =====");
            int result1 = math.Multiply(10, 20);
            Console.WriteLine($"int * int     : {result1}");

            double result2 = math.Multiply(2.5, 4.5);
            Console.WriteLine($"double * double : {result2}");

            int result3 = math.Multiply(2, 3, 4);
            Console.WriteLine($"int * int * int : {result3}");

            // Print overloads
            Console.WriteLine("\n===== Print =====");
            math.Print("Hello Sabi!");

            math.Print("Learning C#!", 3);

            math.Print("This is Red!", "Red");
            math.Print("This is Green!", "Green");
            math.Print("This is Cyan!", "Cyan");
        }
    }

    
}