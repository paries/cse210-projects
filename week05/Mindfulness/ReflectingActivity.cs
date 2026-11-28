class ReflectingActivity : Activity
{
    private List<String> _prompts;
    private List<String> _questions;
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on the times in your life when you have shown strength and resilience. "+
                                                             "This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        _prompts = new List<String>();
        _questions = new List<String>();

        _prompts.Add("Think of a time when you forgave someone who hurt you.");
        _prompts.Add("Think of a time when you told the truth even though it was hard.");
        _prompts.Add("Think of a time when you kept going after you wanted to give up.");
        _prompts.Add("Think of a time when you made someone feel welcome.");
        _prompts.Add("Think of a time when you admitted you were wrong.");
        _prompts.Add("Think of a time when you tried something new even though you were nervous.");
        _prompts.Add("Think of a time when you learned something important from a mistake.");
        _prompts.Add("Think of a time when you listened to someone who needed to be heard.");
        _prompts.Add("Think of a time when you did the right thing even though no one was watching.");
        _prompts.Add("Think of a time when someone's kindness changed your day, and how you passed it on.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        Console.Clear();
        Console.Write("Get Ready.....");
        Thread.Sleep(2000);

        Console.WriteLine($"\n --- {GetRandomPrompt()} --- ");

        Console.Write("\nWhen you have something in mind, press enter to continue");
        String userInput = Console.ReadLine();

        Console.WriteLine($"\nNow ponder on each of the following questions as they relate to this experience. ");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(6);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        do
        {
            Console.Write($"{GetRandomQuestion()}  ");
            ShowSpinner(6);
            Console.WriteLine();
        } while (DateTime.Now < endTime);

        Console.WriteLine();
    }

    public String GetRandomPrompt()
    {
        return GetRandomStringFromList(_prompts);
    }

    public String GetRandomQuestion()
    {
        return GetRandomStringFromList(_questions);
    }

}