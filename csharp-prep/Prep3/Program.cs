using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        // Set number to be guessed
        int number = randomGenerator.Next(1, 100);
        
        int guess = 0;
        // Set the while loop for the game to play till the right guess is made
        while (guess != number)
        {
            Console.Write("Guess a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Try Lower.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Try higher.");
            }
            else
            {
                Console.WriteLine("That's Right!");
            }
        }
    }
}