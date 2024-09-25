using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Will\'s Prep5 assignment");

        DisplayWelcome();

        string userName = PromptUserName();
        int favNum = PromptUserNum();
        int favSquared = SquareNum(favNum);
        DisplayResult(userName, favSquared);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program. ");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNum()
    {
        Console.WriteLine("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNum(int number)
    {
        return number * number;
    }
    static void DisplayResult(string userName, int favSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {favSquared}. ");
    }

}