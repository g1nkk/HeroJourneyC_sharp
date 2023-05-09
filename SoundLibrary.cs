using System.Media;

namespace HeroJourneyC_
{
    public class SoundLibrary
    {
        public SoundPlayer useItem { get; }
        public SoundPlayer fight { get; }
        public SoundPlayer shopBuy { get; }
        public SoundPlayer died { get; }

        public SoundLibrary() 
        { 
            useItem = new SoundPlayer("useItem.wav");
            fight = new SoundPlayer("fight.wav");
            shopBuy = new SoundPlayer("shopBuy.wav");
            died = new SoundPlayer("died.wav");
        }
    }
}
