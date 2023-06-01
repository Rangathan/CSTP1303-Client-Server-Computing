using System;
using System.Collections.Generic;
using System.Text;



namespace Assignment4.Classes
{
    
    internal class vehicle
    {
        private readonly string brand;
        private readonly string make;
        private readonly string model;
        private readonly string bodyType;
        private readonly string color;
        private readonly int numberOfWheels;
        private readonly EngineType engineType;
        private readonly double dashboardMileage;
        private readonly string vin;
        private readonly string licenseNumber;
        private readonly int numberOfDoors;
        private readonly double speed;
        private readonly double maxSpeed;

        public enum EngineType
        {
            Combustion,
            Electric
        }

        public vehicle(string brand, string make, string model, string bodyType, string color,
            int numberOfWheels, EngineType engineType, double dashboardMileage, string vin,
            string licenseNumber, int numberOfDoors, double speed, double maxSpeed)
        {
            this.brand = brand;
            this.make = make;
            this.model = model;
            this.bodyType = bodyType;
            this.color = color;
            this.numberOfWheels = numberOfWheels;
            this.engineType = engineType;
            this.dashboardMileage = dashboardMileage;
            this.vin = vin;
            this.licenseNumber = licenseNumber;
            this.numberOfDoors = numberOfDoors;
            this.speed = speed;
            this.maxSpeed = maxSpeed;
        }
    
        
        public string getBrand()
        {
            return brand;
        }
        public virtual string getInfo()
        {
            return $"Brand: {this.brand}\n" +
               $"Make: {this.make}\n" +
               $"Model: {this.model}\n" +
               $"Body Type: {this.bodyType}\n" +
               $"Color: {this.color}\n" +
               $"Number of Wheels: {this.numberOfWheels}\n" +
               $"Engine Type: {this.engineType}\n" +
               $"Dashboard Mileage: {this.dashboardMileage}\n" +
               $"VIN: {this.vin}\n" +
               $"License Number: {this.licenseNumber}\n" +
               $"Number of Doors: {this.numberOfDoors}\n" +
               $"Speed: {this.speed}\n" +
               $"Maximum Speed: {this.maxSpeed}";
        }
    }
}
