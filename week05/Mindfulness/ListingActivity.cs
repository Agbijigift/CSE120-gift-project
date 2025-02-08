using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
public class ListingActivity:Activity
{
    public int _count;
    List<string> _prompt = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
        
    };
    public ListingActivity(): base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." ) {}
    
    public void Run()
    {
     DisplayStartingMessage();
     Console.WriteLine(GetRandomPrompt());
     ShowCountDownSeconds(5);
     List<string> userResponses = GetListFromUser();
     Console.WriteLine($"You listed {userResponses.Count} items.");
     DisplayEndingMessage();

    }
       public string GetRandomPrompt()
     { 
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompt.Count);
        return _prompt[index];
     }
    public List<string> GetListFromUser()
    {
     List<string> userList  = new List<string>();
     Console.WriteLine("Enter Your respose");
     while(true)
     {
          string input = Console.ReadLine();
          if (input.Count() >= 4)
          {
               break;
          }
          userList.Add(input);
     }
     return userList;
    }
}