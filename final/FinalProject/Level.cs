class PlayerLevelCalculator
{
    public static int CalculateMaxHealth(int level, int constitution)
    {
        return (level * 10) + (2 * constitution);
    }

    public static int ExperienceRequiredForNextLevel(int currentLevel)
    {
        return currentLevel * 100;
    }
}