using System;

namespace Day06_MultiLevelInheritance
{
    public class Manager : Employee
    {
        public decimal Bonus;

        public Manager(string name,int age,decimal salary,decimal bonus) : base(name, age, salary)
        {
            this.Bonus = bonus;
        }

        public override decimal GetSalary()
        {
            // return base.GetSalary();
            return BaseSalary + Bonus;
        }

        public override void PrintAllDetails()
        {
            base.PrintAllDetails();
            Console.WriteLine($"My bonus is {Bonus}");
        }
    }
}