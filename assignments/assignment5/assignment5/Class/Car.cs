using System;
using System.Collections.Generic;
using System.Text;
using static assignment5.Class.GenericClass;

namespace assignment5.Class
{
    internal class Car
    {
        public Car()
        {
            var carEngine = new Engine();
            var carBody = new Body();
            var car = new Vehicle<VehicleType, Engine, Body>
            {
                Type = VehicleType.Car,
                Engine = carEngine,
                Body = carBody
            };

            
            Console.WriteLine("Created a car.");
        }
    }
}

