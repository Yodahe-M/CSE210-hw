using System;
public class Swimming : Activity
{
    private int _laps;
    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public override void DisplaySummary()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        double speed = (distance / GetLength()) * 60;
        double pace = GetLength() / distance;
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()}- Distance) {distance} miles, Speed {speed} mph, Pace: {pace:.##} min per mile\n");
    }
}