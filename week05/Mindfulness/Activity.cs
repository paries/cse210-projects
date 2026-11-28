class Activity
{
    private String _name;
    private String _description;
    private int _duration;

    public Activity(String name, String description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.WriteLine($"\n{_description}");
        do
        {
            Console.Write("\nHow long in seconds, would you like for your session? ");
            String userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int duration) && duration > 0)
            {
                _duration = duration;
                break;
            }
        } while (true);
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
        Console.WriteLine();
    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        do
        {
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
        } while (DateTime.Now < endTime);
        Console.Write("\b \b");
    }
    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        do
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        } while (DateTime.Now < endTime);
    }

    public String GetRandomStringFromList(List<String> list)
    {
        Random randomGenerator = new Random();
        return list[randomGenerator.Next(0, list.Count)];
    }
}