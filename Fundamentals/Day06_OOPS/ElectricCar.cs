using System;


namespace Fundamentals.Day06_MultiLevelInheritance
{
    public class ElectricCar : Car
    {
        public int BatteryChargeLevel;

        public override void Move()
        {
            Console.WriteLine($"Electric car driving silently at {Speed}");
        }

        public void Charge()
        {
            Console.WriteLine($"Battery Car charging level is : {BatteryChargeLevel}");
        }
    }
}