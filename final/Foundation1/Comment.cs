using System;

public class Comment
{
    public string _name;
    public string _text;

    public void DisplayCommentDetails()

    {
        Console.WriteLine($"{_name} - {_text}");
    
    }


}