// Parent class for all other goals
public abstract class Goal
{
    public string TsName { get; set; }
    public int TsPoints { get; set; }
    public bool TsIsDone { get; set; }

    public int BtrPoints {get; set; }

    public abstract void TsRecord();
    public abstract void TsDisplay();
    public abstract string TsToString();
    public abstract void TsFromString(string data);
}