using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }

    public static void SaveToFile(List<Entry> entries, string filename)
    {
        List<string> lines = new List<string>();
        foreach (var entry in entries)
        {
            lines.Add(entry.ToString());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved.");
    }

    public static List<Entry> LoadFromFile(string filename)
    {
        List<Entry> entries = new List<Entry>();

        if (!File.Exists(filename))
        {
            Console.WriteLine("Uh oh, file not found.");
            return entries;
        }

        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[0].Trim(), parts[1].Trim(), parts[2].Trim()));
            }
        }
        Console.WriteLine("Entries loaded successfully.");
        return entries;
    }
}
