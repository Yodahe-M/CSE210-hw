using System;


class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            

            return name;
        }

        int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int favNumber = int.Parse(number);

            // int number = int.Parse(Console.ReadLine());
            

            return favNumber;
        }

        int SquareNumber(int favNumber)
        {
            int square = favNumber * favNumber;
            return square;
        }


        void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }




    }
}