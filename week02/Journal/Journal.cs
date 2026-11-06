using System.Text.Json;

class Journal
{
    private List<Entry> _entries = new();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Load(String filename)
    {
        _entries = FileHandler.Load(filename);
        Console.WriteLine($"Your journal has been loaded from {filename}");
    }

    public void Save(String filename)
    {
        FileHandler.Save(filename, _entries);
        Console.WriteLine($"Your journal has been saved to {filename}");
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

}