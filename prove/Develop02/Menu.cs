class Menu
{
    public int ProcessMenu()
    {
        //Console.WriteLine("Menu.cs test");

        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program:");
            Console.WriteLine("+=====================================+");
            Console.WriteLine("|    1. Create new jouranl entry      |");
            Console.WriteLine("|    2. Display journal entry         |");
            Console.WriteLine("|    3. Save to file                  |");
            Console.WriteLine("|    4. Read from file                |");
            Console.WriteLine("|    5. Quit                          |");
            Console.WriteLine("+=====================================+");
            Console.Write(">>> ");

            input = int.Parse(Console.ReadLine());
        }

        return input;
    }
}