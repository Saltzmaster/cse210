class CharacterBase
{
    public string Name { get; protected set; }
    public int Level { get; protected set; }
    public int Experience { get; protected set; }
    public int MaxHealth { get; protected set; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Dexterity { get; protected set; }
    public int Constitution { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Wisdom { get; protected set; }
    public int Charisma { get; protected set; }
    public Race CharacterRace { get; protected set; }
    public List<string> Actions { get; protected set; }

    public CharacterBase(string name, Race race, List<string> actions)
    {
        Name = name;
        Level = 1;
        Experience = 0;
        MaxHealth = PlayerLevelCalculator.CalculateMaxHealth(Level, Constitution);
        Health = MaxHealth;
        CharacterRace = race;
        Actions = actions;
        // Adding common preset actions
        Actions.AddRange(new[] { "Roll Dice", "Rest", "Take Damage", "Gain EXP" });
    }

    public virtual void DisplayCharacterSheet()
    {
        Console.WriteLine($"\nCharacter Sheet for {Name} ({CharacterRace}):");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Experience: {Experience}/{PlayerLevelCalculator.ExperienceRequiredForNextLevel(Level)}");
        Console.WriteLine($"Health: {Health}/{MaxHealth}");
    }

    public void Quit()
    {
        Console.WriteLine("Thank you for playing! Exiting the game.");
        Environment.Exit(0);
    }
      public void Rest()
    {
        Health = MaxHealth;
        Console.WriteLine($"{Name} is fully healed!");
    }
    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} takes {amount} damage!");

        if (Health <= 0)
        {
            Console.WriteLine("Game Over");
            Quit();
        }
    }
    public void GainExperience(int amount)
    {
        Experience += amount;
        Console.WriteLine($"{Name} gained {amount} experience!");
    }
    public virtual void LevelUp()
    {
        Level++;
        Experience = 0; // Reset experience for the next level
        MaxHealth = PlayerLevelCalculator.CalculateMaxHealth(Level, Constitution);
        Health = MaxHealth;

        Console.Write($"Congratulations, {Name}! You've reached level {Level}! Enter the number of additional actions you want to add: ");
        int additionalActionsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < additionalActionsCount; i++)
        {
            Console.Write($"Enter the name of additional action #{i + 1}: ");
            string newAction = Console.ReadLine();
            Actions.Add(newAction); // Ask the user for details about the new action
        }
    }
    public void AllocateAttributePoints(Attribute attribute, int points)
    {
        switch (attribute)
        {
            case Attribute.Strength:
                Strength += points;
                break;
            case Attribute.Dexterity:
                Dexterity += points;
                break;
            case Attribute.Constitution:
                Constitution += points;
                break;
            case Attribute.Intelligence:
                Intelligence += points;
                break;
            case Attribute.Wisdom:
                Wisdom += points;
                break;
            case Attribute.Charisma:
                Charisma += points;
                break;
            default:
                throw new ArgumentException("Invalid attribute");
        }
    }
    public void AllocateAttributePointsAfterLevelUp()
    {
        Console.WriteLine($"Congratulations! You've leveled up to Level {Level}.");

        // Allow the player to allocate attribute points
        Console.WriteLine("Allocate attribute points (will be added to current stats): ");
        Console.Write("Strength: ");
        AllocateAttributePoints(Attribute.Strength, int.Parse(Console.ReadLine()));

        Console.Write("Dexterity: ");
        AllocateAttributePoints(Attribute.Dexterity, int.Parse(Console.ReadLine()));

        Console.Write("Constitution: ");
        AllocateAttributePoints(Attribute.Constitution, int.Parse(Console.ReadLine()));

        Console.Write("Intelligence: ");
        AllocateAttributePoints(Attribute.Intelligence, int.Parse(Console.ReadLine()));

        Console.Write("Wisdom: ");
        AllocateAttributePoints(Attribute.Wisdom, int.Parse(Console.ReadLine()));

        Console.Write("Charisma: ");
        AllocateAttributePoints(Attribute.Charisma, int.Parse(Console.ReadLine()));

    }
}