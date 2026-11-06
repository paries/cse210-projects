
public class Entry
{
    public String _prompt;
    public String _entry;
    public String _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
        Console.WriteLine();
    }
}