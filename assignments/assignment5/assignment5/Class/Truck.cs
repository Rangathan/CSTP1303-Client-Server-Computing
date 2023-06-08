using System;
using System.Collections.Generic;
using System.Text;
using static assignment5.Class.GenericClass;

namespace assignment5.Class
{
    internal class Truck
    {
        public Truck()
        {
            var truckEngine = new Engine();
            var truckBody = new Body();
            var truck = new Vehicle<VehicleType, Engine, Body>
            {
                Type = VehicleType.Truck,
                Engine = truckEngine,
                Body = truckBody
            };

            Console.WriteLine("Created a truck.");
        }
    }
}
