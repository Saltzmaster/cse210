using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? Number only: ");
        string tsgetGrade = Console.ReadLine();
        int tsGradePercent = int.Parse(tsgetGrade);

        string letter;

        if (tsGradePercent >= 90)
        {
            letter = ("A");
        }
        else if (tsGradePercent >= 80)
        {
            letter = ("B");
        }
        else if (tsGradePercent >= 70)
        {
            letter = ("C");
        }
        else if (tsGradePercent >= 60)
        {
            letter = ("D");
        }
        else 
        {
            letter = ("F");
        }

        Console.WriteLine($"Your letter grade for this class is {letter}.");

        if (tsGradePercent >= 70)
        {
            Console.WriteLine("Magnificent job! You have successfully passed this course!!");
        }
        else 
        {
            Console.WriteLine("Good effort but you did not pass this course. Keep trying and I am sure you can pass next time!");
        }
    }
}