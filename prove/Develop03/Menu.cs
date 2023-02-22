using System;

public class Menu
{


    public int DisplayMenu()
    {
        
        Console.WriteLine("Menu options: ");

        Console.WriteLine("1. Chocolate Chip Cookies");
        Console.WriteLine("2. Banana Bread");
        Console.WriteLine("3. Fried Rice");
        Console.WriteLine("4. Quit");

        Console.Write("What would you like to cook? ");
        string choice = Console.ReadLine();
        int number = int.Parse(choice);

        return number;



    }

       

}