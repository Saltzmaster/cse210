// Child class for simple goals
public class Simple : Goal
{
    public Simple(string nameTs, int pointsTs)
    {
        TsName = nameTs;
        BtrPoints = pointsTs;
    }

    public override void TsRecord()
    {
        TsIsDone = true;
        TsPoints += BtrPoints;
    }

    public override void TsDisplay()
    {
        Console.WriteLine($"{TsName} - [{(TsIsDone ? "X" : " ")}] - Score: {TsPoints}");
    }

    public override string TsToString()
    {
        return $"{GetType().Name},{TsName},{TsPoints},{TsIsDone}";
    }

    public override void TsFromString(string data)
    {
        string[] parts = data.Split(',');
        TsName = parts[1];
        TsPoints = int.Parse(parts[2]);
        TsIsDone = bool.Parse(parts[3]);
    }
}