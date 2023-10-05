using System;
using System.Collections.Generic;
using System.IO;

class tsJournal
{
    private List<tsJournalEntry> tsEntries;

    public tsJournal()
    {
        tsEntries = new List<tsJournalEntry>();
    }

    public void AddEntry(tsJournalEntry tsEntry)
    {
        tsEntries.Add(tsEntry);
    }
 public void DisplayEntries()
    {
        foreach (var tsEntry in tsEntries)
        {
            Console.WriteLine(tsEntry);
        }
    }

    public void tsSaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var tsEntry in tsEntries)
            {
                writer.WriteLine($"{tsEntry.tsPrompt},{tsEntry.tsResponse},{tsEntry.tsDate}");
            }
        }
    }
    public void tsLoadFromFile(string filename)
    {
        tsEntries.Clear();

        using (StreamReader tsReader = new StreamReader(filename))
        {
            while (!tsReader.EndOfStream)
            {
                string[] tsFields = tsReader.ReadLine().Split(',');
                tsJournalEntry tsEntry = new tsJournalEntry(tsFields[0], tsFields[1]);
                tsEntry.tsDate = DateTime.Parse(tsFields[2]);
                tsEntries.Add(tsEntry);
            }
        }
    }
}