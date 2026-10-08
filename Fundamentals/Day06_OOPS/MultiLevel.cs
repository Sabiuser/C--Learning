using System;


namespace Fundamentals.Day06_MultiLevelInheritance
{
    public class VehicleMultiLevel
    {
        public static void Run()
        {
            Console.WriteLine("/n =====Vehicle======");
            Vehicle vehicle = new Vehicle();
            vehicle.Move();
            Console.WriteLine("/n =====Car======");
            Car car = new Car();
            car.Brand = "Fortuner";
            car.Speed = 230;
            car.NumberOfDoors = 4;
            car.Move();
            car.noOfDoors();
            Console.WriteLine("/n =====ElectricCar======");
            ElectricCar electricCar = new ElectricCar();
            electricCar.Brand = "MG Comet";
            electricCar.NumberOfDoors = 2;
            electricCar.Speed = 20;
            electricCar.BatteryChargeLevel = 250;
            electricCar.Move();
            electricCar.Charge();
        }
    }
}