using assignment5.Class;
using assignment5.lab4genericstack;
using System;
using System.Xml.Linq;
using static assignment5.Class.GenericClass;

namespace assignment5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            

            
            var bus1 = new Bus("diesel", "large");
            var motorcycle1 = new Motorcycle();
            var truck1 = new Truck();
            var car1 = new Car();


            MyStack<int> stack = new MyStack<int>();
            stack.Push(5);
            stack.Push(10);
            int topElement = stack.Pop();
            Console.WriteLine(topElement);

        }
    }
}
