using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 30, 20.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };
            Console.WriteLine("Exercise Tracker");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine();

        foreach (Activity activity in activities)
        {

            Console.WriteLine(activity.GetSummary());
        }
    }
}
