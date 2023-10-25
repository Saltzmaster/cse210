public class Assignment
{
    private string tsStudentName;
    private string tsTopic;

    public Assignment(string studentName, string topic)
    {
        tsStudentName = studentName;
        tsTopic = topic;
    }

    public string GetStudentName()
    {
        return tsStudentName;
    }

    public string GetTopic()
    {
        return tsTopic;
    }

    public string GetSummary()
    {
        return tsStudentName + " - " + tsTopic;
    }
}