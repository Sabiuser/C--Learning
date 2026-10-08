// Create abstract class: Vehicle
// Property: Brand, Speed
// Abstract method: virtual Describe()

// Children: Car, Bike, Truck
// Each overrides Describe() with own message

// Store all in List<Vehicle>
// Loop and call Describe() on each

using System;

namespace DayO8_RunTime
{
    public abstract class Vehicle
    {
        public string Brand;
        public int Speed;

        public Vehicle(string brand,int speed)
        {
            this.Brand = brand;
            this.Speed = speed;
        }

        public abstract void Describe();
    }

    public class Car : Vehicle
    {
        public Car(string brand,int speed) : base(brand, speed)
        {
            
        }
        public override void Describe()
        {
Console.WriteLine($"Car   : {Brand} going at {Speed} km/h");

        }
    }

    public class Bike : Vehicle
    {
        public Bike(string brand,int speed):base(brand,speed){}
        public override void Describe()
        {
     Console.WriteLine($"Bike   : {Brand} going at {Speed} km/h");

        }
    }

    public class Truck : Vehicle
    {
             public Truck(string brand,int speed):base(brand,speed){}
          public override void Describe()
        {
           Console.WriteLine($"Truck   : {Brand} going at {Speed} km/h");

        }
    }

    public class RunTimePolyMorphism
    {
        public static void Run()
        {
            var list = new List<Vehicle>
            {
               new Bike("Royal Enfield",150),
               new Car("Fortuner",200),
               new Truck("Ashok Leyland",300) 
            };

            foreach(var  vehicle in list)
            {
                vehicle.Describe();
            }
        }
    }

   


}