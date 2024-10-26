using System;

class Program
{
    static void Main(string[] args)
    {
        /* Create a reference and scripture text */
        Reference reference = new Reference("Philippians", "4", "13");
        string scriptureText = "I can do all things through Christ which strengtheneth me.";

        /* Initialize scripture object */
        Scriptures scripture = new Scriptures(reference, scriptureText);

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

                /* Check if all words are hidden then end program */
                if (scripture.AllHidden())
                {
                    Console.WriteLine(" All words are hidden, nice job. The Program will now end... ");
                    break;
                }
            }
        }
    }
}
