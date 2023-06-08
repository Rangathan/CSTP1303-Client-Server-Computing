using System;
using System.Collections.Generic;
using System.Text;
using static assignment5.Class.GenericClass;

namespace assignment5.Class
{
    internal class Bus
    {
        public Bus(string engineType, string bodyType)
        {
            var busEngine = new Engine();
            var busBody = new Body();
            var bus = new Vehicle<VehicleType, Engine, Body>
            {
                Type = VehicleType.Bus,
                Engine = busEngine,
                Body = busBody
            };

            
            Console.WriteLine($"Created a {engineType} bus with a {bodyType} body.");
        }
    }
}
