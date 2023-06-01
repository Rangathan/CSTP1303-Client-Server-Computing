using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Classes
{
    internal class Bus : vehicle
    {
        private string busSize;
        public Bus(string brand, string make, string model, string bodyType, string color,
            int numberOfWheels, EngineType engineType, double dashboardMileage, string vin,
            string licenseNumber, int numberOfDoors, double speed, double maxSpeed, string busSize) :
            base(brand, make, model, bodyType, color, numberOfWheels, engineType, dashboardMileage, vin, licenseNumber, numberOfDoors, speed, maxSpeed)
        {
            this.busSize = busSize;
        }
        public override string getInfo()
        {
            return base.getInfo() + $"\nBus Size: {this.busSize} \n";
        }

    }
    
}
