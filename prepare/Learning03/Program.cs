using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Learning03 World!");

        Fraction myFraction = new Fraction(3,4);
        Console.WriteLine(myFraction.GetTop());
        Console.WriteLine(myFraction.GetBottom());
        myFraction.SetTop(5);
        myFraction.SetBottom(10);
        Console.WriteLine(myFraction.GetTop());
        Console.WriteLine(myFraction.GetBottom());
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetFractionDecimal());
        */

        Fraction myFraction = new Fraction();

        for (int i = 1; i < 21; i++)
        {
            myFraction.SetTop(Random.Shared.Next(1,11));
            myFraction.SetBottom(Random.Shared.Next(1,11));
            Console.WriteLine($"Fraction {i}:\n   - String: {myFraction.GetFractionString()}\n   - Decimal: {myFraction.GetFractionDecimal()}\n\n");

        }
        
    }
}