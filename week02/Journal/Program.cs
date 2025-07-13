using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt1 = new PromptGenerator();
        Journal theJournal = new Journal();

        while (true)
        {
            Console.Write(@"
Welcome to the Journal Program!
Please select one of the following choices:
  1. Write
  2. Display
  3. Load
  4. Save
  5. Quit
            ");

            Console.Write(@"
What do you like to do? ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = prompt1.GetRandomPrompt();
                Console.WriteLine(prompt);

                string entryText = Console.ReadLine();
                Entry newEntry = new Entry(prompt, entryText);
                theJournal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Display Entries...");
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Please enter the File Name. E.g.,(fileName.txt)");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Please enter the File Name. E.g.,(fileName.txt)");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the journal!");
                break;
            }
        }
    }
}