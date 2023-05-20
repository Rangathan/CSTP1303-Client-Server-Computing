using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Classes
{
    internal class Bus : Car
    {
        private string size;
        public Bus(string name, int year, int wheels, int AmountofPas, string size) : base(name, year, wheels, AmountofPas)
        {
            this.size = size;
        }
        public override string getInfo()
        {
            return base.getInfo() + $" + {this.size}";
        }

    }
    
}
