public class VideoManager

{
    public List<Video> videos = new List<Video>();
    

    public VideoManager()
    {
        CreateVideos();
        
    }

    private void CreateVideos()
    {

        Comment coding = new Comment();
        coding.SetName("Marcus");
        coding.SetText("Thanks man! Simple and straight to the point!");

        Comment coding1 = new Comment();
        coding1.SetName("Jay");
        coding1.SetText("Excellent Video. Concise and to the point");

        Comment coding2 = new Comment();
        coding2.SetName("John");
        coding2.SetText("After 2 years of coding I've finally understand the purpose of \"abstract\" thank you! ") ;


        Video video1 = new Video();
        video1.SetTitle("C# abstract classes");
        video1.SetAuthor("Bro Code");
        video1.SetLength(130);
        video1.comments.Add(coding);
        video1.comments.Add(coding1);
        video1.comments.Add(coding2);
        videos.Add(video1);
        




        Comment software = new Comment();
        software.SetName("Todd");
        software.SetText("I am afraid of becoming a software engineer becasue I knew it would be stressful.");

        Comment software1 = new Comment();
        software1.SetName("YK");
        software1.SetText("I totally felt what you said about studying for leetcode");

        Comment software2 = new Comment();
        software2.SetName("Geppy");
        software2.SetText("I appreciate the honest look into the job.");


        Video video2 = new Video();
        video2.SetTitle("The Harch Reality of Being a Software Engineer");
        video2.SetAuthor("Gyasi Linje");
        video2.SetLength(130);
        video2.comments.Add(software);
        video2.comments.Add(software1);
        video2.comments.Add(software2);
        videos.Add(video2);



        Comment job = new Comment();
        job.SetName("Shahirar");
        job.SetText("And here I am don't even know how to even use a computer.");

        Comment job1 = new Comment();
        job1.SetName("Sarathi");
        job1.SetText("Speechless at the level of information shared here.. hat's off to your efforts");

        Comment job2 = new Comment();
        job2.SetName("Anower");
        job2.SetText("You told my four years experience in 8 minute.. You are real man..");

        Comment job3 = new Comment();
        job3.SetName("Matthew");
        job3.SetText("This guy actually is helping us without selling us courses or promoting random stuff. Great Video!");



        Video video3 = new Video();
        video3.SetTitle("FASTEST Way to Learn Coding and ACTUALLY Get a Job");
        video3.SetAuthor("Power Couple");
        video3.SetLength(130);
        video3.comments.Add(job);
        video3.comments.Add(job1);
        video3.comments.Add(job2);
        video3.comments.Add(job3);
        videos.Add(video3);
    }   

    public void DisplayVideos()
    {
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    } 
}