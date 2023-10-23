using System;
class RandomWordHider
{
    private List<Word> tsWords;
    private Random tsRandom;

    public RandomWordHider(List<Word> words)
    {
        this.tsWords = words;
        tsRandom = new Random();
    }

    public void HideRandomWord()
    {
        int index = tsRandom.Next(tsWords.Count);
        tsWords[index].tsHide();
    }
}
