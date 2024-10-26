using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ScriptureRepo repository = new ScriptureRepo();
        
        Random random = new Random();
        List<string> keys = new List<string>(repository.GetAllKeys());
        string randomKey = keys[random.Next(keys.Count)];

        var (reference, text) = repository.GetScripture(randomKey);

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
