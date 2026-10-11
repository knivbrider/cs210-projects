using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep3 World!");
        Random randNumGen = new Random();
        
        string repeater = "y";
        while (repeater == "y")
        {   
            
            int magicNumber = randNumGen.Next(1,101);
            Console.WriteLine("\n\nI have picked the Magic Number!");

            int guess = 0;
            int numGuesses = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess == magicNumber)
                {
                    Console.WriteLine($"It was {magicNumber}! You got it in {numGuesses} guesses! ");
                }
            }

            Console.Write("Do you wish to continue? (y/n): ");
            repeater = Console.ReadLine();
        }
        Console.WriteLine("\n\nThanks for playing!");
    }
}