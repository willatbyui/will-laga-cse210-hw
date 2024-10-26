using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the ScripturesRepository
        ScriptureRepo repository = new ScriptureRepo();
        
        // Get a random scripture from the repository
        Random random = new Random();
        List<string> keys = new List<string>(repository.GetAllKeys());
        string randomKey = keys[random.Next(keys.Count)];

        // Retrieve the reference and text for the random scripture
        var (reference, text) = repository.GetScripture(randomKey);

        // Initialize Scriptures object with the random scripture
        Scriptures scripture = new Scriptures(reference, text);

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
