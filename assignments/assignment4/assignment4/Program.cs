using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using Assignment4.Classes;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Ford", "Mustang", "GT", "Coupe", "Red", 4,
    vehicle.EngineType.Combustion, 0, "VIN123456", "License123", 2, 0, 250, "Sports Car"); ;
            Console.WriteLine(car.getInfo());
            Bus bus = new Bus("Mercedes-Benz", "Citaro", "G", "Bus", "White", 6,
    vehicle.EngineType.Combustion, 0, "VIN987654", "License789", 2, 0, 80, "Large");
            Truck truck = new Truck("Ford", "F-150", "XL", "Pickup Truck", "Black", 4,
    vehicle.EngineType.Electric, 0, "VIN543210", "License456", 2, 0, 120, "5000 lbs");

            Console.WriteLine(truck.getInfo());
            Motocycle motorcycle = new Motocycle("Honda", "CBR", "600RR", "Sport Bike", "Red", 2,
    vehicle.EngineType.Electric, 0, "VIN987654", "License789", 0, 0, 180, "600cc");

            Console.WriteLine(motorcycle.getInfo());


        }
    }
}
