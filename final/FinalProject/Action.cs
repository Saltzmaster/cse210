class ActionHandler
{
    public static void PerformAction(CharacterBase character, int choice)
    {
        if (choice >= 0 && choice < character.Actions.Count)
        {
            switch (character.Actions[choice])
            {
                case "Roll Dice":
                    Console.Write($"{character.Name} wants to roll some dice! Enter the number of sides: ");
                    int sides = int.Parse(Console.ReadLine());
                    int result = DiceRoller.RollDice(sides);
                    Console.WriteLine($"{character.Name} rolled a {result}!");
                    break;
                case "Rest":
                    character.Rest();
                    break;
                case "Take Damage":
                    Console.Write($"{character.Name} gets hit! Enter the amount of damage taken: ");
                    int damageAmount = int.Parse(Console.ReadLine());
                    character.TakeDamage(damageAmount);
                    break;
                case "Gain EXP":
                    Console.Write($"{character.Name} gains experience! Enter the amount: ");
                    int expAmount = int.Parse(Console.ReadLine());
                    character.GainExperience(expAmount);
                    break;
                default:
                    Console.WriteLine($"{character.Name} performs: {character.Actions[choice]}");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid action!");
        }
    }
}