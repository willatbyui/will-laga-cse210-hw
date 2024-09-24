using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Will\'s Prep4 assignment. ");
        List<int> UserList = UserInput();
        ReturnList(UserList);
    }

    static List<int> UserInput()
    {
        List<int> UserList = new List<int>();
        int input;
        
        int input;
        do
        {
            Console.WriteLine("Enter Numbers here: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                UserList.Add(input);
            }
        } while (input != 0)
        {
            return UserList;
        }
    }
    static void ReturnList(List<int> numbers)
    {
        Console.WriteLine( "Your list contains the following numbers: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

}