// using System;
// Create two HashSet<string>:
// set1 = { "C#", "Java", "Python", "Angular" }
// set2 = { "Python", "React", "C#", "Node" }

// → Print both sets
// → Find common skills (Intersection)
// → Find all unique skills (Union)
// → Find skills only in set1 (Difference)
// → Try adding duplicate — show it's ignored
namespace DayO9_HashSet
{
    public class HashSetTask
    {
        public static void Run()
        {
            HashSet<string> set1 = new HashSet<string>{"C#", "Java", "Python", "Angular"};
            HashSet<string> set2 = new HashSet<string>{"Python", "React", "C#", "Node" };

            foreach(var set in set1)
            {
                Console.WriteLine($"Set : {set}");
            }

            foreach(var sets in set2)
            {
                Console.WriteLine($"Sets : {sets}");
            }

           HashSet<string> intersection = new HashSet<string>(set1);
            intersection.IntersectWith(set2);
            Console.WriteLine("\n===== Common Skills =====");
            foreach (var skill in intersection)
                Console.WriteLine(skill);

            // Union — all unique skills
            HashSet<string> union = new HashSet<string>(set1);
            union.UnionWith(set2);
            Console.WriteLine("\n===== All Unique Skills =====");
            foreach (var skill in union)
                Console.WriteLine(skill);

            // Difference — only in set1
            HashSet<string> difference = new HashSet<string>(set1);
            difference.ExceptWith(set2);
            Console.WriteLine("\n===== Skills Only in Set1 =====");
            foreach (var skill in difference)
                Console.WriteLine(skill);
        }
    }
}