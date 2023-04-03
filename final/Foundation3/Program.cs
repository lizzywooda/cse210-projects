using System;

class Program
{
    static void Main(string[] args)
    {
        //create reception event
        Address address1 = new Address("123 Madeup Way", "Rexburg", "Idaho", 83440, "USA");
        Reception reception1 = new Reception("Canepari Wedding", "Wedding reception for Luke and Lizzy Canepari", "12/17/2022", "5-7pm", address1, "Reception","madeupemail@gmail.com");
        
        //create outdoor event
        Address address2 = new Address("456 Fake Place", "Rexburg", "Idaho", 83440, "USA");
        Outdoor outdoor1 = new Outdoor("Outdoor Consert","Come hear some great music while getting some fresh air=.", "4/03/2023","5-7pm", address2, "Outdoor", "Partly Cloudy");

        //create lecture event
        Address address3 = new Address("525 S Center St", "Rexburg", "Idaho", 83460, "USA");
        Lecture lecture1 = new Lecture("How to Improve Your Grades", "Learn how to improve those grades to see the dream transcript. It doesn't matter how low your grades are now. Come learn to put in that effort and raise those grades that any parent would be proud of.", "05/21/2023", "9-11am", address3, "Lecture", "Professor Notreal", 85);
        
        // call reception event standard details
        Console.WriteLine(reception1.StandardDetails());
        Console.WriteLine();
        // call reception full details
        Console.WriteLine(reception1.FullDetails() + reception1.ReceptionFullDetails());
        Console.WriteLine();
        // call reception short details
        Console.WriteLine(reception1.ShortDetails());
        Console.WriteLine();
        // call outdoor event standard details
        Console.WriteLine(outdoor1.StandardDetails());
        Console.WriteLine();
        // call outdoor event full details
        Console.WriteLine(outdoor1.FullDetails() + outdoor1.OutdoorFullDetails());
        Console.WriteLine();
        // call outdoor event short details
        Console.WriteLine(outdoor1.ShortDetails());
        Console.WriteLine();
        // call lecture standard details
           Console.WriteLine(lecture1.StandardDetails());
            Console.WriteLine();
        // call lecture full details
        Console.WriteLine(lecture1.FullDetails() + lecture1.LectureFullDetails());
        Console.WriteLine();
        // call lecture short details
        Console.WriteLine(lecture1.ShortDetails());
    }
}