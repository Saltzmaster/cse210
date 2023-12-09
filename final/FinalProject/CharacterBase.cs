class CharacterBase
{
    public string TsName { get; protected set; }
    public int TsLevel { get; protected set; }
    public int TsExperience { get; protected set; }
    public int TsMaxHealth { get; protected set; }
    public int TsHealth { get; protected set; }
    public int TsStrength { get; protected set; }
    public int TsDexterity { get; protected set; }
    public int TsConstitution { get; protected set; }
    public int TsIntelligence { get; protected set; }
    public int TsWisdom { get; protected set; }
    public int TsCharisma { get; protected set; }
    public Race TsCharacterRace { get; protected set; }
    public List<string> TsActions { get; protected set; }

    public CharacterBase(string tsName, Race tsRace, List<string> actions)
    {
        TsName = tsName;
        TsLevel = 1;
        TsExperience = 0;
        TsMaxHealth = PlayerLevelCalculator.CalculateMaxHealth(TsLevel, TsConstitution);
        TsHealth = TsMaxHealth;
        TsCharacterRace = tsRace;
        TsActions = actions;
        // Adding common preset actions
        TsActions.AddRange(new[] { "Roll Dice", "Rest", "Take Damage", "Gain EXP" });
    }

    public virtual void DisplayCharacterSheet()
    {
        Console.WriteLine($"\nCharacter Sheet for {TsName} ({TsCharacterRace}):");
        Console.WriteLine($"Level: {TsLevel}");
        Console.WriteLine($"Experience: {TsExperience}/{PlayerLevelCalculator.ExperienceRequiredForNextLevel(TsLevel)}");
        Console.WriteLine($"Health: {TsHealth}/{TsMaxHealth}");
    }

    public void Quit()
    {
        Console.WriteLine("Thank you for playing! Exiting the game.");
        Environment.Exit(0);
    }

    public void Rest()
    {
        TsHealth = TsMaxHealth;
        Console.WriteLine($"{TsName} is fully healed!");
    }

    public void TakeDamage(int amount)
    {
        TsHealth -= amount;
        Console.WriteLine($"{TsName} takes {amount} damage!");

        if (TsHealth <= 0)
        {
            Console.WriteLine("Game Over");
            Quit();
        }
    }

    public void GainExperience(int amount)
    {
        TsExperience += amount;
        Console.WriteLine($"{TsName} gained {amount} experience!");
    }

    public virtual void LevelUp()
    {
        TsLevel++;
        TsExperience = 0; // Reset experience for the next level
        TsMaxHealth = PlayerLevelCalculator.CalculateMaxHealth(TsLevel, TsConstitution);
        TsHealth = TsMaxHealth;

        Console.Write($"Congratulations, {TsName}! You've reached level {TsLevel}! Enter the number of additional actions you want to add: ");
        int additionalActionsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < additionalActionsCount; i++)
        {
            Console.Write($"Enter the name of additional action #{i + 1}: ");
            string newAction = Console.ReadLine();
            TsActions.Add(newAction); // Ask the user for details about the new action
        }
    }

    public void AllocateAttributePoints(Attribute attribute, int points)
    {
        switch (attribute)
        {
            case Attribute.Strength:
                TsStrength += points;
                break;
            case Attribute.Dexterity:
                TsDexterity += points;
                break;
            case Attribute.Constitution:
                TsConstitution += points;
                break;
            case Attribute.Intelligence:
                TsIntelligence += points;
                break;
            case Attribute.Wisdom:
                TsWisdom += points;
                break;
            case Attribute.Charisma:
                TsCharisma += points;
                break;
            default:
                throw new ArgumentException("Invalid attribute");
        }
    }

    public void AllocateAttributePointsAfterLevelUp()
    {
        Console.WriteLine($"Congratulations! You've leveled up to Level {TsLevel}.");

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
