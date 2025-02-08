public class BreathingActivity:Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding your breathing.") {}

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            Console.WriteLine("Breathe out...");
            ShowSpinner(2);
        }
    }

}