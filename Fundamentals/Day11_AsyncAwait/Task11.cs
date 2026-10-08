using System;

// Create StudentService class with async methods:
// → GetStudentAsync(int id) → returns Student after 1 sec
// → GetAllStudentsAsync()   → returns List<Student> after 2 secs
// → SaveStudentAsync(Student s) → saves after 1 sec, returns bool

// Call all from RunAsync()

namespace Day11_AsyncAwaitTwo
{
    public class StudentService
    {
        public async Task<List<string>> GetStudentAsync(int id)
        {
            Console.WriteLine("Fetching Student by id...");
            await Task.Delay(1000);
               return new List<string> { "Sabi"};

        }

        public async Task<List<string>> GetAllStudentsAsync()
        {
            Console.WriteLine("Fetching all students...");
            await Task.Delay(200);
            return new List<string> { "Sabi", "Kumar", "Raj" };
        }

       public async Task SaveStudentAsync(string name)
    {
        Console.WriteLine($"Saving {name}...");
        await Task.Delay(1000);  // simulate DB delay
        Console.WriteLine($"{name} saved!");
    }
    }

    public class AsyncTaskTwo
    {
       public static async Task Run()
        {
            StudentService studentService = new StudentService();
            await studentService.GetStudentAsync(2);
            await studentService.GetAllStudentsAsync();
            await studentService.SaveStudentAsync("Sabi");
        }
    }
}