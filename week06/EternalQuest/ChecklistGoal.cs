class CheckListGoals : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoals(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresetation()
    {
        return "";
    }
}