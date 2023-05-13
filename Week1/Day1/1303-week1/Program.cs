using System;

namespace _1303_week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program was called with");
            Console.WriteLine("Adam lab 1 git submit");
            for (int i =0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Program program = new Program();
            program.PrintNumbers();
            int inches = program.FeetToInches(3);
            Console.WriteLine($"3 feet is : {inches} inches.");
            string message = "This is our first message";
            var message2 = "new message";

            var a = 5;
            var arr = new int[] { 1, 2, 3 };
            bool isThisGood = true;

            var p1 = new Point();
            p1.x = 10;
            p1.y = 12;
            program.Print(p1, "after assignmnet");

            int b = 20;
            b = a;

            Point p2 = p1;
            program.Print(p2, "after assignmnet");
            Point p3 = new Point();
            
            p3.x =23;
            p3.y =64;
            
            program.Print(p3, "before assignmnet");
            p3 =p1;
            program.Print(p3, "after assignmnet");
            
            Point p4 =new Point();
            
            p4 = null;
            program.Print(p4, "after assignmnet");
            program.TestReadLine();
        }
        
        public void  Print(Point p, string message)
        {
          if (p == null)
            {
                Console.WriteLine("p is null");
                return;
            }
         Cosnole.WriteLine($"{message}: x:{p.x}, y:{p.y}");
        }
        
        public void PrintNumbers() 
        {
            Console.WriteLine("this is a test");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(" ");
                Console.Write(i);
            }

            Console.WriteLine(" end of loop");
        }
        public int FeetToInches(int feet) 
        {
            int inches = feet * 12;
             return inches;
        }
    }
}
