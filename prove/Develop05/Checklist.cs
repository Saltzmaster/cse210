// Child class for checklist goals
public class Checklist : Goal
{
    private string tsShort;
    private int completedCount;
    private int tsRequiredCount;

    public Checklist(string nameTs, int pointsTs, string tsDescription, int tsRequiredCount)
    {
        TsName = nameTs;
        TsPoints = 0;
        BtrPoints = pointsTs;
        this.tsShort = tsDescription;
        this.tsRequiredCount = tsRequiredCount;
    }

    public override void TsRecord()
    {
        completedCount++;
        TsPoints += BtrPoints;
        if (completedCount == tsRequiredCount)
        {
            TsIsDone = true;
            TsPoints += 500; // Bonus points for completing the checklist goal
        }
    }

    public override void TsDisplay()
    {
        Console.WriteLine($"{TsName} - Completed {completedCount}/{tsRequiredCount} times - [{(TsIsDone ? "X" : " ")}] - Score: {TsPoints} - {tsShort}");
    }

    public override string TsToString()
    {
        return $"{GetType().Name},{TsName},{TsPoints},{TsIsDone},{tsShort},{completedCount},{tsRequiredCount}";
    }

    public override void TsFromString(string data)
    {
        string[] parts = data.Split(',');
        TsName = parts[1];
        TsPoints = int.Parse(parts[2]);
        TsIsDone = bool.Parse(parts[3]);
        tsShort = parts[4];
        completedCount = int.Parse(parts[5]);
        tsRequiredCount = int.Parse(parts[6]);
    }
}