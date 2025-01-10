using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int>numbers = new List<int>();
        int userNumber = -1;
        while(userNumber != 0) 
        {
        Console.Write("Enter a number: ");
        string userRespond = Console.ReadLine();
        userNumber = int.Parse(userRespond);
        if(userNumber != 0)
        {
        numbers.Add(userNumber);
        }

       }
       int sum = 0;
       foreach(int number in numbers)
       {
        sum += number;
       }
       Console.WriteLine($"The sum is {sum}");
       int numberCount = numbers.Count;
       float average = ((float)sum) / numberCount;
       Console.WriteLine($"The average number is {average}");
       int max = numbers[0];
       foreach(int number in numbers)
       {
        if (number > max)
        {
            max = number;
        }
       }
       Console.WriteLine($"The maximum number is {max}");
    }
}