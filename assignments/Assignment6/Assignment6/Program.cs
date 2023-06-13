using System;
using System.Collections.Generic;

namespace Assignment6
{
    internal class Program
    {

        delegate void DisplayDelegate(List<User> users, Action<User> displayDelegate);
        static void Main(string[] args)
        {
            List<User> users = new List<User>
        {
            new RegularUser { Name = "John Doe", Username = "johndoe", Email = "john@example.com" },
            new RegularUser { Name = "Jane Smith", Username = "janesmith", Email = "jane@example.com" },
            new RegularUser { Name = "Mike Johnson", Username = "mikejohnson", Email = "mike@example.com" },
            new RegularUser { Name = "Emily Davis", Username = "emilydavis", Email = "emily@example.com" },
            new RegularUser { Name = "David Brown", Username = "davidbrown", Email = "david@example.com" },
            new EliteUser { Name = "Sarah Wilson", Username = "sarahwilson", Email = "sarah@example.com" },
            new EliteUser { Name = "Robert Thompson", Username = "robertthompson", Email = "robert@example.com" },
            new EliteUser { Name = "Olivia Clark", Username = "oliviaclark", Email = "olivia@example.com" },
            new EliteUser { Name = "Daniel Young", Username = "danielyoung", Email = "daniel@example.com" },
            new EliteUser { Name = "Sophia Rodriguez", Username = "sophiarodriguez", Email = "sophia@example.com" }
        };
            DisplayDelegate displayFunction = Display;
            displayFunction(users, user =>
            {
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Username: {user.Username}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine();
            });
        }
        private static void Display(List<User> users, Action<User> displayDelegate)
        {
            foreach (User user in users)
            {
                displayDelegate(user);
            }
        }


    }
}
