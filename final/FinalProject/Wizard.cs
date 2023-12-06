class Wizard : CharacterBase
{
    public int Mana { get; private set; }

    public Wizard(string name, Race race, List<string> actions) : base(name, race, actions)
    {
        Mana = 20;
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
        Console.WriteLine($"Mana: {Mana}");
    }

    private void UseMana(int cost)
    {
        if (Mana >= cost)
        {
            Mana -= cost;
        }
        else
        {
            Console.WriteLine("Not enough mana!");
        }
    }

    private void RestoreMana(int amount)
    {
        Mana = Math.Min(Mana + amount, 100); // Assuming maximum mana is 100
    }
}
