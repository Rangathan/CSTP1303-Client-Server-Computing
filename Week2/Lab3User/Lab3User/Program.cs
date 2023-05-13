using System;

namespace Lab3User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userArray = new User[10];

                for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = new User()
                {
                    Id = i + 1,
                    Name = "Placeholder" + (i+1),
                };
                
            }
                Program program = new Program();
            program.PrintUserArray(userArray);

        }

        private void PrintUserArray(User[] user)
        {
            for (int i = 0;i < user.Length;i++)
            {
                Console.WriteLine($"Name: {user[i].Name} \nId: {user[i].Id} \n");
            }
        }
    }
    
}
