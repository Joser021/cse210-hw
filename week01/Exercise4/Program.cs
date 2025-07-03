using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();
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
        int smallest = 0;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > 0)
            {
                positiveNumbers.Add(number);
                largest = positiveNumbers.Max();
                smallest = positiveNumbers.Min();
            }
        }

        // get the average
        int numbersLength = numbers.Count();
        double average = ((float)sum) / numbersLength;

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average.ToString("F3")}");
        Console.WriteLine($"The largest Number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}