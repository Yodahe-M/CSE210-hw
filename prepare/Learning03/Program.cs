using System;

class Program
{
    static void Main(string[] args)
    {
       
        Fraction fraction1 = new Fraction(1/1);
        fraction1.SetTop(1);
        fraction1.SetBottom(1);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());


        Fraction fraction2 = new Fraction(6/1);
        fraction2.SetTop(6);
        fraction2.SetBottom(1);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        


        Fraction fraction3 = new Fraction(6/7);
        fraction3.SetTop(3);
        fraction3.SetBottom(4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());


    }
}


// another way of doing it
/*
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
*/