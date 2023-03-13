using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _futureTime;

    public int GetDuration()
    {
        return _duration;
    }

    public void SetFutureTime(DateTime futureTime)
    {
        _futureTime = futureTime;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public bool CalculateTime()
    {
        
        DateTime currentTime = DateTime.Now;
        if (currentTime < _futureTime)
        {
            return false;
        }

        else
            {
                return true;
            }
    }

   

    public void DisplayStart()
    {

        Console.WriteLine($"Welcome to the {_name} Activity");

        Console.WriteLine($"\n{_description}");


        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        string second = Console.ReadLine();
        int time = int.Parse(second);
        _duration = time;
        Console.Clear();

        Console.WriteLine("Get ready...");
        PauseSpinner();

    }

    public void Displayend()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        PauseSpinner();

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        PauseSpinner();
        Console.Clear();
    }


    public void PauseSpinner()
    {
        List<string> animationStrings = new List<string>();

        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PauseCountDown()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public virtual void DoActivity() { }
}

