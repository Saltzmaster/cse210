public class MathAssignment : Assignment
{
    private string tsTextbookSection;
    private string tsProblems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        tsTextbookSection = textbookSection;
        tsProblems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {tsTextbookSection} Problems {tsProblems}";
    }
}