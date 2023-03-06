public class Breathing : Activity
{
    public Breathing()
    :base( "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public override void DisplayActivity()
    {
        base.DisplayActivity();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(Duration);

        while (currentTime < futureTime)
        {
            Console.WriteLine();           
            Console.Write("Breathe In... ") ;
            Timer(3);
            Console.Write("\b \b");
            Console.WriteLine();
            
            Console.Write("Now breathe Out... ");
            Timer(3);
            Console.Write("\b \b");
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        DisplayTheEnd();
    }
}