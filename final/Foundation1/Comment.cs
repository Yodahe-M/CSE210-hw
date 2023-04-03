using System;

public class Comment
{
    private string _name;
    private string _text;



    public void SetName(string name)
    {
        _name = name;
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public void DisplayCommentDetails()

    {
        Console.WriteLine($"{_name} - {_text}");
    
    }


}