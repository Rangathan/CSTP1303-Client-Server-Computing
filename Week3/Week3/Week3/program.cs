using ClntSrvrWk1.Lessons.Week3.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    internal class program
    {


        static int[] numbers = new int[] { 17, 23, 47 };

        static void Main(string[] args)
        {
            Console.WriteLine("Program was called with");

            var duck1 = new Duck(12, "Tony");
            Console.WriteLine(duck1.GetInfo());

            var rhDuck2 = new RedheadDuck(15, "Phil", "light");
            Console.WriteLine(rhDuck2.GetInfo());

            var test = new InheritanceTest();
            test.Test1();
        }
    }   
}
