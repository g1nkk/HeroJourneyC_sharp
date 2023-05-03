namespace HeroJourneyC_
{ 
    public class Program
    {
        public static void Main()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(67, 15);
            Console.SetBufferSize(67, 15);

            EarlyGame.StartAnimation();
        }
    }
}