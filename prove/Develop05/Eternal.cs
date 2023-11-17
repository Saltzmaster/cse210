// Child class for eternal goals
public class Eternal : Goal
{
    private string tsShort;

    public Eternal(string nameTs, int pointsTs, string tsDescription)
    {
        TsName = nameTs;
        BtrPoints = pointsTs;
        this.tsShort = tsDescription;
    }

    public override void TsRecord()
    {
        // Eternal goals are never completed, but the user gains points each time
        TsPoints += BtrPoints; 
    }

    public override void TsDisplay()
    {
        Console.WriteLine($"{TsName} - Score: {TsPoints} - {tsShort}");
    }

    public override string TsToString()
    {
        return $"{GetType().Name},{TsName},{TsPoints},{TsIsDone},{tsShort}";
    }

    public override void TsFromString(string data)
    {
        string[] parts = data.Split(',');
        TsName = parts[1];
        TsPoints = int.Parse(parts[2]);
        TsIsDone = bool.Parse(parts[3]);
        tsShort = parts[4];
    }
}