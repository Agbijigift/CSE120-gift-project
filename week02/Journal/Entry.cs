public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _prompt = prompt;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_text}");
        Console.WriteLine("----------------------------");
    }
}

