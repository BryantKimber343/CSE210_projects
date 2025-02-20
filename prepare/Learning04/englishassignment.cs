public class EnglishAssignment : Assignment
{
    private string _title;

    public EnglishAssignment() : base()
    {
        _title = "";
    }
    
    public EnglishAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
        
    }

    public string GetWritingInformation()
    {
        return _title;
    }
}