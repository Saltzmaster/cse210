class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }

    public Dictionary<string, int> Attributes { get; set; }

    public CharacterClass CharacterClass { get; set; }
    public HealthTracker HealthTracker { get; set; }
    public LevelingSystem LevelingSystem { get; set; }
    public SpellCaster SpellCaster { get; set; }
    public SkillManager SkillManager { get; set; }
    public ActionManager ActionManager { get; set; }
    public AttributeManager AttributeManager { get; set; }

    public Character(string name, CharacterClass characterClass)
    {
        Name = name;
        Level = 1;
        Health = 100;
        Attributes = new Dictionary<string, int>();

        CharacterClass = characterClass;
        HealthTracker = new HealthTracker();
        LevelingSystem = new LevelingSystem();
        SpellCaster = new SpellCaster();
        SkillManager = new SkillManager();
        ActionManager = new ActionManager();
        AttributeManager = new AttributeManager();
    }

    public void BuildCharacterSheet()
    {
        // Implementation for building character sheet
    }

    public void BuildSpecialAttacks()
    {
        // Implementation for building special attacks
    }

    public void AllocateAttributePoints()
    {
        // Implementation for allocating attribute points
    }

    public void UseAction()
    {
        // Implementation for using actions
    }

    public void Rest()
    {
        // Implementation for resting
    }
}