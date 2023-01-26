public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment()
    {
        _studentName = "No student registered";
        _topic = "No topic selected";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}       