using System;

// Create a simple student registry:
// Dictionary<int, string> students
//   → key = rollNumber, value = name

// HashSet<int> presentToday
//   → stores roll numbers of present students

// → Add 5 students to registry
// → Mark 3 as present
// → Try marking same student twice
// → Print present students with names
// → Print absent students with names
namespace Day09_MixedTask
{
    public class Mixed
    {
        public static void Run()
        {
            Dictionary<int,string> students = new Dictionary<int,string>();
            students.Add(001,"Bharani");
            students.Add(002,"Samuel");
            students.Add(003,"Sabi");
            students.Add(004,"Vinayak");
            students.Add(005,"Sam");

            HashSet<int> presentToday = new HashSet<int>();
            presentToday.Add(001);
            presentToday.Add(002);
            presentToday.Add(003);

            students.Add(004,"Vinayak");
            students.Add(005,"Sam");
        }
    }
}