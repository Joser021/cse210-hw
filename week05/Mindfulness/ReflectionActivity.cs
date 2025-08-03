using System.ComponentModel.DataAnnotations;
using System.Numerics;

class ReflectionActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string> {"Think of a time when you did something really difficult.", "Think of a time you helped someone in need."};
        _questions = new List<string> {"why was this experience meaningful to you?", "How did you feel at the end?", "What did you learn from this?"};
    }

    public void run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestion();
        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }
    public void DisplayQuestion()
    {
        Console.Clear();
        int total = 0;
        while (total < _duration)
        {
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(10);
            Console.WriteLine();
            total += 10;
        }
    }
}