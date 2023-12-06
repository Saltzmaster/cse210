class Barbarian : CharacterBase
{
    public int Stamina { get; private set; }

    public Barbarian(string name, Race race, List<string> actions) : base(name, race, actions)
    {
        Stamina = 25;
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
        Console.WriteLine($"Stamina: {Stamina}");
    }

    private void UseStamina(int cost)
    {
        if (Stamina >= cost)
        {
            Stamina -= cost;
        }
        else
        {
            Console.WriteLine("Not enough stamina!");
        }
    }

    private void RestoreStamina(int amount)
    {
        Stamina = Math.Min(Stamina + amount, 100); // Assuming maximum stamina is 100
    }
}
