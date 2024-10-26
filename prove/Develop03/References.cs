using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Reference
{

/* private variables */
    private string book;
    private string chapter;
    private string verse;

/* Constructor for single verse */
    public Reference( string book, string chapter, string verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
    }
/*Constructor for multiple verse scriptures */

    public Reference( string book, string chapter, string beginVerse, string endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = $"{beginVerse}-{endVerse}";
    }

    public string GetRef()
    {
        return $"{book} {chapter}: {verse} ";
    }

}