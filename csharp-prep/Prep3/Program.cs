using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{

    /* Main function */
    static void Main(string[] args)
    {
        Console.WriteLine("Will\'s Prep3");
        UserDecision();
    }

    /* Prompting user to play */

    static void UserDecision()
    {
        Console.WriteLine("Would you like to play a game? (y/n)");
        string response = Console.ReadLine().ToLower();

        if (response == "y")
        {
            StartGame();
        }
        else if (response == "n")
        {
            Console.WriteLine("Suit yourself, have a nice day! ");
        }
        else
        {
            Console.WriteLine("Please enter valid response... ");
            UserDecision();
        }
    }

    /* Begin the game upon user confirmation*/

    static void StartGame()
    {
        Console.WriteLine("Beginning numbers game now...");

        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = 0;
        while (guess != magicNumber)
        {
            Console.WriteLine("Please guess the Magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("That guess was too high, try again. ");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess was too low, try again. ");
            }
            else{
                Console.WriteLine($"Congratulations! You guessed correctly, the number was {magicNumber} ");
            }
        }
    }

}