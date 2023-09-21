using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> tsNumberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int tsNewNumber = -1;
        while (tsNewNumber != 0)
        {
            Console.Write("Enter Number: ");
            string tsGetNumber = Console.ReadLine();
            tsNewNumber = int.Parse(tsGetNumber);

            if (tsNewNumber != 0);
            {
                tsNumberList.Add(tsNewNumber);
            }
        }

        int tstotal = 0;
        foreach (int number in tsNumberList)
        {
            tstotal += number;
        }

        Console.WriteLine($"The sum is: {tstotal}");

        float tsAverage = ((float)tstotal) / (tsNumberList.Count -1);
        
        Console.WriteLine($"The average is: {tsAverage}");

        int tsmax = -1;

        foreach (int number in tsNumberList)
        {
            if (number > tsmax)
            {
                tsmax = number;
            }
        }
        Console.WriteLine($"The max is: {tsmax}");
    }
}