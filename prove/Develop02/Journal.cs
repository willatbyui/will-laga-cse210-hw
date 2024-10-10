using System.Data;
using System.Collections.Generic;


class Journal
{


    private List<Entry> entries = new List<Entry>();
    private PromptGenerator promptGenerator = new PromptGenerator();
    


/* Menu */
    public void StartMenu()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please choose a Menu option: ");
            Console.WriteLine("1. New Entry ");
            Console.WriteLine("2. Open Journal ");
            Console.WriteLine("3. Save Entry ");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit Program ");
/* Parsing input int */
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
/* Switch case option menu */
                switch(choice)
                {
                    case 1:
                        NewEntry();
                        break;
                    
                    case 2:
                        DisplayEntry();
                        break;
                    case 3:
                        SaveEntry();
                        break;
                    case 4:
                        LoadEntry();
                        break;
                    case 5:
                        running = false;
                        break;

/* Error checking / validation */
                    default:
                        Console.WriteLine(" Please enter valid option [1, etc] ");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please enter valid input ");
            }
        }
    }




    private void NewEntry()
    {

    }
    private void DisplayEntry()
    {

    }
    private void SaveEntry()
    {

    }
    private void LoadEntry()
    {
        
    }












}