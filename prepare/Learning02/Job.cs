using System;
using System.IO.Compression;
using System.Data;


/* Keep track of company, job title, start, and end year. */

public class Job
{
    /* Declaration of members */
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


/* Displays job information in specified format */
    public void Display()
    {
        Console.WriteLine($"{_jobTitle}, ({_company}). {_startYear}-{_endYear}.\n");
    }
}
