class TsCharacterCreator
{
    public static CharacterBase CreateCharacter()
    {
        Console.WriteLine("Let's create your character!");

        Console.Write("Enter your character's name: ");
        string tsName = Console.ReadLine();

        Console.WriteLine("Choose a race: 1. Human, 2. Elf, 3. Dwarf, 4. Dragonborn, 5. Gnome, 6. Halfling, 7. Orc, 8. Tiefling");
        int tsRaceChoice = int.Parse(Console.ReadLine());
        Race tsChosenRace = (Race)tsRaceChoice;

        Console.WriteLine("Choose a class: 1. Barbarian, 2. Wizard, 3. Rogue");
        int tsClassChoice = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of actions for your character: ");
        int tsNumActions = int.Parse(Console.ReadLine());

        List<string> tsActions = new List<string>();
        Console.WriteLine("Enter each possible action for your character: ");
        for (int i = 0; i < tsNumActions; i++)
        {
            Console.Write($"Action {i + 1}: ");
            tsActions.Add(Console.ReadLine());
        }

        CharacterBase tsPlayer;
        switch (tsClassChoice)
        {
            case 1:
                tsPlayer = new Barbarian(tsName, tsChosenRace, tsActions);
                break;
            case 2:
                tsPlayer = new Wizard(tsName, tsChosenRace, tsActions);
                break;
            case 3:
                tsPlayer = new Rogue(tsName, tsChosenRace, tsActions);
                break;
            default:
                throw new ArgumentException("Invalid class choice");
        }

        // Allow the player to allocate attribute points when first creating the character
        Console.WriteLine("Allocate attribute points:");
        Console.Write("Strength: ");
        tsPlayer.AllocateAttributePoints(Attribute.Strength, int.Parse(Console.ReadLine()));

        Console.Write("Dexterity: ");
        tsPlayer.AllocateAttributePoints(Attribute.Dexterity, int.Parse(Console.ReadLine()));

        Console.Write("Constitution: ");
        tsPlayer.AllocateAttributePoints(Attribute.Constitution, int.Parse(Console.ReadLine()));

        Console.Write("Intelligence: ");
        tsPlayer.AllocateAttributePoints(Attribute.Intelligence, int.Parse(Console.ReadLine()));

        Console.Write("Wisdom: ");
        tsPlayer.AllocateAttributePoints(Attribute.Wisdom, int.Parse(Console.ReadLine()));

        Console.Write("Charisma: ");
        tsPlayer.AllocateAttributePoints(Attribute.Charisma, int.Parse(Console.ReadLine()));

        return tsPlayer;
    }
}