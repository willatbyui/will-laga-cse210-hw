using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Will\'s Prep4 assignment");
        List<int> UserList = UserInput();
        ReturnList(UserList);

        /* displaying results of each function on the console */
        int sum = FindSum(UserList);
        Console.WriteLine($"The sum of your numbers is : {sum}. ");

        decimal average = ComputeAvg(UserList);
        Console.WriteLine($"n\ The average of your numbers is: {average}. ");

        int max = MaxNum(UserList);
        Console.WriteLine($"The largest number is: {max}. ");
    }

    /* Beginning assignment */
    static List<int> UserInput()
    {
        List<int>UserList = new List<int>();
        int input;
        do
        {
            Console.WriteLine("Enter numbers here: ");
            input = int.Parse(Console.ReadLine());
            
            if (input != 0)
            {
                UserList.Add(input);
            }
        }while (input != 0);
        return UserList;
    }

    static void ReturnList(List<int> numbers)
    {
        Console.WriteLine(" Your list contains the following: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    /* Core requirement 1 summation of numbers */
    static int  FindSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;

    }

    /* Core Requirement 2 averaging numbers */
    static decimal ComputeAvg (List<int> numbers)
    {
        if (numbers.Count == 0)
            return 0;
        decimal sum = FindSum(numbers);
        return sum / numbers.Count;

    }

    /* Core requirement 3 largest number */
    static int MaxNum(List<int> numbers)
    {
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }


}