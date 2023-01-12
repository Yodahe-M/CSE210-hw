using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's Play a guessing game");


        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int magic = int.Parse(magicNumber);



        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        int guess = int.Parse(guessNumber);


    while (guess != magicNumber)
    {

    

        //guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("Lower");
        }

       
        Console.Write("What is your guess? ");
        guessNumber = Console.ReadLine();
        guess = int.Parse(guessNumber);

    }
     Console.WriteLine("You guessed it!");

    
       
    }
}