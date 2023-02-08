using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<Entry> entries = new List<Entry>();
        int option = -1;
        while (option != 5)
        {
            Console.WriteLine("Choose a option: \n1.Write\n2.Display\n3.Load Entry\n4.Save\n5.Quit");
            option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    journal.WriteEntry(entries);
                    break;
                case 2:
                    journal.DisplayEntrys(entries);
                    break;
                case 3:
                    Console.WriteLine("What journal would you like to see: ");
                    string filename = Console.ReadLine();
                    journal.Load(filename);
                    break;
                case 4:
                    journal.SaveEntry(entries);
                    break;
                case 5:
                    Console.WriteLine("Goodbey");
                    break;

                default:
                    break;
            }
        }
    }
}