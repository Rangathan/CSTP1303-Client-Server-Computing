using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.Inheritance
{
    public class Duck
    {
        private int id;
        private string name;
        protected int age;

        public Duck(int id, string name)
        {
            if(id <= 0)
            {
                throw new ArgumentOutOfRangeException("id should be greater than zero", nameof(id));
            }
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "name cannot not be null");
            }
            this.id = id;
            this.name = name;
        }

        public int GetId()
        {
            return id;
        }

        public string GetInfo()
        {
            return $"duck: {name} - {id}";
        }

        public virtual void Fly()
        {
            Console.WriteLine($"{this.id} - {this.name} flying ...");
        }
    }
}
