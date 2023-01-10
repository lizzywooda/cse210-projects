using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number to add to the list, enter 0 to quit: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        
        foreach (int i in numbers)
        {
            total += i;
        }

        Console.WriteLine($"The total is: {total}");

        float avg = total / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = numbers[0];

        foreach (int i in numbers)
        {
            if (max < i)
            {
                max = i;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}