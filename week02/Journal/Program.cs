using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            Entry newEntry = new Entry(date, prompt, response);
            journal.AddEntry(newEntry);

            }
            else if(choice == "2")
            {
            journal.DisplayAll();
    
            }
            else if(choice == "3")
            {
            Console.Write("Enter filename to save to: ");
            string saveFilename = Console.ReadLine();
            journal.SaveToFile(saveFilename);
            
            }
            else if(choice == "4")
            {
            Console.Write("Enter filename to load from: ");
            string loadFilename = Console.ReadLine();
            journal.LoadFromFile(loadFilename);
            
            }
            else if(choice == "5")
            {
            running = false;
            
            }
            else
            {
            Console.WriteLine("Invalid option. Please try again.");
            
            }
        }
    }
}
