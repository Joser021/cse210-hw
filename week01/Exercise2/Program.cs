using System;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string textPercentage = Console.ReadLine();
        int gradePercentage = int.Parse(textPercentage);

        string grade = "";
        // gets the grade result
        if (gradePercentage >= 90)
        {
            grade = "A";
        }
        else if (gradePercentage >= 80)
        {
            grade = "B";
        }
        else if (gradePercentage >= 70)
        {
            grade = "C";
        }
        else if (gradePercentage >= 60)
        {
            grade = "D";
        }
        else if (gradePercentage <= 60)
        {
            grade = "F";
        }

        string sign = "";
        // gets the sign
        if (grade == "F" || gradePercentage >= 93)
        {
            sign = "";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }
        else if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }

        Console.WriteLine($"Your Final grade is: {grade}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed! Congratulations");
        }
        else
        {
            Console.WriteLine("I am sorry, you need more than 70 to pass the class.");
            Console.WriteLine("Good luck next time!");
        }
    }
}