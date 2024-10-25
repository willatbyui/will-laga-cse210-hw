using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
/* Welcome message, menu selections display */
        Console.WriteLine("Welcome to the scripture memorization program, developed by Will");

        Console.WriteLine("Press the enter key to start the sequence or type 'quit' to close the program... ");
/* create a loop that starts program if enter is pressed and exit upon typing quit */
        string input = Console.ReadLine();
        bool runScripture = input != "quit";

/* if statement to run method */
        if (runScripture)
        {
                Scriptures.DisplayScriptures();
                while (Scriptures.HideWords())
                {
                        input = Console.ReadLine();
                        if (input == "quit")
                        {
                                break;
                        }
                }
        }

    }

}