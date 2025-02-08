using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using System.Threading;
public class Activity
{
    protected string _name;
    protected string _discription;
    protected int _duration;
    public Activity(string name, string discription)
    {
        _name = name;
        _discription = discription;
    }
        public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_discription);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
     
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        string[] animation = {"|", "/", "-", "\\"};
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(animation[i % animation.Length]);
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.WriteLine();
    }


    public void ShowCountDownSeconds(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done");
    }
}


