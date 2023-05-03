using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroJourneyC_
{
    public static class Utility
    {
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any button to continue...");
            Console.ReadKey();
        }
    }
}
