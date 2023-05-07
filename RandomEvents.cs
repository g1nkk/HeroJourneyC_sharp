using System.Reflection.Metadata;

namespace HeroJourneyC_
{
    class RandomEventsControl
    {
        public delegate void RandomEvent(GameInfo gameInfo);
        public RandomEvent? randomEvent;

        readonly List<Event> eventsList = new();

        public RandomEventsControl()
        {
            eventsList.Add(new MoneyEvent());
            eventsList.Add(new ChestEvent());
        }

        public void SetRandomEvent()
        {
            var rand = new Random();
            int pick = rand.Next(eventsList.Count);

            randomEvent = eventsList[pick].InvokeEvent;
        }
    }
    interface Event
    {
        void InvokeEvent(GameInfo gameInfo);
    }

    class MoneyEvent : Event
    {
        public void InvokeEvent(GameInfo gameInfo)
        {
            var rand = new Random();
            int moneyInWallet = rand.Next(150);

            Console.SetWindowSize(55, 6);
            Console.SetBufferSize(55, 6);

            Console.Clear();
            Console.WriteLine("\n\tOn the way you found a wallet!");
            Console.WriteLine($"\tMoney in wallet: {moneyInWallet}");
            Console.WriteLine("\tYou took the money and continued the adventure");

            gameInfo.user.Gold += moneyInWallet;

            Utility.Pause();
            MiddleGame.ShowNextStepMenu(gameInfo);
        }
    }
    class ChestEvent : Event
    {
        public void InvokeEvent(GameInfo gameInfo)
        {
            Console.SetWindowSize(55, 6);
            Console.SetBufferSize(55, 6);

            Console.Clear();
            Console.WriteLine("\n\tOn the way you found a chest!");
            Utility.Pause(); 

            bool isChosen = false;
            int choose = 0;

            while (!isChosen)
            {
                Console.Clear();

                Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.DarkGray : ConsoleColor.White;
                Console.WriteLine("\n\t\tOPEN CHEST");
                Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.White : ConsoleColor.DarkGray;
                Console.WriteLine("\t\t  LEAVE");
                Console.ForegroundColor = ConsoleColor.White;

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choose > 0) choose--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (choose < 1) choose++;
                        break;

                    case ConsoleKey.Enter:
                        isChosen = true;
                        break;
                }
            }
            switch (choose)
            {
                case 0:
                    OpenChest(gameInfo);
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n\tYou continued your adventure.");
                    Utility.Pause();
                    MiddleGame.ShowNextStepMenu(gameInfo);
                    break;
            }
        }

        void OpenChest(GameInfo gameInfo)
        {
            Console.Clear() ;
            var random = new Random();
            int luck = random.Next(3);

            switch (luck)
            {
                case 0:
                    Console.WriteLine("\n\tA snake jumped out of the chest and bit you!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t-5hp");
                    Console.ForegroundColor= ConsoleColor.White;

                    gameInfo.user.reduceHp(5);
                    Console.WriteLine($"\tYour hp: {gameInfo.user.Hp}");
                    Utility.Pause();

                    if (gameInfo.user.Hp < 0) EndGame.GameOver(gameInfo);
                    else MiddleGame.ShowNextStepMenu(gameInfo);

                    break;
                case 1:
                    int gold = random.Next(150);
                    Console.WriteLine("\n\tYou found gold inside the chest!");
                    Console.WriteLine($"\tGold inside: {gold}");
                    gameInfo.user.Gold += gold;

                    Utility.Pause();
                    MiddleGame.ShowNextStepMenu(gameInfo);
                    break;
                case 2:
                    gameInfo.user.itemList.Add(gameInfo.healthItemList.GetRandomHealthItem());
                    Console.WriteLine($"\n\tYou found {gameInfo.user.itemList[gameInfo.user.itemList.Count-1].Name} inside the chest!");

                    Utility.Pause();
                    MiddleGame.ShowNextStepMenu(gameInfo);
                    break;
            }
        }
    }
}
