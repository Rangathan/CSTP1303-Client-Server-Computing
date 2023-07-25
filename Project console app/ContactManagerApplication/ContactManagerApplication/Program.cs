using Models;
using System;

namespace ContactManagerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int choice;
            Program program = new Program();
            do
            {
                Console.WriteLine("Welcome to Contact Manager Service");
                Console.WriteLine("__________________________________");
                Console.WriteLine("Please Choose an option:\n1) Create a new Contact\n2) Search for a Contact\n3) Save and Load from Disk" +
                    "\n4) Save and Load from Server\n5) Quit Application");
                Console.WriteLine("__________________________________");
                string input = Console.ReadLine();

                int.TryParse(input, out choice);
                switch (choice)
                {
                    case 1:
                        program.createContact();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            }
            while (choice != 5);
        }

        public void createContact()
        {
           
            int choice;
            do
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Choose an option for Contact Creation");
                Console.WriteLine("1) Company with no Contacts\n2) Company with Titles\n3) Company\n4) An individual\n5) Quit");
                Console.WriteLine("_____________________________________");
                string input = Console.ReadLine();
                int.TryParse(input, out choice);
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            while (choice != 5);
        }
       

            
        
    }
}
