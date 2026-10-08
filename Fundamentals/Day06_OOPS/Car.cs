using System;

namespace Fundamentals.Day06_MultiLevelInheritance
{
    public class Car : Vehicle
    {
        public int NumberOfDoors;

        public override void Move()
        {
            Console.WriteLine($"Car is moving at {Speed}...");
        }

        public void noOfDoors()
        {
            Console.WriteLine($"In car there are {NumberOfDoors} of doors...");
        }
    }
}