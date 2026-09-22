using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Please input first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please input last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}