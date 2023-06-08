using System;
using System.Collections.Generic;
using System.Text;
using static assignment5.Class.GenericClass;

namespace assignment5.Class
{
    internal class Motorcycle
    {
        public Motorcycle()
        {
            var motorcycleEngine = new Engine();
            var motorcycleBody = new Body();
            var motorcycle = new Vehicle<VehicleType, Engine, Body>
            {
                Type = VehicleType.Motorcycle,
                Engine = motorcycleEngine,
                Body = motorcycleBody
            };

            Console.WriteLine("Created a motorcycle.");
        }
    }
}

