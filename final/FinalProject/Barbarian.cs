class Barbarian : CharacterBase
{
    public int TsStamina { get; private set; }

    public Barbarian(string name, Race race, List<string> actions) : base(name, race, actions)
    {
        TsStamina = 25;
    }

    public override void DisplayCharacterSheet()
    {
        base.DisplayCharacterSheet();
        Console.WriteLine($"Strength: {TsStrength}");
        Console.WriteLine($"Dexterity: {TsDexterity}");
        Console.WriteLine($"Constitution: {TsConstitution}");
        Console.WriteLine($"Intelligence: {TsIntelligence}");
        Console.WriteLine($"Wisdom: {TsWisdom}");
        Console.WriteLine($"Charisma: {TsCharisma}");
        Console.WriteLine($"Stamina: {TsStamina}");
    }

    private void UseStamina(int cost)
    {
        if (TsStamina >= cost)
        {
            TsStamina -= cost;
        }
        else
        {
            Console.WriteLine("Not enough stamina!");
        }
    }

    private void RestoreStamina(int amount)
    {
        TsStamina = Math.Min(TsStamina + amount, 100); // Assuming maximum stamina is 100
    }
}
