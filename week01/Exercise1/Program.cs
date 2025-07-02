using System;

class Program
{
    static void Main(string[] args)
    {
        // prompt the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // prompt the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}