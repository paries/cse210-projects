using System.Runtime.InteropServices;

class BreathingActivity : Activity
{
    public BreathingActivity()
            : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void Run()
    {
        Console.Clear();
        Console.Write("Get Ready.....");
        Thread.Sleep(2000);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        do
        {
            BreatheIn(6);
            BreatheOut(6);
        } while (DateTime.Now < endTime);

    }
    
    protected void BreatheIn(int seconds)
    {
        for (int remaining = seconds; remaining >= 0; remaining--)
        {
            String circles = new String('<', remaining).PadRight(seconds);
            Console.Write($"\rBreathe In.. {circles}{remaining}");
            Thread.Sleep(1000);
        }
        Console.Write($"\r");
        Console.WriteLine();
    }
    protected void BreatheOut(int seconds)
    {
        for (int remaining = 0; remaining < seconds; remaining++)
        {
            String circles = new String('>', remaining).PadRight(seconds);
            Console.Write($"\rNow breathe out.. {circles}{seconds - remaining}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}