using System;
// Create Parent: Animal
// Properties: Name, Age
// Constructor: takes name, age
// Method: virtual MakeSound() → prints "Some sound"
// Method: PrintDetails() → prints name, age

// Create Children: Dog, Cat, Bird
// Each has:
// → Constructor calling base
// → Override MakeSound() with own sound
// → One extra property each
//    Dog  → Breed
//    Cat  → Color
//    Bird → CanFly (bool)

// Create one object of each, call PrintDetails + MakeSound
namespace Fundamentals.Day06_Inheritance
{
    public class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"{Name} makes sound!....");
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
        }
    }

    public class Dog : Animal
    {
        public string Breed;
        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.Breed = breed;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} says: Woof! Woof!");
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Breed : {Breed}");
        }
    }

    public class Cat : Animal
    {
        public string Color;

        public Cat(string name, int age, string color) : base(name, age)
        {
            this.Color = color;
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} says: Meow! Meow!");
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Color : {Color}");
        }
    }

    public class Bird : Animal
    {
        public bool IsFly;

        public Bird(string name, int age, bool isFly) : base(name, age)
        {
            this.IsFly = isFly;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name} says: Tweet! Tweet!");
        }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Can Fly : {IsFly}");
        }
    }

    public class Inheritance
    {
        public static void Run()
        {
            Console.WriteLine("===Animal=====");
            Animal obj = new Animal("Wild Animals", 23);
            obj.Sound();
            obj.PrintDetails();

            Console.WriteLine("===Dog=====");
            Dog dog = new Dog("Rajapalayam", 6, "Nattunai");
            dog.Sound();
            dog.PrintDetails();

            Console.WriteLine("===Cat=====");
            Cat cat = new Cat("Sekar", 3, "White");
            cat.Sound();
            cat.PrintDetails();

            Console.WriteLine("===Bird=====");
            Bird bird = new Bird("Eagle", 3, true);
            bird.Sound();
            bird.PrintDetails();

        }

    }
}