class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void run()
    {
        DisplayStartingMessage();

        int total = 0;
        while (total < _duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            total += 4;
            if (total >= _duration) break;

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            total += 6;
        }
        
        DisplayEndingMessage();
    }
}