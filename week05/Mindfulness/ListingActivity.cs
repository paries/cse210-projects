class ListingActivity : Activity
{
    private List<String> _prompts;
    public ListingActivity() :base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<String>();
        _prompts.Add("What are some things you are grateful for today?");
        _prompts.Add("Who are people who have helped you recently?");
        _prompts.Add("What are blessings you have noticed this week?");
        _prompts.Add("When have you felt Heavenly Father's love in your life?");
        _prompts.Add("What are talents you would like to develop?");
        _prompts.Add("Who are people you could serve this week?");
        _prompts.Add("What are moments that made you smile recently?");
        _prompts.Add("Who are people who have been good examples to you?");
        _prompts.Add("When have you seen a prayer answered?");
        _prompts.Add("What are qualities you admire in your friends or family?");
    }

    public void Run()
    {
        int count = 0;

        Console.Clear();
        Console.Write("Get Ready.....");
        Thread.Sleep(2000);



        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n --- {GetRandomPrompt()} --- ");

        Console.Write("\nYou may begin in: ");
        ShowCountDown(6);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        do
        {
            count++;
            Console.Write("> ");
        } while (DateTime.Now < endTime);

        Console.WriteLine($"You have listed {count} items!");
        Console.WriteLine();
    }

    public String GetRandomPrompt()
    {
        return GetRandomStringFromList(_prompts);
    }
    
}