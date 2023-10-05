using System;
using System.Collections.Generic;
using System.IO;

class tsJournalEntry
{
    public string tsPrompt { get; set; }
    public string tsResponse { get; set; }
    public DateTime tsDate { get; set; }

    public tsJournalEntry(string prompt, string response)
    {
        tsPrompt = prompt;
        tsResponse = response;
        tsDate = DateTime.Now;
    }
    public override string ToString()
    {
        return $"[{tsDate}] {tsPrompt}: {tsResponse}";
    }
}