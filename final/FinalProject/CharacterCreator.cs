class CharacterCreator
{
    public static CharacterBase CreateCharacter()
    {
        Console.WriteLine("Let's create your character!");

        Console.Write("Enter your character name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Choose a race: 1. Human, 2. Elf, 3. Dwarf, 4. Dragonborn, 5. Gnome, 6. Halfling, 7. Orc, 8. Tiefling");
            int raceChoice = int.Parse(Console.ReadLine());
            Race chosenRace = (Race)raceChoice;

        Console.WriteLine("Choose a class: 1. Barbarian, 2. Wizard, 3. Rogue");
        int classChoice = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of actions for your character: ");
        int numActions = int.Parse(Console.ReadLine());

        List<string> actions = new List<string>();
        Console.WriteLine("Enter the possible actions for your character:");
        for (int i = 0; i < numActions; i++)
        {
            Console.Write($"Action {i + 1}: ");
            actions.Add(Console.ReadLine());
        }

        CharacterBase player;
        switch (classChoice)
        {
            case 1:
                player = new Barbarian(name, chosenRace, actions);
                break;
            case 2:
                player = new Wizard(name, chosenRace, actions);
                break;
            case 3:
                player = new Rogue(name, chosenRace, actions);
                break;
            default:
                throw new ArgumentException("Invalid class choice");
        }

        // Allow the player to allocate attribute points when first creating the character
        Console.WriteLine("Allocate attribute points:");
        Console.Write("Strength: ");
        player.AllocateAttributePoints(Attribute.Strength, int.Parse(Console.ReadLine()));

        Console.Write("Dexterity: ");
        player.AllocateAttributePoints(Attribute.Dexterity, int.Parse(Console.ReadLine()));

        Console.Write("Constitution: ");
        player.AllocateAttributePoints(Attribute.Constitution, int.Parse(Console.ReadLine()));

        Console.Write("Intelligence: ");
        player.AllocateAttributePoints(Attribute.Intelligence, int.Parse(Console.ReadLine()));

        Console.Write("Wisdom: ");
        player.AllocateAttributePoints(Attribute.Wisdom, int.Parse(Console.ReadLine()));

        Console.Write("Charisma: ");
        player.AllocateAttributePoints(Attribute.Charisma, int.Parse(Console.ReadLine()));

        return player;
    }
}