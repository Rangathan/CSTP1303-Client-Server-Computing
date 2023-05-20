using Assignment3.Classes;
using System;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus("Merc", 2011, 6, 32, "Large");
            Console.WriteLine(bus1.getInfo());
            Car car1 = new Car("Merc", 2009, 4, 5);
            Console.WriteLine(car1.getInfo());
            Truck truck1 = new Truck("Transcontianel", 1988, 18, 3,"Semi-Truck-40ft container");
            Console.WriteLine(truck1.getInfo());
            Motocycle moto1 = new Motocycle("Suzuki", 2020, 2, 2);
            Console.WriteLine(moto1.getInfo());


        }
    }
}
