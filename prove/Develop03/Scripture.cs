using System;

class Scripture
{
    private string tsReference;
    private string tsText;
    private List<Word> tsWords;

    public Scripture(string tsReference, string tsText)
    {
        this.tsReference = tsReference;
        this.tsText = tsText;
        this.tsWords = new List<Word>();
        string[] splitText = tsText.Split(' ');
        for (int i = 0; i < splitText.Length; i++)
        {
            tsWords.Add(new Word(splitText[i]));
        }
    }

    public void tsHideWords()
{
    Random tsRandom = new Random();
    int tsIndexToHide = tsRandom.Next(tsWords.Count);
    tsWords[tsIndexToHide].tsHide();
}

    public bool tsAllWordsHidden()
    {
        foreach (Word word in tsWords)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        string output = tsReference + "\n\n";
        foreach (Word word in tsWords)
        {
            output += word.ToString() + " ";
        }
        return output;
    }
}
