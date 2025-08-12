abstract class Activity
{
    protected DateTime _date = new DateTime();
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min): Distance: {GetDistance().ToString("0.0").Replace(",",".")} km, Speed: {GetSpeed().ToString("0.0").Replace(",",".")} kph, Pace: {GetPace().ToString("0.00").Replace(",",".")} min per km";
    }
}
