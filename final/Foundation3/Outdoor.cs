using System;
public class Outdoor : Event
{
    private string _weather;

    public void SetOutdoor(string weather)
    {
        _weather = weather;
    }

    public override void DisplayFullDetail()
    {
        base.DisplayFullDetail();
        Console.WriteLine($"Weather: {_weather}");
    }

    public override void DisplayShortDiscription()
    {
        Console.WriteLine($"\nShort Discription");
        Console.WriteLine($"Title: {GetTitle()}\nDate: {GetDate()}\n");
        
    }
}