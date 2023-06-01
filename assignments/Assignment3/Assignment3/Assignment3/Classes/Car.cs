using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Classes
{
    internal class Car : vehicle
    {
        private String carType;

       

        public Car(string name, int year, int wheels, int AmountofPas, string carType) : base(name, year, wheels, AmountofPas)
        {
            this.carType = carType;
        }

        public override string getInfo()
        {
            return base.getInfo() + $" Car Type:{this.carType}";
        }
    }
}
