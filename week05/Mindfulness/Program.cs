using System;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine(@"Menu Options:
    1. Start Breathing Activity
    2. Start Reflecting Activity
    3. Start Listing Activity
    4. Quit
Select a Choice From the Menu:");

      int choice = int.Parse(Console.ReadLine());
      if (choice == 1)
      {
        BreathingActivity breath = new BreathingActivity();
        breath.run();
      }
      else if (choice == 2)
      {
        ReflectionActivity reflection = new ReflectionActivity();
        reflection.run();
      }
      else if (choice == 3)
      {
        ListingActivity listing = new ListingActivity();
        listing.Run();
      }
      else if (choice == 4)
      {
        Console.WriteLine("Thank you for using.");
        break;
      }
    }
  }
}