using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        string secretWord = "Gift";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuesses = false;
        while(guess != secretWord && !outOfGuesses )
        {
         if(guessCount < guessLimit)
         {
         Console.Write("Enter a guess: ");
         guess = Console.ReadLine();
         guessCount++;
         }
         else
         {
            outOfGuesses = true;
         }
      
        }
        if(outOfGuesses)
        {
        Console.WriteLine("You are out of guesses");
        }
        else
        {
            Console.WriteLine("You win");
        }



        




    }
}