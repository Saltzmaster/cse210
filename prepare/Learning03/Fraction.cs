using System;

public class tsFraction
{
    private int tsTopFraction;
    private int tsBottomFraction;

    public tsFraction()
    {
        tsTopFraction = 1;
        tsBottomFraction = 1;
    }

    public tsFraction(int wholeNumber)
    {
        tsTopFraction = wholeNumber;
        tsBottomFraction = 1;
    }

    public tsFraction(int top, int bottom)
    {
        tsTopFraction = top;
        tsBottomFraction = bottom;
    }

     public string GetFractionString()
    {
        string text = $"{tsTopFraction}/{tsBottomFraction}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)tsTopFraction / (double)tsBottomFraction;
    }

}