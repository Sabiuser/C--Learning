using System;

namespace Fundamentals.Day06_OOPS
{
//     Create Student class with:
// Properties: Name, Age, CGPA, IsStudent
// Constructor: takes all 4 values
// Method: PrintDetails() — prints all properties
// Method: GetGrade() — returns grade based on CGPA
// Create 3 student objects and call both methods
    // public class Student
    // {
    //    public string Name;
    //    public int Age;
    //    public double CGPA;
    //    public bool IsStudent;

    //    public Student(string name,int age,double cgpa,bool isStudent)
    //     {
    //         this.Name = name;
    //         this.Age = age;
    //         this.CGPA = cgpa;
    //         this.IsStudent = isStudent;
    //     } 

    //     public void PrintDetails()
    //     {
    //         Console.WriteLine($"Name : {Name}");
    //         Console.WriteLine($"Age : {Age}");
    //         Console.WriteLine($"CGPA : {CGPA}");
    //         Console.WriteLine($"IsStudent : {IsStudent}");
    //     }

    //     public string GetGrade()
    //     {
    //         return CGPA switch
    //         {
    //              >= 9.0 => "Distinction",
    //             >= 8.0 => "First Class",
    //             >= 6.0 => "Second Class",
    //             >= 5.0 => "Pass",
    //             _      => "Fail"
    //         };
    //     }

    //    public class OOPS
    //     {
    //         public static void Run()
    //         {
    //            Student s1 = new Student("Sabi", 21, 9.0, true);
    //            Student s2 = new Student("Kumar", 22, 7.5, true);
    //            Student s3 = new Student("Raj", 23, 4.5, false);

    //              // Student 1
    //         Console.WriteLine("--- Student 1 ---");
    //         s1.PrintDetails();
    //         Console.WriteLine($"Grade : {s1.GetGrade()}");

    //         // Student 2
    //         Console.WriteLine("--- Student 2 ---");
    //         s2.PrintDetails();
    //         Console.WriteLine($"Grade : {s2.GetGrade()}");

    //         // Student 3
    //         Console.WriteLine("--- Student 3 ---");
    //         s3.PrintDetails();
    //         Console.WriteLine($"Grade : {s3.GetGrade()}");
    //         }
    //     }
    // }


    // ===========================================
    // public class Calculator
    // {
    //     public List<string> History;

    //     public Calculator()
    //     {
    //         History = new List<string>();
    //     }

    //     public double Add(double a,double b)
    //     {
    //         double result = a +b;

    //         History.Add($"{a} + {b} = {result}");
    //         return result;
    //     }

    //     public double Subtract(double a,double b)
    //     {
    //         double result = a -b;

    //         History.Add($"{a} - {b} = {result}");
    //         return result;
    //     }

    //     public double Multiply(double a,double b)
    //     {
    //         double result = a *b;

    //         History.Add($"{a} * {b} = {result}");
    //         return result;
    //     }

    //     public double Divide(double a,double b)
    //     {
    //         double result = a /b;

    //         History.Add($"{a} / {b} = {result}");
    //         return result;
    //     }

    //     public void PrintHistory()
    //     {
    //         foreach (var history in History)
    //         {
    //             Console.WriteLine(history);
    //         }
    //     }

    //     public class OOPS
    //     {
    //         public static void Run()
    //         {
    //             Calculator calc = new Calculator();
    //             double add = calc.Add(20,4);
    //             double sub = calc.Subtract(20,4);
    //             double multiply = calc.Multiply(20,4);
    //             double divide = calc.Divide(20,4);

    //             Console.WriteLine($"Add : {add}");
    //             Console.WriteLine($"Subtract : {sub}");
    //             Console.WriteLine($"Multiply : {multiply}");
    //             Console.WriteLine($"Divide : {divide}");

    //             calc.PrintHistory();
    //         }
    //     }
        
    // }
     
    //  ================================================Create BankAccount class with:
// Properties: AccountHolder, AccountNumber, Balance (private)
// Constructor: takes holder, number, initial balance
// Methods:
//   Deposit(double amount) → adds to balance
//   Withdraw(double amount) → deducts from balance
//   PrintStatement() → prints all details

// Create 2 accounts, do deposits and withdrawals

    public class BankAccount
    {
        public string AccountHolder;
        public int AccountNumber;
        private double _balance;

        public BankAccount(string holder,int number,double currentBalance)
        {
            this.AccountHolder = holder;
            this.AccountNumber = number;
            this._balance = currentBalance;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                _balance+=amount;
            }
            else
            {
                Console.WriteLine($"Insufficient Balance : {amount}");
            }
        }

        public void Withdraw(double amount)
        {
            if(amount > _balance)
            {
                Console.WriteLine($"Insufficient Amount : {amount}");
            }
            else
            {
                _balance-=amount;
            }
        }

        public void PrintStatement()
        {
            Console.WriteLine($"Account Holder : {AccountHolder}");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Balance        : {_balance}");
        }

        
    }
    public class OOPS
        {
            public static void Run()
            {
                
                BankAccount bankAccount = new BankAccount("Sabi",34567896,900);
                bankAccount.Deposit(100);
                bankAccount.Withdraw(500);
                bankAccount.PrintStatement();

                BankAccount bank = new BankAccount("Ravi",456789,100);
                bank.Deposit(2);
                bank.Withdraw(900);
                bank.PrintStatement();
            }
        }
    

    
}