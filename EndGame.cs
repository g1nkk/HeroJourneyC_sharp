namespace HeroJourneyC_
{
    public static class EndGame
    {
        public static void ShowGoodEnd(GameInfo gameInfo)
        {
            Console.WriteLine("\n\t You won the fight!");
            Console.WriteLine($"\t {gameInfo.user.monster.Name} died.");

            Utility.Pause();

            Console.SetWindowSize(70, 15);
            Console.SetBufferSize(70, 15);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine($"\n\t You, with your trusty weapon, fought\n");
            Console.WriteLine("\tvaliantly against the fierce dragon, dodging\n");
            Console.WriteLine("\tits fiery breath and striking its weak points.\n");

            Utility.Pause();
            Console.Clear();

            Console.WriteLine("\n\t Finally, the dragon lay defeated, and \n");
            Console.WriteLine($"\tyou stood victorious. You approached the Holy Grail,\n");
            Console.WriteLine("\tsurrounded by piles of treasure, and reached for it. As\n");
            Console.WriteLine($"\tyour hand touched the Grail, a blinding light enveloped you.\n");

            Utility.Pause();
            Console.Clear();

            Console.WriteLine("\n\t The next thing you knew, you woke up in his bed,\n");
            Console.WriteLine("\tdrenched in sweat. You looked around and saw that you\n");
            Console.WriteLine("\twas in your room. You rubbed his eyes, still feeling\n");
            Console.WriteLine("\tthe adrenaline from the epic battle. Slowly, you realized\n");
            Console.WriteLine("\tthat it was all just a dream, albeit a vivid one.\n");

            Utility.Pause();
            Console.Clear();

            Console.WriteLine("\n\t Disappointed, but relieved that you didn't have to\n");
            Console.WriteLine("\tface any dragons in real life, you got up and\n");
            Console.WriteLine("\tstarted your day, wondering what other adventures his \n");
            Console.WriteLine("\tdreams might bring...\n");

            Utility.Pause();
            Environment.Exit(0);
        }
        public static void GameOver(GameInfo gameInfo)
        {
            Console.Clear();
            Console.SetWindowSize(55, 9);
            Console.SetBufferSize(55, 9);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tYou died.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t{gameInfo.user.Name} journey ended at {gameInfo.user.Km}km");
            Console.WriteLine($"\t{100 - gameInfo.user.Km}km has left to the castle\n\n");
            Utility.Pause();
            Environment.Exit(0);
        }
    }
}

