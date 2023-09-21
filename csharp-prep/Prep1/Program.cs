using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string tsFirstName = Console.ReadLine();

        Console.Write("What is your last Name?");
        string tsLastName = Console.ReadLine();

        Console.WriteLine($"Your name is {tsLastName}, {tsFirstName} {tsLastName}");
    }
}
