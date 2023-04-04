using System;
public class Running : Activity
{
    private double _distance;

    public void SetDistance(double distance)
    {
        _distance = distance;
    }
  
    public override void DisplaySummary()
    {
        double speed = (_distance/GetLength()) * 60;
        double pace = GetLength() / _distance;
        Console.WriteLine($"\n{GetDate()} Running ({GetLength()}- Distance) {_distance} miles, Speed {speed:.##} mph, Pace: {pace:.##} min per km");

        

    }
}