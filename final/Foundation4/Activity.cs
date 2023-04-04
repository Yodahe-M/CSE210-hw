using System;
public class Activity
{
    private DateOnly _date;
    private double _length;
    


    
    public void SetSummary(double length)
    {
        _date = DateOnly.FromDateTime(DateTime.Today);
        _length = length;
        
    }

    public virtual void DisplaySummary(){}

    

    public double GetLength()
    {
        return _length; 
    }

    public string GetDate()
    {
        return ($"{_date.ToShortDateString()}");
    }



    
}