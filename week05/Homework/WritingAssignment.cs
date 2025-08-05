public class WritingAssignment : Assignment
{
    // Member variable
    private string _title;

    // Constructor that inherited from the class Assignment
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    // Method
    public string GetWritingInformation()
    {
        string StudentName = GetStudentName();
        return $"{_title} {StudentName}";
    }

}