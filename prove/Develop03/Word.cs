using System;

class Word
{
    private string tsText;
    private bool tsHidden;

    public Word(string text)
    {
        this.tsText = text;
        this.tsHidden = false;
    }

    public void tsHide()
    {
        tsHidden = true;
    }

    public bool IsHidden()
    {
        return tsHidden;
    }

    public override string ToString()
    {
        if (tsHidden)
        {
            return "______";
        }
        else
        {
            return tsText;
        }
    }
}
