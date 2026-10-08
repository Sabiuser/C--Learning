using System;

// Create async methods:
// → GreetAsync(string name) → prints "Hello {name}!" after 1 sec delay
// → GetYearAsync() → returns int 2026 after 500ms delay
// → Call both from RunAsync()
namespace Day11_AsyncAwait
{
   public class AsyncTask
    {
         public async Task<string> GreetAsync(string name)
    {
        await Task.Delay(1000);
        return $"Hello {name}";
        
    }

       public async Task<int> GetYearAsync()
    {
        await Task.Delay(5000);
        return 2026;
        
    }
       
    }
    public class Async{
   public static async Task Run()
        {
            AsyncTask asyncTask = new AsyncTask();
           Console.WriteLine("Calling GreetAsync...");
            string greeting = await asyncTask.GreetAsync("Sabi");
            Console.WriteLine(greeting);

            // Call GetYearAsync — wait for result
            Console.WriteLine("Calling GetYearAsync...");
            int year = await asyncTask.GetYearAsync();
            Console.WriteLine($"Year : {year}");
        }
    }
 

 
}