using System;
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public override void DisplayFullDetail()
    {
        base.DisplayFullDetail();
        Console.WriteLine($"{_speaker}, {_capacity}");
    }
}