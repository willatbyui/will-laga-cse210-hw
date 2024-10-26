using System;

class Program
{
    static void Main(string[] args)
    {
        /* Create a repository for scriptures */
        ScriptureRepo repository = new ScriptureRepo();

        /* Get the scripture */
        var (reference, scriptureText) = repository.GetScripture("Philippians 4:13"); 

        if (reference == null)
        {
            Console.WriteLine("Scripture not found.");
            return;
        }

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
