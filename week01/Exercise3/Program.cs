using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the GUESS THE MAGIC NUMBER GAME");
        Console.WriteLine("There is a hidden magic number from 1 to 11, so guess a number");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int userGuess = 0;
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);
            if(userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            } 
            else
            {
                Console.WriteLine("You guessed it");
            }
              
           
        }
        

    }
}