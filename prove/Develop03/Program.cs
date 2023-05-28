using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Scripture> scriptureList = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16), "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
            new Scripture(new Reference("Proverbs", 3, 6), "In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("2 Nefi",31,20),"Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eeternal life."),
            new Scripture(new Reference("Mosiah",18,10),"Now I say unto you, if this be the desire of your hearts, what have you against being abaptized in the bname of the Lord, as a witness before him that ye have entered into a ccovenant with him, that ye will serve him and keep his commandments, that he may pour out his Spirit more abundantly upon you?"),
            new Scripture(new Reference("Alma",5,14),"And now behold, I ask of you, my brethren of the church, have ye spiritually been born of God? Have ye received his image in your countenances? Have ye experienced this mighty change in your hearts?"),
            new Scripture(new Reference("D&C",4,2),"Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day."),
        };

        
        Random random = new Random();
        int selectedScriptureIndex = random.Next(scriptureList.Count);
        Scripture selectedScripture = scriptureList[selectedScriptureIndex];
        
        Console.Clear();
        Console.WriteLine("Scripture Hiding Game");
        Console.WriteLine($"Reference:{selectedScripture.GetReferenceString()}");
        Console.WriteLine();
        Console.WriteLine(selectedScripture.GetRenderedText());
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }

            selectedScripture.HideWords();

             
            Console.Clear();
            Console.WriteLine("Scripture Hiding Game");
            Console.WriteLine($"Reference:{selectedScripture.GetReferenceString()}");
            Console.WriteLine();
            Console.WriteLine(selectedScripture.GetRenderedText());
            Console.WriteLine();

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words in the scripture are hidden.");
                Console.WriteLine("Game Over!");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to exit.");
                Console.ReadLine();
                return;
            }
        }
    }
}
