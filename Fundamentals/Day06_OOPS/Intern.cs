using System;

namespace Day06_MultiLevelInheritance
{
    public class Intern : Employee
    {
        public int Months;

        public Intern(string name,int age,int months,decimal salary) : base(name, age, salary)
        {
            this.Months = months;
        }

        public override decimal GetSalary()
        {
            return BaseSalary /2;
        }
        public override void PrintAllDetails()
        {
            base.PrintAllDetails();
            Console.WriteLine($"Notice period : {Months}");
        }
    }
}