using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (true)
        {
            Console.Clear();
            
            
            Console.WriteLine(scripture.GetDisplayText());

        
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words have been hidden. Well done!");
                break;
            }

        
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            
            scripture.HideRandomWords(3); 
        }
    }
}