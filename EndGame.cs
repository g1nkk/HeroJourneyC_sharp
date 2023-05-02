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
        public static void ShowDeadEnd()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\tYou died.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\tYour journey ended at {user.Km}km");
            Console.WriteLine($"\t{100 - user.Km}km has left to the castle\n\n");
            Utility.Pause();
            Environment.Exit(0);
        }
    }
}

