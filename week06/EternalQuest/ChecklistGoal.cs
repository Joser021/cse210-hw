class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You got {_points} extra points!");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} {_description} -- Current completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {_shortName} {_description} -- Current completed {_amountCompleted}/{_target}";
    }
}