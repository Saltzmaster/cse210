class PlayerLevelCalculator
{
    public static int CalculateMaxHealth(int level, int constitution)
    {
        return (level * 10) + (constitution / 10);
    }

    public static int ExperienceRequiredForNextLevel(int currentLevel)
    {
        return currentLevel * 100;
    }
}