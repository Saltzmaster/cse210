class DiceRoller
{
    private static Random random = new Random();

    public static int RollDice(int sides)
    {
        return random.Next(1, sides + 1);
    }
}