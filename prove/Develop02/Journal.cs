using System;
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
                switch (choice)
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
                        Console.WriteLine("Please enter valid option [1, etc]");
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
        Console.WriteLine("Would you like a prompt to get started? (y/n) ");
        string selectPrompt = Console.ReadLine()?.ToLower();
        string prompt = string.Empty;

        if (selectPrompt == "y")
        {
            prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
        }
        else
        {
            Console.WriteLine("Okay, continue without a prompt.");
        }

        Console.WriteLine("Write your entry: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Entry newEntry = new Entry(date, prompt, response);
        entries.Add(newEntry);

        Console.WriteLine("Entry added");
    }

    private void DisplayEntry()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries entered.");
            return;
        }
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    private void SaveEntry()
    {
        Console.WriteLine("Please name your save file: ");
        string filename = Console.ReadLine();
        Entry.SaveToFile(entries, filename);
    }

    private void LoadEntry()
    {
        Console.WriteLine("Enter file name to load: ");
        string filename = Console.ReadLine();
        entries = Entry.LoadFromFile(filename);
    }
}
