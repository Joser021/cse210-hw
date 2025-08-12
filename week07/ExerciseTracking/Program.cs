using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>(){
        new Running(new DateTime(2025, 8, 12), 30, 4.8),
        new Cycling(new DateTime(2025, 8, 12), 40, 20.0),
        new Swimming(new DateTime(2025, 8, 12), 25, 30)
        };

        foreach (var Activity in activities)
        {
            Console.WriteLine(Activity.GetSummary());
        }
    }
}