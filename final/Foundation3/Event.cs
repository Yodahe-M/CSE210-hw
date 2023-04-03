using System;
public class Event
{
    private string _title;
    private DateTime _date;
    private TimeOnly _time;
    private string _discription;
    private Address _address;


    public void DisplayStandardDetail()
    {
        Console.WriteLine($"{_title}, {_discription}, {_date}, {_time}, {_address.GetAddress()}");
    }

    public virtual void DisplayFullDetail()
    {
        Console.Write($"{_title}, {_discription}, {_date}, {_time}, {_address.GetAddress()} ");
    }

    public void DisplayShortDiscription()
    {
        
    }
}