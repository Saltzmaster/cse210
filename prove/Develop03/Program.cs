using System;
using System.Collections.Generic;
using System.Net.Security;

class Program
{
       static void Main(String[] args)
    {
        Console.WriteLine("Enter the scripture reference:");
        string tsReference = Console.ReadLine();
        Console.WriteLine("Enter the scripture text:");
        string tsText = Console.ReadLine();
        Scripture tsScripture = new Scripture(tsReference, tsText);
        Console.Clear();
        Console.WriteLine(tsScripture.ToString());
        Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");
        string tsInput = Console.ReadLine();
        while (tsInput != "quit")
        {
            tsScripture.tsHideWords();
            Console.Clear();
            Console.WriteLine(tsScripture.ToString());
            if (tsScripture.tsAllWordsHidden())
            {
                break;
            }
            Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");
            tsInput = Console.ReadLine();
        }
    }
}