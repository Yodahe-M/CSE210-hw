using System;
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;


    public void SetLecture(string speaker, int capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void DisplayFullDetail()
    {
        base.DisplayFullDetail();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}\n");
    }

    public override void DisplayShortDiscription()
    {
        Console.WriteLine("Short Discription");
        Console.WriteLine($"Title: {GetTitle()}\nDate: {GetDate()}\n");
        
    }
}