using System;

class Program
{
    static void Main(string[] args)
    {


        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("1. Lecture");
            Console.WriteLine("2. Reception");
            Console.WriteLine("3. Outdoor");
            Console.WriteLine("4. quit");

            Console.Write("Please Enter a number");
            choice = int.Parse(Console.ReadLine());
            

            if (choice == 1)
            {
                Address address1 = new Address();
                address1.SetStreetAddress("123 Main Street", "San Diego", "CA","USA");
                Lecture lecture= new Lecture();
                lecture.SetEvent("The Power of Positive Thinking", new DateOnly (2023,05,10), new TimeOnly(2, 0, 0), "Join us for an inspiring lecture on the power of positive thinking", address1);
                lecture.SetLecture("Dr. Jane Smith", 100);
                lecture.DisplayStandardDetail();
                lecture.DisplayFullDetail();
                lecture.DisplayShortDiscription();
            }

            else if (choice == 2)
            {
                Address address2 = new Address();
                address2.SetStreetAddress("456 Park Avenue", "Kaysvill", "UT", "USA");
                Reception reception = new Reception();
                reception.SetEvent("Summer Mixer", new DateOnly (2023, 06, 15), new TimeOnly(6, 0, 0), "Join us for a fun summer mixer! There will be food, drinks, and plenty of opportunities to network with other professionals.", address2);
                reception.DisplayStandardDetail();
                reception.DisplayFullDetail();
                reception.DisplayShortDiscription();
            }

            else if (choice == 3)
            {
                Address address3 = new Address();
                address3.SetStreetAddress("789 Oak Street Park", "Atlanta", "Georgea", "USA");
                Outdoor outdoor = new Outdoor();
                outdoor.SetOutdoor("50°");
                outdoor.SetEvent("Summer Music Festival", new DateOnly (2023,07,22), new TimeOnly (1,0,0), "Come enjoy live music in the sun! This year's lineup includes top artists from around the world.", address3);
                outdoor.DisplayStandardDetail();
                outdoor.DisplayFullDetail();
                outdoor.DisplayShortDiscription();
            }
        }
    }
}