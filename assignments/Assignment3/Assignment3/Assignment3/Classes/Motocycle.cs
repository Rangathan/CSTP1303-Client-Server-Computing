using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Classes
{
    internal class Motocycle : vehicle
    {
        private string engineSize;

       

        public Motocycle(string name, int year, int wheels, int AmountofPas, string engineSize) : base(name, year, wheels, AmountofPas)
        {
            this.engineSize = engineSize;
        }

        public override string getInfo()
        {
            return base.getInfo() + $" Engine Size:{this.engineSize}";
        }
    }
}
