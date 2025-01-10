using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int num = int.Parse(userNumber);
        return num;
    }
    static int SquareNumber(int numToSquare)
    {
        return numToSquare * numToSquare;
    }
    static void DisplayResult(string name, int square)
    {
       Console.WriteLine($"{name}, the square of your number is {square}");
    }




}