using System;

public class Reflecting : Activity
{
    public Reflecting()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }


    public void DisplayPromptRef()
    {

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");

        List<string> reflectionPrompt = new List<string>(){
            "Think of a time when you stood up for someone else", "Think of a time when you did something really difficult.", 
            "Think of a time when you helped soemone in need.", "Think of a time when you did something truly selfless.",
        };

        Random randomPropmt = new Random();
        int randomIndex = randomPropmt.Next(reflectionPrompt.Count);
        
        string reflectionPromptQuestion = (reflectionPrompt [randomIndex]);
        Console.WriteLine();
        Console.WriteLine($"--- {reflectionPromptQuestion} ---");


        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

    }


    public void DisplayQuestionPrompt()
    {

        List<string> questionPrompt = new List<string>(){
            "Why was this experience meaningful to you? ", "Have you ever done naything like this before?", 
            "How did you get started? ", "How did you feel whne it was complete? ",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Console.WriteLine("Now ponder on each of the following questions as they related to this experiacne. ");

        Console.Write("You may begin in: ");
        PauseCountDown();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        SetFutureTime(futureTime);

        while (! CalculateTime())
        {
            Random randomPropmt = new Random();
            int randomIndex = randomPropmt.Next(questionPrompt.Count);
        
            string reflectionPromptQuestion = (questionPrompt [randomIndex]);
            Console.Write($"\n> {reflectionPromptQuestion} ");
            PauseSpinner();
            Console.WriteLine();
        }
    }

    public override void DoActivity()
    {
        DisplayPromptRef();
        DisplayQuestionPrompt();
    }


    
    
        

}