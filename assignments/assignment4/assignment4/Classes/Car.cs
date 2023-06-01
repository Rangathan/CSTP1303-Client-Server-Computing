using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Classes
{
    internal class Car : vehicle
    {
        private string carType;

        

        public Car(string brand, string make, string model, string bodyType, string color,
            int numberOfWheels, EngineType engineType, double dashboardMileage, string vin,
            string licenseNumber, int numberOfDoors, double speed, double maxSpeed, string cartype) : 
            base(brand, make, model, bodyType, color, numberOfWheels, engineType, dashboardMileage, vin, licenseNumber, numberOfDoors, speed, maxSpeed)
        {     
            this.carType = cartype;
        }

     

        public override string getInfo()
        {
            return base.getInfo() + $"\nCar Type:{this.carType}\n";
        }
    }
}
