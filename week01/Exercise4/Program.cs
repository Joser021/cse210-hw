using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Thank you for using!");
                break;
            }
            numbers.Add(number);
        }

        // get the sum and the largest number
        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        // get the average
        int numbersLength = numbers.Count();
        double average = ((float)sum) / numbersLength;


        Console.WriteLine(sum);
        Console.WriteLine(average);
        Console.WriteLine(largest);        
    }
}