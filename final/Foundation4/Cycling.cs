using System;
public class Cycling : Activity
{
    private double _speed;


    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
   

    public override void DisplaySummary()
    {
        double distance = (_speed * GetLength()) / 60;
        double pace = GetLength() / distance;
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()}- Distance) {distance} miles, Speed {_speed} mph, Pace: {pace:.##} min per km");

    }
}