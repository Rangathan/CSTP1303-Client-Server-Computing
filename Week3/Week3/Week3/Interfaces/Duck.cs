using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.Interfaces
{
    public class Duck
    {
        protected int id;
        protected string name;
        protected int age;

        public Duck(int id, string name)
        {
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
    }
}
