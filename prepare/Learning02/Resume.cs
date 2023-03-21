public class Resume
{
    public string _givenName;
    public string _familyName;

    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_givenName} {_familyName}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
}