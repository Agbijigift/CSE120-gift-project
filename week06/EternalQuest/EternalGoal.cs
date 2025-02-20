class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent() { }
    public override bool IsComplete() => false;
    public override string GetDetailsString() => "[∞] " + _name;
    public override string GetStringRepresentation() => $"Eternal:{_name},{_description},{_points}";
}
