using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Will Laga\'s Prep2 Assignment");

        Console.Write(" What is your grade percentage? ");
        string UserPercent = Console.ReadLine();
         int x = int.Parse(UserPercent);
         
         
         string grade = "";

        if ( x >= 90)
        {
            grade = "A";
        }
        else if( x >= 80 && x < 90)
        {
            grade = "B";
        }
        else if( x >= 70 && x < 80)
        {
            grade = "C";
        }
        else if( x>=60 && x < 70)
        {
            grade = "D";
        }
        else
        {
            grade ="F";
        }

        Console.WriteLine($"Your grade is an: {grade}");

        if (x >= 70)
        {
            Console.Write("You got a passing grade! Nice... ");
        }
        else
        {
            Console.Write("You failed! Try better next time. ");
        }
    }
}