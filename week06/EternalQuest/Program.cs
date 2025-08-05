using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(@"You have 0 points

Menu Options:
    1. Create new goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write(@"The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. CheckList Goal
Which type of goal would you like to create?");
                int chooseGoal = int.Parse(Console.ReadLine());
                switch (chooseGoal)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;

            case 2:
                Console.WriteLine("You selected List Goals");
                break;
            case 3:
                Console.WriteLine("You selected Save Goals");
                break;
            case 4:
                Console.WriteLine("You selected Load Goals");
                break;
            case 5:
                Console.WriteLine("You selected Record Events");
                break;
            case 6:
                Console.WriteLine("Thank you for using");
                break;
            default:
                Console.WriteLine("Invalid choice, insert a valid goal choice.");
                break;
        }
    }
}