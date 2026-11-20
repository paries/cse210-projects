using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.WriteLine("This is the YouTubeVideos Project.");

        Video video1 = new Video("Best In Show", "Christopher Guest", 80);
        video1.SetComment(new Comment("Sue Higgens", "This was a great video"));
        video1.SetComment(new Comment("Fred Savage", "This was AI slop"));
        video1.SetComment(new Comment("Ruth Buzzie", "I know the director"));
        video1.SetComment(new Comment("Alfred E Newman", "What, me worry"));
        videos.Add(video1);

        Video video2 = new Video("SEMA 2026: The Most Questionable Builds Ranked", "Performance On Wheels", 220);
        video2.SetComment(new Comment("vegasfordguy", "That Corvette is HIDEOUS! The Maverick with the Coyote is awesome"));
        video2.SetComment(new Comment("jan1234", "I wouldn't waste my money even going to that event"));
        video2.SetComment(new Comment("jesmendoza3477", "Doing that to a Corvette oughta be a crime"));
        video2.SetComment(new Comment("rayisland", "This video should be called how to take a lot of money and flush it down the toilet."));
        videos.Add(video2);

        Video video3 = new Video("I Tried Living Off Grid for 30 Days", "Backwoods Barry", 1450);
        video3.SetComment(new Comment("hikerhannah88", "Day 12 when the generator died had me crying laughing"));
        video3.SetComment(new Comment("Dale Thornbury", "You had a Starbucks cup in the background at 14:32. Busted."));
        video3.SetComment(new Comment("mossycabinlife", "Love this! What brand of solar panels were you using?"));
        video3.SetComment(new Comment("Gretchen Pfeiffer", "My husband watched this and now wants to sell the house. Thanks a lot."));
        video3.SetComment(new Comment("Lou Ferrigno Jr", "Somebody check her heart rate after that third can"));
        videos.Add(video3);

        Video video4 = new Video("Grandma Reviews Energy Drinks", "The Tasty Twins", 512);
        video4.SetComment(new Comment("pixelpete_42", "Her face at the first sip is going to be my reaction to everything now"));
        video4.SetComment(new Comment("Marjorie Klumpp", "She is a national treasure. Protect her at all costs."));
        video4.SetComment(new Comment("kevinthecoder", "Grandma said 'tastes like a battery' and she's not wrong"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(" ");
        }
    }
}