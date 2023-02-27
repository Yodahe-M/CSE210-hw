using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;


    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

/*

I needed to create this if I had privte _studentName instead of protected. 
public string GetStudentName()
    {
        return _studentName;
    }


*/