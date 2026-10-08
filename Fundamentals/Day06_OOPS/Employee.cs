using System;

namespace Day06_MultiLevelInheritance
{
//     Create Parent: Employee
// Properties: Name, Age, BaseSalary
// Constructor: takes all 3
// Method: virtual GetSalary() → returns BaseSalary
// Method: PrintDetails() → prints all + salary

// Create Children: Manager, Developer, Intern
// Manager   → extra: Bonus → salary = BaseSalary + Bonus
// Developer → extra: TechStack → salary = BaseSalary * 1.2
// Intern    → extra: Months → salary = BaseSalary / 2

// Create one of each, call PrintDetails()
    public class Employee
    {
        public string Name;
        public int Age;
        public decimal BaseSalary;

        public Employee(string name,int age,decimal salary)
        {
            this.Name = name;
            this.Age = age;
            this.BaseSalary = salary;
        }

        public virtual decimal GetSalary()
        {
            return BaseSalary;
        }

        public virtual void PrintAllDetails()
        {
            Console.WriteLine($"I am {Name} and my age is {Age} and my Salary is : {GetSalary()}");
        }
    }
}