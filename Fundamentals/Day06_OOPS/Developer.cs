using System;

namespace Day06_MultiLevelInheritance
{
    public class Developer : Employee
    {
        public string TechStack;

        public Developer(string name,int age,decimal salary,string stack) : base(name, age, salary)
        {
            this.TechStack = stack;
        }

        public override decimal GetSalary()
        {
            return BaseSalary * 1.2m;
        }

        public override void PrintAllDetails()
        {
            base.PrintAllDetails();
            Console.WriteLine($"Tech Stack : {TechStack}");
        }
    }
}