public class Listing : Activity
{

    private List<string> itemLists = new List<string>();

    public Listing() 
    {
        SetName("Listing");
        SetDescription ("This activity will help you reflect on times in your life when you have shown strength and reselience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    }

    //public List<string> inputList = new List<string>();


    public void DisplayPrompt()
    {

        Console.WriteLine("List as many responses you can to the following prompt: ");

        List<string> prompts = new List<string>(){
        "who are the people that you appreciate? ", "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes? "
        
    };

        Random randomPropmt = new Random();
        int randomIndex = randomPropmt.Next(prompts.Count);
        
        string promptQuestion = (prompts [randomIndex]);
        Console.WriteLine($"--- {promptQuestion} ---");
         
        Console.WriteLine($"You may begin in: ");
        PauseCountDown();
        // string list = Console.ReadLine();

    }

    public void DisplayNumberOfAnswers()
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        SetFutureTime(futureTime);

        while (! CalculateTime())
        {
                
            Console.Write("> ");
            string input = Console.ReadLine();
            itemLists.Add(input);
            
         
        }
        
        System.Console.WriteLine($"You have {itemLists.Count()}");

        
        
    }

    public override void DoActivity()
    {
        DisplayPrompt();
        DisplayNumberOfAnswers();
    }
}


