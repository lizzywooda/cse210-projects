using System;

class Program
{
    static void Main(string[] args)
    {
        // Gets the user input and changes it to a usable int.
        Console.WriteLine("What is your grade percentage?: ");
        var input = Console.ReadLine();
        var percentage = int.Parse(input);
        // Sets the letter variable
        char letter = 'F';
        // Determinds what the letter should be.
        if (percentage >= 90)
        {
            letter = 'A';
        }
        else if (percentage >= 80)
        {
            letter = 'B';
        }
        else if (percentage >= 70)
        {
            letter = 'C';
        }
        else if (percentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }
        // Reports the letter grade.
        Console.WriteLine($"Your letter grade is: {letter}");

        if (letter == 'F' || letter == 'D')
        {
            Console.WriteLine("Sorry you did not pass.");
        }
        else
        {
            Console.WriteLine("You passed! congrats!");
        }
    }
}