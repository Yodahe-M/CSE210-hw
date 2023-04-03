using System;
public class Menu
{

    public int DisplayMenu()
    {
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Go to Cart");
        Console.WriteLine("3. Add your information");
        Console.WriteLine("4. Place your order");

        Console.Write("Please select from Menu: ");
        string choice = Console.ReadLine();
        int number = int.Parse(choice);
        Console.Clear();

        return number;


    }
}