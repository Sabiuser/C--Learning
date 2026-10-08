using System;

namespace Day06_MultiLevelInheritance
{
    public class InheritanceEmployee
    {
        public static void Run()
        {
            Console.WriteLine("=======Manager======");
            Manager manager = new Manager("Feroze", 35, 20000, 10000);
            manager.PrintAllDetails();
            Console.WriteLine("=======Developer======");
            Developer developer = new Developer("Sabi", 21, 10000, ".Net,Angular,React,MSSQL");
            developer.PrintAllDetails();
            Console.WriteLine("=======Intern======");
            Intern intern = new Intern("Sam", 20, 12, 5000);
            intern.PrintAllDetails();
        }
    }
}