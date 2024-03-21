using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = CreateScriptureLibrary();
        Random random = new Random();

        while (AnyWordsLeftToShow(scriptureLibrary))
        {
            Scripture scripture = SelectRandomScripture(scriptureLibrary, random);
            PresentScripture(scripture);

            Console.WriteLine("Press Enter to continue or type 'quit' to exit: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords();
            }
        }
    }

    static List<Scripture> CreateScriptureLibrary()
    {
        List<Scripture> scriptureLibrary = new List<Scripture>();

        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        scriptureLibrary.Add(scripture1);

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(reference2, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        scriptureLibrary.Add(scripture2);

        Reference reference3 = new Reference("Alma", 32, 21);
        Scripture scripture3 = new Scripture(reference3, "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        scriptureLibrary.Add(scripture3);

        Reference reference4 = new Reference("2Nephi", 2, 25);
        Scripture scripture4 = new Scripture(reference4, "Adam fell that men might be; and men are, that they might have joy.");
        scriptureLibrary.Add(scripture4);

        Reference reference5 = new Reference("Moroni", 10, 32);
        Scripture scripture5 = new Scripture(reference5,  "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.");
        scriptureLibrary.Add(scripture5);

        Reference reference6 = new Reference("1Nephi", 3, 7);
        Scripture scripture6 = new Scripture(reference6, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        scriptureLibrary.Add(scripture6);

        Reference reference7 = new Reference("Mosiah", 2, 17);
        Scripture scripture7 = new Scripture(reference7, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        scriptureLibrary.Add(scripture7);

        Reference reference8 = new Reference("Heleman", 5, 12);
        Scripture scripture8 = new Scripture(reference8,  "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        scriptureLibrary.Add(scripture8);

        Reference reference9 = new Reference("Ether", 12, 27);
        Scripture scripture9 = new Scripture(reference9,  "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        scriptureLibrary.Add(scripture9);

        Reference reference10 = new Reference("Alma", 36, 3);
        Scripture scripture10 = new Scripture(reference10,  "And now, O my son Helaman, behold, thou art in thy youth, and therefore, I beseech of thee that thou wilt hear my words and learn of me; for I do know that whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day.");
        scriptureLibrary.Add(scripture10);

        Reference reference11 = new Reference("3Nephi", 11, 33);
        Scripture scripture11 = new Scripture(reference11, "And whoso believeth in me, and is baptized, the same shall be saved; and they are they who shall inherit the kingdom of God.");
        scriptureLibrary.Add(scripture11);

        Reference reference12 = new Reference("Moroni", 7, 45);
        Scripture scripture12 = new Scripture(reference12, "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.");
        scriptureLibrary.Add(scripture12);

        return scriptureLibrary;
    }

     static void PresentScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine($"{scripture.GetReferenceDisplayText()}: {scripture.GetDisplayText()}");
    }

    static bool AnyWordsLeftToShow(List<Scripture> scriptureLibrary)
    {
        foreach (Scripture scripture in scriptureLibrary)
        {
            if (!scripture.IsCompletelyHidden())
            {
                return true;
            }
        }
        return false;
    }

    static Scripture SelectRandomScripture(List<Scripture> scriptureLibrary, Random random)
    {
        return scriptureLibrary[random.Next(scriptureLibrary.Count)];
    }
}
