using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
/* Welcome message, menu selections display */
        Console.WriteLine("Welcome to the scripture memorization program, developed by Will");

        Console.WriteLine("Please select a scripture to practice: ");
        Console.WriteLine("1. Proverbs 3: 5-6.");
        Console.WriteLine("2. Philippians 4:13. ");
        Console.WriteLine("3. Alma 7:11-12. ");
        Console.WriteLine("Enter 'quit' to exit the program. ");
/* read user input */
        string input = Console.ReadLine();

/* detect input and set lowercase */
        if (input.ToLower() == "quit")
        {
            return;
        }

/* Check inputs (1-3, Exit) */
        Scriptures scripture;
        if (input == "1")
        {

        }

        else if (input =="2")
        {

        }
        else if (input == "3")
        {

        }

/* Close program if menu selection is invalild */
        else
        {
            Console.WriteLine("Invalid selection. Closing program now. ");
            return;
        }

    }
}