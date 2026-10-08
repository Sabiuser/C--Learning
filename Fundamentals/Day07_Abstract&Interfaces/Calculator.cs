// ============Task 3==============
// Create interface: ICalculatable
// Methods: Calculate(), PrintResult()

// Create abstract class: TaxCalculator
// Implements ICalculatable
// Property: Income
// Abstract method: Calculate() → returns decimal
// Normal method: PrintResult() → prints income + tax

// Create children:
// PersonalTax  → tax = Income * 0.1
// BusinessTax  → tax = Income * 0.3

// Create objects, call PrintResult()
using System;

namespace Day07_AbstractInterface{
    
    public interface ICalculatable
    {
        // decimal Calculate();
        void PrintResult();
    }

    public abstract class TaxCalculator : ICalculatable
    {
        public decimal Income;

        public abstract decimal Calculate();
        
         public void PrintResult()
        {
            Console.WriteLine($"Income : {Income}");
            Console.WriteLine($" Tax : {Calculate()}");
        }

    }

    public class PersonalTax : TaxCalculator
    {
        public decimal Amount;

        public PersonalTax(decimal income)
        {
            this.Income = income;
        }

        public override decimal Calculate()
        {
            return Income * 0.1m;
        }
    }

    public class BusinessTax : TaxCalculator
    {
          public decimal Amount;
        public BusinessTax(decimal income)
        {
            this.Income = income;
        }
            public override decimal Calculate()
        {
            return Income * 0.3m;
        }
    }

    public class CalculatorTax
    {
        public static void Run()
        {
          Console.WriteLine("Personal Tax");
            PersonalTax personalTax = new PersonalTax(50000);
            personalTax.Calculate();
            personalTax.PrintResult();

            Console.WriteLine("Business Tax");
            BusinessTax businessTax = new BusinessTax(50000);
            businessTax.Calculate();
            businessTax.PrintResult();
        }
    }
}