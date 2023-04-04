using System;
public abstract class Event
{
    private string _title;
    private DateOnly _date;
    private TimeOnly _time;
    private string _discription;
    private Address _address;

    public string GetTitle()
    {
       return _title;
    }

    public DateOnly GetDate()
    {
        return _date;
    }

    public void SetEvent(string title, DateOnly date, TimeOnly time, string discription, Address address)
    {
        _title = title;
        _date = date;
        _time = time;
        _discription = discription;
        _address = address;
    }
    public void DisplayStandardDetail()
    {
        Console.WriteLine($"\nStandard Detail");
        Console.WriteLine($"Title: {_title}\nDiscription: {_discription}\nDate: {_date}\nTime: {_time}\n{_address.GetAddress()}\n");
    }

    public virtual void DisplayFullDetail()
    {
        Console.WriteLine($"Full Detail");
        Console.Write($"Title: {_title}\nDiscription: {_discription}\nDate: {_date}\nTime: {_time}\n{_address.GetAddress()}\n");
    }

    public abstract void DisplayShortDiscription();
    
    
}