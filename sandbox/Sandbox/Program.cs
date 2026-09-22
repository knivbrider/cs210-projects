using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola Mundo!");
        Console.WriteLine("This is my first C# program!");

        int x = 20;
        int y = 9;
        int z = 3; 
        if (x==10 && y==30 || z==30 ) {
            Console.WriteLine($"X({x}) is 10.");
            Console.WriteLine($"Y({y}) is 30.");
            Console.WriteLine($"Z({z}) is 30.");
        } else if (x==20) {
            Console.WriteLine($"X({x}) is 20.");
        } else {
            Console.WriteLine($"Default Response -> X({x})");
        }

        string numString = "123";
        int myNum = int.Parse(numString);

    }
}