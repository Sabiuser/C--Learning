using System;

namespace Fundamentals.Day02_Loops
{
    public class Loops
    {
       public static void Run()
        {
            int a = 24;
            int b =7;

            string result = a%2==0 ? "Even":"Odd";
            Console.WriteLine($"Result : {result}");

            string result2  =b%2 ==0 ?"Even":"Odd";
               Console.WriteLine($"Result : {result2}");

               //Print all Even numbers from 1 to 20 using for loop

               for(int i = 0; i <=20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even numbers: {i}");
                }
            }

            //Start from 1, keep doubling the number while it is less than 500

            int number = 1;
            while (number < 500)
            {
                Console.WriteLine($"Number : {number}");
                number*=2;// or number = number*2
            }

            //Ask user to enter a number
            //Keep asking until they enter a number greater than 100
            //Then print "Valid number entered!"

           int input;
            do
            {
                Console.WriteLine("Enter a number :");
                 input = Convert.ToInt32(Console.ReadLine());
            }while (input<100);
            Console.WriteLine($"Valid Number Entered : {input}");
                
            //Create an int array with 5 numbers
            //Loop through and print whether each is Even or Odd

            int [] numbers = {1,2,3,4,5};

            foreach (var item in numbers)
            {
                if(item%2 == 0)
                {
                    Console.WriteLine($"EvenNumber in foreach : {item}");
                }
            }
            
        }
    }
}