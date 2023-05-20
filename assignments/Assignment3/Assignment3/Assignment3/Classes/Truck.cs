using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment3.Classes
{
    internal class Truck : vehicle
    {
        private String cargoCapacity;
        public Truck(string name, int year, int wheels, int AmountofPas, string cargoCapacity) : base(name, year, wheels, AmountofPas)
        {
            this.cargoCapacity = cargoCapacity;
        }

        public override string getInfo()
        {
            return base.getInfo() + $" Cargo Capacity:{this.cargoCapacity}";
        }
    }
}
