using System;

class Program
{
    static void Main(string[] args)
    {
        // call the DisplayWelcome function
        DisplayWelcome();
        // call the functions to get the user information
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        // call the SquaredNumber funtion with the userNumber
        int squaredNumber = SquareNumber(userNumber);
        // call the DisplayResult function with the user info
        DisplayResult(userName, squaredNumber);

        // displays a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        // Gets the users name
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name; 
        }
        // gets the users favorite number
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        // squares the users favorite number
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        // displays the result of the users favorite number squared and the name
        static void DisplayResult(string name, int square)
        {
        Console.WriteLine($"{name}, the square of your number is {square}");
        }
        
    }
}