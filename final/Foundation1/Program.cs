using System;

class Program
{
    static void Main(string[] args)
    {



        Comment coding = new Comment();
        coding._name= "Marcus";
        coding._text = "Thanks man! Simple and straight to the point!";
    
        Comment coding1 = new Comment();
        coding1._name= "Jay";
        coding1._text = "Excellent Video. Concise and to the point";

        Comment coding2 = new Comment();
        coding2._name = "John";
        coding2._text = "After 2 years of coding I've finally understand what the purpose of \"abstract\" thank you! " ;


        Video video1 = new Video();
        video1._title = "C# abstract classes";
        video1._author = "Bro Code";
        video1._length = 130;
        video1.comments.Add(coding);
        video1.comments.Add(coding1);
        video1.comments.Add(coding2);
        video1.DisplayVideoDetails();




        Comment software = new Comment();
        software._name= "Todd";
        software._text = "I am afraid of becoming a software engineer becasue I knew it would be stressful.";
    
        Comment software1 = new Comment();
        software1._name= "YK";
        software1._text = "I totally felt what you said about studying for leetcode";

        Comment software2 = new Comment();
        software2._name = "Geppy";
        software2._text = "I appreciate the honest look into the job." ;


        Video video2 = new Video();
        video2._title = "The Harch Reality of Being a Software Engineer";
        video2._author = "Gyasi Linje";
        video2._length = 130;
        video2.comments.Add(software);
        video2.comments.Add(software1);
        video2.comments.Add(software2);
        video2.DisplayVideoDetails();



        Comment job = new Comment();
        job._name= "Shahirar";
        job._text = "And here I am don't even know how to even use a computer.";
    
        Comment job1 = new Comment();
        job1._name= "Sarathi";
        job1._text = "Speechless at the level of information shared here.. hat's off to your efforts";

        Comment job2 = new Comment();
        job2._name = "Anower";
        job2._text = "You told my four years experience in 8 minute.. You are real man.." ;

        Comment job3 = new Comment();
        job3._name = "Matthew";
        job3._text = "This guy actually is helping us without selling us courses or promoting random stuff. Great Video!" ;



        Video video3 = new Video();
        video3._title = "FASTEST Way to Learn Coding and ACTUALLY Get a Job";
        video3._author = "Power Couple";
        video3._length = 130;
        video3.comments.Add(job);
        video3.comments.Add(job1);
        video3.comments.Add(job2);
        video3.comments.Add(job3);
        video3.DisplayVideoDetails();














        
        // video1.comments.Add(theHouse1);
       
        
        // video1.DisplayVideoDetails();
        // foreach( Comment comment in video1.comments)
        // {
        //     comment.DisplayCommentDetails();
        // }

    }
}