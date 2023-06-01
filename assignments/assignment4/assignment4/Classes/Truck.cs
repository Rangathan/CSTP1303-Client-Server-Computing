using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment4.Classes
{
    internal class Truck : vehicle
    {
        private String cargoCapacity;
        public Truck(string brand, string make, string model, string bodyType, string color,
            int numberOfWheels, EngineType engineType, double dashboardMileage, string vin,
            string licenseNumber, int numberOfDoors, double speed, double maxSpeed, string cargoCapacity) : 
            base(brand, make,model,bodyType,color, numberOfWheels,engineType, dashboardMileage, vin,licenseNumber,numberOfDoors,speed,maxSpeed)
        {
            this.cargoCapacity = cargoCapacity;
        }

        public override string getInfo()
        {
            return base.getInfo() + $"\nCargo Capacity:{this.cargoCapacity}\n";
        }
    }
}
