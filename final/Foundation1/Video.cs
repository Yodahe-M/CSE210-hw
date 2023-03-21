using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> comments = new List<Comment>();

   
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