using System;
// Create Stack<string> for browser history
// → Visit 5 pages (Push)
// → Show current page (Peek)
// → Go back 3 times (Pop)
// → Show remaining history
namespace Day09_Stack
{
    public class StackTask
    {
        public static void Run()
        {
            Stack<string> browsers = new Stack<string>();
            browsers.Push("Google");
            browsers.Push("Edge");
            browsers.Push("Opera");
            browsers.Push("Brave");
            browsers.Push("Safari");

            string currentPage = browsers.Peek();
            Console.WriteLine($"Current page : {currentPage}");

            string pop1 = browsers.Pop();
            Console.WriteLine($"First page : {pop1}");

            string pop2 = browsers.Pop();
            Console.WriteLine($"First page : {pop2}");

            string pop3 = browsers.Pop();
            Console.WriteLine($"First page : {pop3}");

            foreach(var page in browsers)
            {
                Console.WriteLine($"Remaining pages : {page}");
            }
        }
    }
}