using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroJourneyC_
{
    public static class EndGame
    {
        public static void ShowGoodEnd()
        {
            Console.Clear();
            // good enging
        }
        public static void GameOver(GameInfo gameInfo)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tYou died.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\tYour journey ended at {gameInfo.user.Km}km");
            Console.WriteLine($"\t{100 - gameInfo.user.Km}km has left to the castle\n\n");
            Utility.Pause();
            Environment.Exit(0);
        }
    }
}

