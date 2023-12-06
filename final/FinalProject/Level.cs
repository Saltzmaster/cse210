class PlayerLevelCalculator
{
    public static int CalculateMaxHealth(int level)
    {
        return 10 + (level - 1) * 5;
    }

    public static int ExperienceRequiredForNextLevel(int currentLevel)
    {
        return currentLevel * 100;
    }
}