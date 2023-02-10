using System;



    public class Entry{
        public string _date;
        public string _entry;
        public string _prompt;
    


    public void WriteEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        Prompt newPrompt = new Prompt();
        _prompt = newPrompt.DisplayPrompt();

        Console.WriteLine(_prompt);
        string entry = Console.ReadLine();

       _entry = ($"Date: {_date} - Prompt: {_prompt} {entry}");    
    }

    public void DisplayEntry()
    {
        Console.WriteLine(_entry);
    }

    }

    
    

    
