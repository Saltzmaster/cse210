class Rogue : CharacterBase
{
    public int TsEnergy { get; private set; }

    public Rogue(string name, Race race, List<string> actions) : base(name, race, actions)
    {
        TsEnergy = 30;
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
        Console.WriteLine($"Energy: {TsEnergy}");
    }

    private void UseEnergy(int cost)
    {
        if (TsEnergy >= cost)
        {
            TsEnergy -= cost;
        }
        else
        {
            Console.WriteLine("Not enough energy!");
        }
    }

    private void RestoreEnergy(int amount)
    {
        TsEnergy = Math.Min(TsEnergy + amount, 100); // Assuming maximum energy is 100
    }
}
