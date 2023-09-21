using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string tsUserName = PromptUserName();
        int tsUserNumber = PromptUserNumber();

        int tsSquare = SquareNumber(tsUserNumber);

        DisplayResult(tsSquare, tsUserName);
    }

    static void DisplayWelcome()
    {
        Console.Write("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string tsUserName = Console.ReadLine();
        
        return tsUserName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int tsUserNumber = int.Parse(Console.ReadLine());
        
        return tsUserNumber;
    }

    static int SquareNumber(int tsUserNumber)
    {
        int tsSquare = tsUserNumber * tsUserNumber;

        return tsSquare;
    }

    static void DisplayResult(int tsSquare, string tsUserName)
    {
        Console.WriteLine($"{tsUserName}, the square of your number is {tsSquare}");
    }
}