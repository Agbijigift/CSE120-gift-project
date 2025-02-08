using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
public class ReflectingActivity : Activity
{
   List<string> _prompts = new List<string>()
   {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless"
   };
   List<string> _questions = new List<string>()
   {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
   };
   public ReflectingActivity(): base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life"){}

   public void Run()
   {
      DisplayStartingMessage();
      Console.WriteLine (GetRandomPrompt());
      Console.WriteLine();
      Console.WriteLine(GetRandomQuestion());
      DisplayEndingMessage();
   }
   public string GetRandomPrompt()
   {
        Random randomPrompt = new Random();
         return _prompts[randomPrompt.Next(_prompts.Count)];

   }
      public string GetRandomQuestion()
   {
      Random randomQuestion = new Random();
      return _questions[randomQuestion.Next(_questions.Count)];
        
   }
   public void DisplayPrompt()
   {
    
      Console.WriteLine(GetRandomPrompt());
      ShowSpinner(3);
    
   }
   public void DisplayQuestion()
   {
      DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(4);
        }

    }
   

}