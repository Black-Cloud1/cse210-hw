public class Assignment
{
    //Add private member variables
    protected string _studentName;
    private string _topic;

    // Create a constructor
    public Assignment(string studentName, string topic)// <Add parameters
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters for the private variables
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    
    // Method that displays the students name and the topic
    public string Getsummary()
    {
        return $"{_studentName} - {_topic}";
    }

}