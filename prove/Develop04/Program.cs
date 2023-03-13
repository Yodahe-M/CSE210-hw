using System;

class Program
{
    static void Main(string[] args)
    {


        Menu menu = new Menu();


        int choice = 1;

        while (choice != 5)
        {
            choice = menu.DisplayMenu();
            
            Activity activity = new Activity();

            if (choice == 1)
            {
                activity = new Breathing();
            }

            if (choice == 2)
            {
                activity = new Reflecting();
            }

            if (choice == 3)
            {
                activity = new Listing();

            }

            if (choice == 4)
            {
                activity = new Observing();
            }
            if (choice == 5)
            {
                 System.Environment.Exit(1);
            }
                activity.DisplayStart();
                activity.DoActivity();
                activity.Displayend();

        }
    }
}
