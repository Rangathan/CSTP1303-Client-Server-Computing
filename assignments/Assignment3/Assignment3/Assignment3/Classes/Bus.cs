using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Classes
{
    internal class Bus : vehicle
    {
        private string busSize;
        public Bus(string name, int year, int wheels, int AmountofPas, string busSize) : base(name, year, wheels, AmountofPas)
        {
            this.busSize = busSize;
        }
        public override string getInfo()
        {
            return base.getInfo() + $" + {this.busSize}";
        }

    }
    
}
