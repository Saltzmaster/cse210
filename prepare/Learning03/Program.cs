 using System;

class Program
{
    static void Main(string[] args)
    {
        tsFraction tsOne = new tsFraction();
        Console.WriteLine(tsOne.GetFractionString());
        Console.WriteLine(tsOne.GetDecimalValue());

        tsFraction tsTwo = new tsFraction(5);
        Console.WriteLine(tsTwo.GetFractionString());
        Console.WriteLine(tsTwo.GetDecimalValue());

        tsFraction tsThree = new tsFraction(3, 4);
        Console.WriteLine(tsThree.GetFractionString());
        Console.WriteLine(tsThree.GetDecimalValue());

        tsFraction tsFour = new tsFraction(1, 3);
        Console.WriteLine(tsFour.GetFractionString());
        Console.WriteLine(tsFour.GetDecimalValue());
    }
}