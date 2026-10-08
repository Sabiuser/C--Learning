using System;

namespace Fundamentals.Day06_MultiLevelInheritance
{
    public class Vehicle
    {
        public string Brand;
        public int Speed;

        public virtual void Move()
        {
            Console.WriteLine("Vehicle is Moving....");
        }
    }
}