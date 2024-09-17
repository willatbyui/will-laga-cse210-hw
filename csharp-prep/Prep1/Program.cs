using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Will Laga\'s W01 Prove- Prep1");
        Console.Write(" What is your first name? ");
        string FirstName = Console.ReadLine();

        Console.Write(" What is your last name? ");
        string LastName = Console.ReadLine();

        Console.WriteLine($" Your name is {LastName}, {FirstName} {LastName}");
    }
}