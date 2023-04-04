using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = 0;

        List <Activity> activities = new List<Activity>();

        
        while (choice != 5)
        {

            System.Console.WriteLine("1. Add Running");
            System.Console.WriteLine("2. Cycling");
            System.Console.WriteLine("3. Swimming");
            System.Console.WriteLine("4. Display Activities");
            System.Console.WriteLine("5. Quit");
            System.Console.Write("Please pick activity to see your score: ");
            choice = int.Parse(Console.ReadLine());

            

            if (choice == 1)
            {

                Running running = new Running();
                running.SetDistance(23);
                running.SetSummary(56);
                activities.Add(running);
                System.Console.WriteLine("\nActivity added");
            }

            else if (choice == 2)
            {
                Cycling cycling = new Cycling();
                cycling.SetSpeed(45);
                cycling.SetSummary(12);
                activities.Add(cycling);
                System.Console.WriteLine("\nActivity added");

            }

            else if (choice == 3)
            {
                Swimming swimming = new Swimming();
                swimming.SetLaps(40);
                swimming.SetSummary(15);
                activities.Add(swimming);
                System.Console.WriteLine("\nActivity added");

            }

        
           else if (choice == 4)
           { 
            
            foreach(Activity activity in activities)
            {
                    activity.DisplaySummary();
            }
           }
        }

    }
}