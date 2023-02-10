using System;



public class Prompt
{
    public List<string> _prompts = new List<string>
    {
        "How was your day?", "Best part of your day?", "Spiritual experiance you had this week?", "Who did you talk to?"
    };
    
    public string DisplayPrompt()
    {
        Random randomPropmt = new Random();
        int randomIndex = randomPropmt.Next(_prompts.Count);
        
        string promptQuestion = (_prompts [randomIndex]);
        return promptQuestion;
    }
}