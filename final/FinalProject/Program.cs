using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Example usage
        Character warrior = new Character("Warrior", new CharacterClass { ClassName = "Warrior", Description = "A strong melee fighter" });

        warrior.BuildCharacterSheet();
        warrior.AllocateAttributePoints();
        warrior.LevelingSystem.LevelUpCharacter(warrior);
        warrior.HealthTracker.TakeDamage(warrior, 20);
        warrior.SpellCaster.CastSpell(warrior, "Fireball");
        warrior.SkillManager.LearnSkill(warrior, "Double Strike");
        warrior.ActionManager.PerformAction(warrior, "Attack");
        warrior.Rest();
    }
}
