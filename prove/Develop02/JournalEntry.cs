class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry(string date = "NEW", string prompt = "NEW", string response = "NEW")
    {
        if (date == "NEW" && prompt == "NEW" && response == "NEW")
        {

            string [] prompts =
            {
                //Prompts generated with help from AI, but all code was written by myself
                "How was your day?",
                "What was the most surprising moment of your day?",
                "What is one thing that made you smile today?",
                "What was the biggest challenge you faced today?",
                "How did you take care of yourself today?",
                "What are you most grateful for right now?",
                "What is something new you learned or noticed today?",
                "Where did you spend most of your energy today?",
                "What was the best meal or snack you had today?",
                "How are you feeling today?",
                "What is one intention you want to set for tomorrow?"
            };

            _date = DateTime.Now.ToString();
            _prompt = prompts[Random.Shared.Next(11)];
            Console.Write($"{_prompt}: ");
            _response = Console.ReadLine();
        } else
        {
            _date = date;
            _prompt = prompt;
            _response = response;
        }
        
    }

    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }


}