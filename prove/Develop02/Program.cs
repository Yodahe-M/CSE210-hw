using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        while (i != 5)
       {
            Console.WriteLine("Please select one of the following choice:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            int userInput = journal.GetAction();

        if (userInput == 1)
        {
            Entry entry = new Entry();
            entry.WriteEntry();
            journal.entries.Add(entry);
        }

        else if (userInput == 2)
        {
            
            
            journal.DisplayJournal();
            
        }

        else if (userInput == 3)
        {
            journal.LoadJournal();   
        }

        else if (userInput == 4)
        {
            journal.SaveJournal();
        }

        else if (userInput == 5)
        {
            System.Environment.Exit(1);
        }
       

       }
   
    }
}