using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Option 1 - Americano");
            Console.WriteLine("2. Option 2 - Cappuccino");
            Console.WriteLine("3. Option 3 - Latte");
            Console.WriteLine("4. Option 4 - Espresso");
            Console.WriteLine("5. Option 5 - Mocha");
            Console.WriteLine("6. Option 6 - Macchiato");
            Console.WriteLine("7. Option 7 - Flat White");
            Console.WriteLine("8. Option 8 - Iced Coffee");
            Console.WriteLine("9. Option 9 - Frappuccino");
            Console.WriteLine("10. Option 10 - Irish Coffee");


            Program program = new Program();

            int choice = program.GetUserChoice();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Option 1 - Americano");
                    break;
                case 2:
                    Console.WriteLine("Option 2 -Cappuccino");
                    break;
                case 3:
                    Console.WriteLine("Option 3 - Latte");
                    break;
                case 4:
                    Console.WriteLine("Option 4  - Espresso");
                    break;
                case 5:
                    Console.WriteLine("Option 5 - Mocha");
                    break;
                case 6:
                    Console.WriteLine("Option 6 - Macchiato");
                    break;
                case 7:
                    Console.WriteLine("Option 7 - Flat White");
                    break;
                case 8:
                    Console.WriteLine("Option 8 - Iced Coffee");
                    break;
                case 9:
                    Console.WriteLine("Option 9 - Frappuccino");
                    break;
                case 10:
                    Console.WriteLine("Option 10 - Irish Coffee");
                    break;
                default:

                    break;
            }

        }

        public int GetUserChoice()
        {

            string line;
            int choice;
            do
            {

                Console.WriteLine(" Please choose an option between 1 and 10.");
                line = Console.ReadLine();

            } while (!int.TryParse(line, out choice) || choice < 1 || choice > 10);

            return choice;
        }

    }

}
