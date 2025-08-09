using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine(@$"
You have {_score} points!

Menu Options:
  1. Create New Goal
  2. List Goals
  3. Save Goals
  4. Load Goals
  5. record Event
  6. Quit
Select a choice from the menu: ");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.Write(@"The types of Goals are:
      1. Simple Goal
      2. Eternal Goal
      3. Checklist Goal
Which type of goal would you like to create? ");

        string type = Console.ReadLine();

        Console.Write("what is the name of your Goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (type == "1")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (type == "2")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (goal != null)
        {
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();

            if (goal is ChecklistGoal checklist)
            {
                _score += checklist.IsComplete() && checklist._amountCompleted == checklist._target
                    ? checklist._points + checklist._bonus
                    : checklist._points;
            }
            else
            {
                _score += goal._points;
            }
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal sg)
                    writer.WriteLine($"Simple,{sg._shortName},{sg._description},{sg._points},{sg.IsComplete()}");
                else if (goal is EternalGoal eg)
                    writer.WriteLine($"Eternal,{eg._shortName},{eg._description},{eg._points}");
                else if (goal is ChecklistGoal cg)
                    writer.WriteLine($"Checklist,{cg._shortName},{cg._description},{cg._points},{cg._bonus},{cg._target},{cg._amountCompleted}");
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0];

            if (type == "Simple")
            {
                var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                var goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (type == "Checklist")
            {
                var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                goal._amountCompleted = int.Parse(parts[4]);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}
