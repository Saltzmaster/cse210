using System;
using System.Collections.Generic;
using System.IO;

/* 

Name: Digital Journal
Purpose: Records prompts from user
Author(s): Ty Saltzgiver
Date: (c) 2023

*/

class Program
{
    static void Main(string[] args)
    {
        tsJournal tsSaveJournal = new tsJournal();
        Random random = new Random();
        List<string> tsPrompts = new List<string>()
        {
            "What did you do today?",
            "What are your plans for tomorrow?",
            "What is your favorite book?",
            "What is your favorite movie?",
            "What is your favorite food?"
        };
 while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());
 switch (choice)
            {
                case 1:
                    int index = random.Next(tsPrompts.Count);
                    Console.WriteLine(tsPrompts[index]);
                    string tsResponse = Console.ReadLine();
                    tsSaveJournal.AddEntry(new tsJournalEntry(tsPrompts[index], tsResponse));
                    break;
                case 2:
                    tsSaveJournal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Please enter a filename: ");
                    string tsSaveFilename = Console.ReadLine();
                    tsSaveJournal.tsSaveToFile(tsSaveFilename);
                    break;
                     case 4:
                    Console.Write("Please enter a filename: ");
                    string tsLoadFilename = Console.ReadLine();
                    tsSaveJournal.tsLoadFromFile(tsLoadFilename);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}