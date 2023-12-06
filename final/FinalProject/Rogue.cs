class Rogue : CharacterBase
{
    public int Energy { get; private set; }

    public Rogue(string name, Race race, List<string> actions) : base(name, race, actions)
    {
        Energy = 30;
    }

    public override void DisplayCharacterSheet()
    {
        base.DisplayCharacterSheet();
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Constitution: {Constitution}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Wisdom: {Wisdom}");
        Console.WriteLine($"Charisma: {Charisma}");
        Console.WriteLine($"Energy: {Energy}");
    }

    private void UseEnergy(int cost)
    {
        if (Energy >= cost)
        {
            Energy -= cost;
        }
        else
        {
            Console.WriteLine("Not enough energy!");
        }
    }

    private void RestoreEnergy(int amount)
    {
        Energy = Math.Min(Energy + amount, 100); // Assuming maximum energy is 100
    }
}
