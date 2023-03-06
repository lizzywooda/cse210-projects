using System;

class Program
{
    static void Main(string[] args)
    {
        int _userChoice = 0;

        while (_userChoice != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            _userChoice = int.Parse(Console.ReadLine());

            Activity activity = null;
            switch (_userChoice)
            {
                case 1:
                    activity = new Breathing();
                    activity.DisplayActivity();
                    break;
                case 2:
                    activity = new Reflection();
                    activity.DisplayActivity();
                    break;
                case 3:
                    activity = new Listing();
                    activity.DisplayActivity();
                    break;
                case 4:
                    Console.WriteLine("Have a good day!");
                    break;
                default:
                    break;
            }
        }
    }
}