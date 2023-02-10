using System;

public class Journal
{

   public List<Entry> entries = new List<Entry>();

   public int GetAction()
   {
      Console.Write("What would you like to do? ");
      string action = Console.ReadLine();
      int actionValue = int.Parse(action);

      return actionValue;
   }


   public void DisplayJournal ()
   {
      Entry _entry = new Entry ();
      // _entry.DisplayEntry();
   }

   public void SaveJournal()
   {
      Console.WriteLine("What is the file name? ");
      string fileName = Console.ReadLine();


      using (StreamWriter outputFile = new StreamWriter(fileName))
      {
            foreach(Entry entry in entries)
            {
               outputFile.WriteLine($"{entry._entry}");
            // You can add text to the file with the WriteLine method

            }

      }
   }

   public void LoadJournal()
   {
      Console.WriteLine("What is the file name? ");
      string fileName = Console.ReadLine();


      string[] lines = System.IO.File.ReadAllLines(fileName);

      foreach (string line in lines)
      {
         Entry entry = new Entry();
         entry._entry = line;
         entries.Add(entry);
      }
   }

}

 
 