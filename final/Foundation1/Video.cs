using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    public List<Comment> comments = new List<Comment>();

    
    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public void SetLength(int length)
    {
        _length = length;
    }


    



    public void DisplayVideoDetails()
    {


        Console.WriteLine($"Video Name: {_title}");
        Console.WriteLine($"Video Author {_author}");
        Console.WriteLine($"Video Length {_length} seconds");

        Console.WriteLine("Comments:");

        foreach (Comment comment in comments)
        {
            comment.DisplayCommentDetails();
            
        }

        Console.WriteLine($"There are {comments.Count()} comments.\n"); 
        
    }


    
}