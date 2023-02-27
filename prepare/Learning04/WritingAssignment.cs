using System; 

public class WritingAssignment : Assignment
{

    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetStudentName()
    {
        return $"{_title} by {_studentName}";
    }

}


/*
if I used privat4e insted of protected I need to do this
public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";

*/