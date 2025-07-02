using System;
using System.Dynamic;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guess = -1;

            Console.WriteLine("Guess the number (1 to 100)");
            while (guess != magicNumber)
            {
                // prompt the user for the guess
                Console.Write("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());

                // get if the number is right
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // check if you want to continue
            Console.Write("Do you wanto to try again? (yes/no): ");
            response = (Console.ReadLine());
            if (response != "yes")
            {
                Console.Write("Thank you for playing!");
            }
            else
            {
                continue;
            }
        } while (response == "yes");
    }
}