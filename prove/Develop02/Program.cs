using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myjournal = new Journal();

        int Response = 0;

        while (Response != 5)
        {
            Response = myMenu.ProcessMenu();
            switch(Response)
            {
                case 1:
                    myjournal.CreateEntry();
                    break;

                case 2:
                    myjournal.DisplayJournal();
                    break;

                case 3:
                    myjournal.WriteToFile("JournalSaveFile.txt");
                    break;

                case 4:
                    myjournal.ReadFromFile("JournalSaveFile.txt");
                    break;
            }
        }


    }
}