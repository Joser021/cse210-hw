abstract class Goal
{
    protected string _shotName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {

    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresetation();
}