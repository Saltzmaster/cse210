class ActionHandler
{
    public static void PerformAction(CharacterBase character, int choice)
    {
        if (choice >= 0 && choice < character.TsActions.Count)
        {
            switch (character.TsActions[choice])
            {
                case "Roll Dice":
                    Console.Write($"{character.TsName} wants to roll some dice! Enter the number of sides: ");
                    int sides = int.Parse(Console.ReadLine());
                    int result = DiceRoller.RollDice(sides);
                    Console.WriteLine($"{character.TsName} rolled a {result}!");
                    break;
                case "Rest":
                    character.Rest();
                    break;
                case "Take Damage":
                    Console.Write($"{character.TsName} gets hit! Enter the amount of damage taken: ");
                    int damageAmount = int.Parse(Console.ReadLine());
                    character.TakeDamage(damageAmount);
                    break;
                case "Gain EXP":
                    Console.Write($"{character.TsName} gains experience! Enter the amount: ");
                    int expAmount = int.Parse(Console.ReadLine());
                    character.GainExperience(expAmount);
                    break;
                default:
                    Console.WriteLine($"{character.TsName} performs: {character.TsActions[choice]}");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid action!");
        }
    }
}