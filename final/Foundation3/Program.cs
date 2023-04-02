using System;

class Program
{
    static void Main(string[] args)
    {
        Event event1 = new Lecture("The Lorax", 300);
        event1.getEvent("The Effects of Tree Cutting", "An extended review of deforestation", "Lecture Series", "April 28, 2023", "4:30 PM - 7:00 PM","Pilchuck Tree Farm - 1624 300th St NW, Arlington, WA 98223");
        Console.Write(event1.getShort());
        Console.Write(event1.getStandard());
        Console.Write(event1.getDetails());
        Console.Write("Hit enter to see the next event ");
        Console.ReadLine();
        Console.Clear();

        Event event2 = new Lecture("William H. Burn", 150);
        event2.getEvent("A Study in Cremation", "Advantages and Disadvantages of Crematory Practices", "Lecture", "May 31, 2023", "5:00PM - 6:00PM", "Hotel Indigo - 1028 13th St., Everett, WA 98201");
        Console.Write(event2.getShort());
        Console.Write(event2.getStandard());
        Console.Write(event2.getDetails());
        Console.Write("Hit enter to see the next event ");
        Console.ReadLine();
        Console.Clear();

        Event event3 = new Reception("romiet@gettingmarried.com");
        event3.getEvent("Montague and Capulet Wedding Reception", "Come see Romeo and Juliet tie the knot!", "Wedding and Reception", "April 15, 2023", "6:00 PM - 10:00 PM", "Happy Valley Lutheran Church and Cemetery, Stanwood, WA" );
        Console.Write(event3.getShort());
        Console.Write(event3.getStandard());
        Console.Write(event3.getDetails());
        Console.Write("Hit enter to see the next event ");
        Console.ReadLine();

        Event event4 = new Reception("solongstan@knightbusevents.com");
        event4.getEvent("Stan Shunpike Retirement Reception", "Join us as we say farewell to the best seating usher the Knight Bus ever had!", "Retirement Reception", "July 31, 2023", "5:00PM - 7:00PM", "Everett Bus Station - 3201 Smith Ave #103, Everett, WA 98201");
        Console.Write(event4.getShort());
        Console.Write(event4.getStandard());
        Console.Write(event4.getDetails());
        Console.Write("Hit enter to see the next event ");
        Console.ReadLine();

        Event event5 = new Outdoor("Partly Cloudy, 20% chance rain, High: 76 - Low: 65");
        event5.getEvent("Colors Comeback Tour", "We're getting the band back together- one night only!", "Outdoor Concert", "June 25, 2023", "7:00PM - 11:00PM", "Amphitheater - NE 74th St, Seattle, WA 98115");
        Console.Write(event5.getShort());
        Console.Write(event5.getStandard());
        Console.Write(event5.getDetails());
        Console.Write("Hit enter to see the next event ");
        Console.ReadLine();

        Event event6 = new Outdoor("100% chance snow, High: 29 - Low 15");
        event6.getEvent("Seattle Snow Shoveling Invitational", "Have you got what it takes to shovel snow with the best of the best?", "Outdoor Competition", "December 28, 2023", "12:00 Noon - 5:00 PM", "Pike Place Market- Seattle, WA");        
        Console.Write(event6.getShort());
        Console.Write(event6.getStandard());
        Console.Write(event6.getDetails());
        Console.Write("Hit enter to see the next event ");
        Console.ReadLine();

    }
}