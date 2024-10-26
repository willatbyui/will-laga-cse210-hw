using System;
using System.Collections.Generic;

public class Scriptures
{
    private Reference reference;
    private List<Words> words;

    public Scriptures(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Words>();

        foreach (var wordText in text.Split(' '))
        {
            words.Add(new Words(wordText));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.GetRef());
        foreach (var word in words)
        {
            Console.Write(word.HiddenWords ? "__" : word.Text + " ");
        }
        Console.WriteLine();
    }

    public void HideRandom()
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index].Hide();
    }

    public bool AllHidden()
    {
        foreach (var word in words)
        {
            if (!word.HiddenWords)
                return false;
        }
        return true;
    }
}
