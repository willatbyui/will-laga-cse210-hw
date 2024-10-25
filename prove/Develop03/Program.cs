using System;
using System.Collections.Generic;


class Program
{
        static void Main(string[] args)
        {
        /* Initialize scripture object */
                Scriptures scripture = new Scriptures();

                Console.WriteLine(" Welcome to Will\'s scripture memorizing program. ");
                Console.WriteLine("Press the enter key to start or type 'quit' to exit the program. ");

                while (true)
                {
                        string input = Console.ReadLine();
                        
                        if (input == "quit")
                        {
                                break;
                        }
                        if (input == "")
                        {
                        /* Hide random word then display the scripture */
                                scripture.HideRandom();
                                scripture.Display();

                        /* check if all words are hidden then end program */
                                if (scripture.AllHidden())
                                {
                                        Console.WriteLine(" All words are hidden, nice job. The Program will now end... ");
                                        break;
                                }
                        }
                }

        }
}