using System;

class Program
{
    static void Main(string[] args)
    {   
        // Console.Write("What is the magic number? ");
        // string tsGetMagicNumber = Console.ReadLine();
        // int tsMagicNumber = int.Parse(tsGetMagicNumber);

        Random rnd = new Random();
        int tsMagicNumber = rnd.Next(1, 100);

        int tsTryAgain = 0;

        do
        {
            Console.Write("What is your guess? ");
            string tsGetGuess = Console.ReadLine();
            int tsGuess = int.Parse(tsGetGuess);

            if (tsGuess < tsMagicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (tsGuess > tsMagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (tsGuess == tsMagicNumber)
            {
                Console.WriteLine("You guessed it!");
                tsTryAgain = 1;
            }
        }   while (tsTryAgain == 0);
    }
}