using System;
public class Reception : Event
{
    private string _email;

    private List <string> _emails = new List<string>()
    {
        "john.doe@gmail.com",
        "sarah.smith@yahoo.com",
        "jennifer.lee@hotmail.com",
        "robert.brown@outlook.com",
        "david.jones@aol.com",
        "laura.johnson@icloud.com",
        "andrew.jackson@protonmail.com",
        "karen.williams@mail.com",
        "samuel.harris@gmx.com",
        "elizabeth.thomas@inbox.com"
    };
    

    public override void DisplayFullDetail()
    {
        base.DisplayFullDetail();
        Console.WriteLine($"People that have registred: ");
        foreach(string email in _emails)
        {
            System.Console.WriteLine(email);
        }
    }

    public override void DisplayShortDiscription()
    {
        Console.WriteLine("\nShort Discription");
        Console.WriteLine($"Title: {GetTitle()}\nDate: {GetDate()}\n");
        
    }
}