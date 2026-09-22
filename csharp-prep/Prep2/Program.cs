using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        string gradeString; 
        Console.Write("Please enter grade in percentage: ");
        gradeString = Console.ReadLine();
        int gradeNum = int.Parse(gradeString);

        string letter;
        string pass = "You passed the class, good job!";
        string fail = "You sadly did not pass the class this time.\nKeep studying and you can try for a better grade next time.";

        string sign;
        int remainder = gradeNum % 10;
        if (remainder >= 7 && gradeNum >= 60 && gradeNum < 93)
        {
            sign = "+";
        } 
        else if (remainder < 3 && gradeNum >= 60)
        {
            sign = "-";
        } 
        else
        {
            sign = "";
        }
        

        if (gradeNum >= 90)
        {
            letter = $"an A{sign}! {pass}";
        } 
        else if (gradeNum >= 80)
        {
            letter = $"a B{sign}! {pass}";
        }
        else if (gradeNum >= 70)
        {
            letter = $"a C{sign}. {fail}";
        }
        else if (gradeNum >= 60)
        {
            letter = $"a D{sign}. {fail}";
        } else
        {
            letter = $"an F. {fail}";
        };

        Console.WriteLine($"\n\nYour Letter Grade is {letter}\n\n\n");

    }
}