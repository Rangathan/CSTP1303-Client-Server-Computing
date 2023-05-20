using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Classes
{
    internal class Car
    {
        private string name;
        private int year;
        private int wheels;
        private int AmountofPas;

        public Car(string name, int year, int wheels, int AmountofPas)
        {
            this.name = name;
            this.year = year;
            this.wheels = wheels;
            this.AmountofPas = AmountofPas;

        }
        public int getYear()
        {
            return year;
        }
        public string getName()
        {
            return name;
        }
        public virtual string getInfo()
        {
            return $"{this.name} - {this.year} - amount of wheels: {this.wheels}, amount of passengers: {this.AmountofPas}";
        }
    }
}
