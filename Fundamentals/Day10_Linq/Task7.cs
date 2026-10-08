using System;

// → Names starting with 'S'
// → Names longer than 4 characters
// → All names in uppercase
// → Names sorted alphabetically
// → First name alphabetically
// → Count of names with length > 3
// → Names containing 'a' or 'A'
namespace Day10_LinqString
{
    public class StringTask
    {
        public static void Run()
        {
            List<string> names = new List<string>(){ "Sabi", "Kumar", "Sam", "Ramji", "Raj", "Priya", "Arun", "Kiran" };

        string[]  startWithS = names.Where(s=>s.StartsWith('S')).ToArray();
        foreach(var name in startWithS)
            {
                Console.WriteLine($"Names : {name}");
            }

            string [] longNames = names.Where(name => name.Length>4).ToArray();
            for(int i = 0; i < longNames.Length; i++)
            {
                Console.WriteLine($"Names : {longNames[i]}");
            }

            List<string> sortedNames = new List<string>();
            sortedNames.Sort();

            for(int i = 0; i < sortedNames.Count; i++)
            {
                Console.WriteLine($"Sorted Names : {sortedNames[i]}");
            }
        }
    }
}