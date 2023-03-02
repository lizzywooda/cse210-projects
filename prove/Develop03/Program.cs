using System;
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        List<string> scripture1 = new List<string>() {"Matthew 5:14-16", "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."};
        (List<Word> instanceList, Reference reference) = scripture.SplitWords(scripture1);
        scripture.DisplayScripture(instanceList, reference);

        bool check = true;
        while (check)
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide words. Type 'quit' when done.");
            string response = Console.ReadLine();

            if (response != "quit")
            {
                instanceList = scripture.HideWords(instanceList, 4);
            }
            else
            {
                check = false;
            }

            scripture.DisplayScripture(instanceList, reference);

            check = scripture.CheckHiddenWords(instanceList);
        }

    }
}