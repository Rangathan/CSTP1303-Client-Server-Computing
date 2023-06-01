using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;
using static Assignment4.Classes.vehicle;

namespace Assignment4.Classes
{
    internal class Motocycle : vehicle
    {
        private string engineSize;
        public Motocycle(string brand, string make, string model, string bodyType, string color,
            int numberOfWheels, EngineType engineType, double dashboardMileage, string vin,
            string licenseNumber, int numberOfDoors, double speed, double maxSpeed, string engineSize) : 
            base(brand, make, model, bodyType, color, numberOfWheels, engineType, dashboardMileage, vin, licenseNumber, numberOfDoors, speed, maxSpeed)
        {
            this.engineSize = engineSize;
        }

        public override string getInfo()
        {
            return base.getInfo() + $"\nEngine Size:{this.engineSize}\n";
        }
    }
}
