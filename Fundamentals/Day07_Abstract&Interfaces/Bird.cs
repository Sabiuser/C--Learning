using System;

// =========Task 2================
// Create interfaces:
// ISwimmable → Swim()
// IFlyable   → Fly()
// IRunnable  → Run()

// Create classes:
// Duck    → implements ISwimmable, IFlyable
// Horse   → implements IRunnable
// Penguin → implements ISwimmable, IRunnable

// Create objects, call all methods

namespace Day07_Interfaces
{
    public interface ISwimmable
    {
        void Swim();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface IRunnable
    {
        void Run();
    }

    public class Duck : ISwimmable, IFlyable
    {
        public void Swim()
        {
            Console.WriteLine("Duck is Swimming ...");
        }

        public void Fly()
        {
            Console.WriteLine("Duck is Flying...");
        }
    }

    public class Horse : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Horse is running....");
        }
    }

    public class Penguin : ISwimmable, IRunnable
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is Swimming...");
        }

        public void Run()
        {
            Console.WriteLine("Penguin is Running");
        }
    }

    public class BirdTask
    {
        public static void Run()
        {
            Duck duck = new Duck();
            duck.Fly();
            duck.Swim();

            Horse horse = new Horse();
            horse.Run();

            Penguin penguin = new Penguin();
            penguin.Run();
            penguin.Swim();
        }
    }
}