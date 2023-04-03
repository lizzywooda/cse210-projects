using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activity1 = new List<Activity>();
        Running run1 = new Running("03 Nov 2022",30 ,"Running", 3);
        activity1.Add(run1);

        Swimming swim1 = new Swimming("03 Nov 2022", 30, "Swimming",5);
        activity1.Add(swim1);

        Bike bike1 = new Bike("07 Nov 2022", 60, "Biking", 8);
        activity1.Add(bike1);
        Console.WriteLine();
        Console.WriteLine("Activity List");
        Console.WriteLine();
        foreach (var activity in activity1){
            Console.WriteLine(activity);
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
      
        
    }
}