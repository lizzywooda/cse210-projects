class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string _firstChoice =" ";
        while(_firstChoice!="7")
        {
            Console.WriteLine();
            goalManager.DisplayGoalPointTotal();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Delete A Goal");
            Console.WriteLine("   7. Quit");
            Console.Write("Select a choice from the menu: ");
            _firstChoice = Console.ReadLine();
            switch (_firstChoice)
            {
                case "1":
                    int secChoice = 0;
                    Console.WriteLine();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("   1: Simple Goal\n   2: Eternal Goal\n   3: Checklist Goal");
                    Console.Write("What type of goal would you like to create? ");
                    secChoice = int.Parse(Console.ReadLine());
                    RunChoice(secChoice.ToString(), goalManager);
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("The goals are:");
                    goalManager.DisplayGoals();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Write("What file would you like to save to? ");
                    string filename = Console.ReadLine();
                    goalManager.Save(filename);
                    break;
                case "4":
                    Console.Write("What file would you like to load from? ");
                    string filenameload = Console.ReadLine();
                    goalManager.Load(filenameload);
                    Console.WriteLine("Load from txt");
                    break;
                case "5":
                    Console.WriteLine("Record a completed goal");
                    goalManager.DisplayGoals();
                    Console.Write("Which Goal did you complete? ");
                    string number = Console.ReadLine();
                    Console.WriteLine();
                    goalManager.MarkComplete(int.Parse(number));
                    goalManager.DisplayGoalPointTotal();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();    
                    Console.Clear();
                    break;
                case "6":
                    Console.WriteLine("Delete a  goal");
                    goalManager.DisplayGoals();
                    Console.Write("Which Goal do you want to delete? ");
                    string deleteNumber = Console.ReadLine();
                    Console.WriteLine();
                    goalManager.DeleteGoal(int.Parse(deleteNumber));
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();    
                    Console.Clear();
                    break;
                case "7":
                    Console.WriteLine("Quit !Thanks  for using our program!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error, please enter a valid choice.");
                    Thread.Sleep(3000);
                    break;
            }
        }
    }
    private static void RunChoice(string x, GoalManager goalManager)
    {   
        if(x == "1" ||x ==  "2" ||x ==  "3" ){
            Console.Clear();
            Console.Write("What is the name of your goal: ");
            string goalName=Console.ReadLine();
            Console.Write("Describe your goal: ");
            string goalDescription = Console.ReadLine();
            Console.Write("How many points is this worth? ");
            int points=int.Parse(Console.ReadLine());

            int duration = 0;
            int bonusPoints = 0;
            if (x == "3")
            {
                Console.Write("How many times do you want to complete this goal? ");
                duration = int.Parse(Console.ReadLine());
                Console.Write("How many Bonus points is this worth? ");
                bonusPoints=int.Parse(Console.ReadLine());
            }
            goalManager.AddGoal(x, goalName, goalDescription, points, duration, bonusPoints);
        }
        else{
            Console.WriteLine(" Error please select a valid option.");
        }    
    }
}