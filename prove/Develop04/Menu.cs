using System;

public class Menu
{

    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");

        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listning activity");
        Console.WriteLine("4. Observing activity");
        Console.WriteLine("5. Quit");

        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        int number = int.Parse(choice);
        Console.Clear();

        return number;

    }


}