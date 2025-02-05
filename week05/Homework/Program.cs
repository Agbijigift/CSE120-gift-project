using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment();
        assignment1.SetTextBookSection("7.3");
        assignment1.SetProblem("8-19");
        assignment1.SetName("Gift Agbiji");
        assignment1.SetTopic("Fraction");
        string summary = assignment1.GetSummary();
        string homeWork = assignment1.GetHomeWorkList();

        Console.WriteLine(summary);
        Console.WriteLine(homeWork);
        Console.WriteLine();
        
        WrittingAssignment assignment2 = new WrittingAssignment();
        assignment2.SetName("Happiness Agbiji");
        assignment2.SetTopic("Africa History");
        assignment2.SetTitle("Slave Trading");
        string homeWorkSummary = assignment2.GetSummary();
        string homeWorkTopic = assignment2.GetWrittingInformation();

        Console.WriteLine(homeWorkSummary);
        Console.WriteLine(homeWorkTopic);
        
        
    }
}