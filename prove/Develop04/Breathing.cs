using System;

public class Breathing : Activity
{
    public Breathing() 
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and our slowly. Clear your mind and focus on your breathing.");
    }

    public void DisplayBreathIn()
    {
        
        Console.Write("\nBreathe in...");
        PauseCountDown();
        
    }


    public void DisplayBreathOut()
    {

        Console.Write("\nNow breathe out...");
        PauseCountDown();
        Console.WriteLine();

    }

    public override void DoActivity()
    {
       
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        SetFutureTime(futureTime);
        
        while (! CalculateTime())
        {

            DisplayBreathIn();
            DisplayBreathOut();
            
        }

    }
}