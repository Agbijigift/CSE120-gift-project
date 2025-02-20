class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"Your score: {_score}\n");
            Console.WriteLine();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1") _goals.Add(new SimpleGoal(name, description, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, description, points));
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Enter the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        _goals[index].RecordEvent();
        _score += _goals[index] is ChecklistGoal cg && cg.IsComplete() ? cg.GetPoints() + cg.GetBonus() : _goals[index].GetPoints();
        Console.WriteLine("Event recorded!");
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void SaveGoals()
    {
        using StreamWriter file = new StreamWriter("goals.txt");
        file.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            file.WriteLine(goal.GetStringRepresentation());
        }
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            if (parts[0] == "Simple") _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (parts[0] == "Eternal") _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (parts[0] == "Checklist") _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
        }
    }
}