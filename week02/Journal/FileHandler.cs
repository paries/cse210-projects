public class FileHandler
{
    public static void Save(String filename, List<Entry> _entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                String row = $"{entry._prompt}~{entry._entry}~{entry._date}";
                outputFile.WriteLine(row);
            }
        }

    }
    public static List<Entry> Load(String filename)
    {
        List<Entry> _entries = new();
        string[] fileData = System.IO.File.ReadAllLines(filename);
        foreach (var row in fileData)
        {
            String[] parsedRow = row.Split("~");
            _entries.Add(new()
            {
                _entry = parsedRow[0],
                _prompt = parsedRow[1],
                _date = parsedRow[2]
            });
        }
        return _entries;
    }

}