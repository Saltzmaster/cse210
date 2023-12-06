using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the RPG Game Tracker!");

        // Character creation
        CharacterBase player = CharacterCreator.CreateCharacter();

        // Main game loop
        while (true)
        {
            player.DisplayCharacterSheet();

            // Display available actions
            Console.WriteLine("Available Actions:");
            for (int i = 0; i < player.Actions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {player.Actions[i]}");
            }
            Console.WriteLine($"{player.Actions.Count + 1}. Quit");

            // Get user action
            Console.Write("Choose an action: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == player.Actions.Count + 1)
            {
                Console.WriteLine("Thank you for playing! Exiting the game.");
                break;
            }

            // Process user action using ActionPerformer
            ActionHandler.PerformAction(player, choice - 1);

            // Level up check
            if (player.Experience >= PlayerLevelCalculator.ExperienceRequiredForNextLevel(player.Level))
            {
                player.LevelUp();
                // Allow the player to allocate attribute points after leveling up
                player.AllocateAttributePointsAfterLevelUp();
            }
        }
    }
}
enum Attribute
{
    Strength,
    Dexterity,
    Constitution,
    Intelligence,
    Wisdom,
    Charisma
}

enum Race
{
    Human,
    Elf,
    Dwarf,
    Dragonborn,
    Gnome,
    Halfling,
    Orc,
    Tiefling
}