class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Matt Walsh","Conservative Dad Plays Grand Theft Auto V For The First Time",494);
        video1.AddComment(new Comment("Ted Barrett","Matt says he doesn't like this game at the same time he smiles while mowing people down with cars and shooting them lol. Admit it Matt, that game is fun."));
        video1.AddComment(new Comment("Madison Carberry","Matt: Proceeds to kill everyone and steals cars \nAlso Matt: Oop Red light"));
        video1.AddComment(new Comment("Connor","It's important to just develop those good habits \n-a conservative dad running over civilians in a game"));

        Video video2 = new Video("The Comments Section with Brett Cooper","Woke Movie Only Makes $10K Opening Weekend.",638);
        video2.AddComment(new Comment("TexFraud","Anything AOC does flops, but this really tops off everything she's done so far"));
        video2.AddComment(new Comment("MY Surfing","10K opening weekend wouldbe great back in 1890"));
        video2.AddComment(new Comment("Hefty Jongle","Disney: Strange World releases, flops AOC: Disney hold my frappe"));

        Video video3 = new Video("Michael Knowles","Michael REACTS to Mean TikToks",819);
        video3.AddComment(new Comment("Sean Delap","If you're offending these people then you know you're doing something right"));
        video3.AddComment(new Comment("Enigma1990ad","I'm a gay guy and while Michael doesn't agree with homosexuality I do like the guy. His ability to remain courteous and calm even in heated debates is a skill I wish myself and others had."));
        video3.AddComment(new Comment("GooseFighter","Michael Knowles is the cool uncle that we all need in our lives."));

        video1.Display();
        video2.Display();
        video3.Display();
    }
}