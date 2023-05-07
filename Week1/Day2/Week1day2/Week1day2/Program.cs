using System;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.TestReadLine();

    }
    public void TestReadLine()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Enter one or more lines -press CRL+Z to exit: ");

        string line;

        do
        {
            Console.Write("===>");
            line = Console.ReadLine();
            if (line != null)
            {
                Console.WriteLine($" {line} ");
            }
        } while (line != null);

    }
}