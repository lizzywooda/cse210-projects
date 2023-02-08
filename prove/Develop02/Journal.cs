using System;
using System.IO;

class Journal
{
    public List<Entry> WriteEntry(List<Entry> entries)
    {
        Entry entry = new Entry();
        entry.Fill();
        entries.Add(entry);
        return entries;
    }
    public void DisplayEntrys(List<Entry> entries)
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine($"{line}");
        }
    }
    public void SaveEntry(List<Entry> entries)
    {
        Console.WriteLine("What file would you like to save to: ");
        string filename = Console.ReadLine();
        foreach (var entry in entries)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{entry._date} - {entry._prompt} - {entry._userInput}\n");
            }
        }

    }




}