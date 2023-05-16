using System;
using System.Xml.Serialization;

namespace assignment2
{
    internal class Program
    {
        private static user[] userArray = new user[100];

        static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.WriteLine("1. Option 1 - Add User");
                Console.WriteLine("2. Option 2 - Show user By ID");
                Console.WriteLine("3. Option 3 - Show User By Name");
                Console.WriteLine("4. Option 4 - Delete User By Id");
                Console.WriteLine("5. Option 5 - Delete user by Name");
                Console.WriteLine("6. Option 6 - Show all users");
                Console.WriteLine("7. Option 7 - Exit program");


                Program program = new Program();

                choice = program.GetUserChoice();
                switch (choice)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        ShowUserById();
                        break;
                    case 3:
                        ShowUserByName();
                        break;
                    case 4:
                        DeleteUserById();
                        break;
                    case 5:
                        DeleteUserByName();
                        break;

                    case 6:
                        ShowAllUsers();
                        break;

                    case 7:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 7);

        }

        public int GetUserChoice()
        {

            string line;
            int choice;
            do
            {

                Console.WriteLine(" Please choose an option between 1 and 7.");
                line = Console.ReadLine();

            } while (!int.TryParse(line, out choice) || choice < 1 || choice > 10);

            return choice;
        }

        public static void AddUser()
        {
            Console.WriteLine("Enter user ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter user name:");
            string name = Console.ReadLine();

            user newUser = new user { Id = id, Name = name };

            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] == null)
                {
                    userArray[i] = newUser;
                    Console.WriteLine("User added successfully.");
                    return;
                }
            }

            Console.WriteLine("User array is full. Cannot add more users.");
        }

        public static void ShowUserById()
        {
            Console.WriteLine("Enter user ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (user u in userArray)
            {
                if (u != null && u.Id == id)
                {
                    Console.WriteLine($"User ID: {u.Id}, Name: {u.Name}");
                    return;
                }
            }

            Console.WriteLine("User not found with the given ID.");
        }

        public static void ShowUserByName()
        {
            Console.WriteLine("Enter user name:");
            string name = Console.ReadLine();

            foreach (user u in userArray)
            {
                if (u != null && u.Name.Equals(name))
                {
                    Console.WriteLine($"User ID: {u.Id}, Name: {u.Name}");
                    return;
                }
            }

            Console.WriteLine("User not found with the given name.");
        }

        public static void DeleteUserById()
        {
            Console.WriteLine("Enter user ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] != null && userArray[i].Id == id)
                {
                    userArray[i] = null;
                    Console.WriteLine("User deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("User not found with the given ID.");
        }
        public static void DeleteUserByName()
        {
            Console.WriteLine("Enter user Name:");
            String name = Console.ReadLine();

            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] != null && userArray[i].Name == name)
                {
                    userArray[i] = null;
                    Console.WriteLine("User deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("User not found with the given Name.");
        }

        public static void ShowAllUsers()
        {
            Console.WriteLine("All Users:");
            foreach (user u in userArray)
            {
                if (u != null)
                {
                    Console.WriteLine($"User ID: {u.Id}, Name: {u.Name}");
                }

            }
        }
    }
}

