using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    /*
    static double AddNumbers(double x, int y)
    {
        return x + y;
    }

    static string MyName()
    {
        return "Bob";
    }

        static void DisplayGreeting(string name)
        {
            Console.WriteLine($"Welcome {name}, its nice to meet you!");
        }
        */

    static void Main(string[] args)
    {
        /*
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
        

        bool done = false;
        while (!done)
        {
            Console.Write("Are we done yet? (y/n):");
            done = Console.ReadLine() == "y";
        }
                

        bool done = true;        
        do 
        {
            Console.Write("Are we done yet? (y/n):");
            done = Console.ReadLine().ToLower() == "y";
        } while (!done);

        for(int i=0; i<10; i++)
        {
            Console.WriteLine(i);
        };
       

        for(double i=0; i<1.0; i+=1)
        {
            Console.WriteLine(i);
        }       
         

        string myName = MyName();
        DisplayGreeting(myName);
        double total = AddNumbers(12.234,20);
        Console.WriteLine(total);
        
        */

        Circle myCircle = new Circle();
        myCircle._radius = 10;
        double area = myCircle.GetArea();
        Console.WriteLine(area);

    }
}