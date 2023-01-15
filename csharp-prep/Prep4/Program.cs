using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        string randomNumber = "-1"; 
        int number = int.Parse(randomNumber);


        

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberEntered = Console.ReadLine();
            number = int.Parse(numberEntered);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }


        int total = 0;

        foreach (int numb in numbers)
        {
            total += numb;

        }

        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total)/numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int large = numbers[0];
        foreach (int numb in numbers)
        {
            if (numb > large)
            {
                large = numb;
            }

        }


        Console.WriteLine($"The Largest number is {large}");
        numbers.Sort();

        foreach (int num in numbers)
        {
            System.Console.WriteLine(num);

        }


        }
       
}