class Wizard : CharacterBase
{
    public int TsMana { get; private set; }

    public Wizard(string name, Race race, List<string> actions) : base(name, race, actions)
    {
        TsMana = 20;
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
        Console.WriteLine($"Mana: {TsMana}");
    }

    private void UseMana(int cost)
    {
        if (TsMana >= cost)
        {
            TsMana -= cost;
        }
        else
        {
            Console.WriteLine("Not enough mana!");
        }
    }

    private void RestoreMana(int amount)
    {
        TsMana = Math.Min(TsMana + amount, 100); // Assuming maximum mana is 100
    }
}
