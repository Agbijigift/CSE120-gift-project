using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    { 
                while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();
            else if (choice == "2")
                new ListingActivity().Run();
            else if (choice == "3")
                new ReflectingActivity().Run();
            else if (choice == "4")
                break;
            else
                Console.WriteLine("Invalid choice, try again.");
        }



       
    }

    

}