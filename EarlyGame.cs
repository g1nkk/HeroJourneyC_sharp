using System.Net.Http.Headers;
using System.Xml.Linq;

namespace HeroJourneyC_
{
    public class GameInfo
    {
        public Hero user;

        public MonsterList monsterList = new MonsterList();
        public WeaponList weaponList = new WeaponList();
        public ClothesList clothesList = new ClothesList();
        public HealthItemList healthItemList = new HealthItemList();
        public MaxHealthItemList maxHealthItemList = new MaxHealthItemList();

        public SecretShop secretShop = new SecretShop();

        public GameInfo(string name)
        {
            user = new Hero(name);
        }
    }

    public class EarlyGame
    {
        static void StartNewGame()
        {
            ShowPrologue();

            var playerName = SetPlayerName();
            var gameInfo = new GameInfo(playerName);

            SetStartItems(gameInfo);
            MiddleGame.ShowNextStepMenu(gameInfo);
        }

        static string SetPlayerName()
        {
            Console.SetWindowSize(50, 6);
            Console.SetBufferSize(50, 6);

            bool invalidName = false;
            bool isReady = false;
            string name = "";

            while (!isReady)
            {
                Console.Clear();

                if (invalidName)
                {
                    Console.SetWindowSize(50, 8);
                    Console.SetBufferSize(50, 8);

                    Console.WriteLine("\tName must be at least 3 characters!\n\n");
                }

                Console.WriteLine("\t\tEnter your name:\n\n");
                Console.Write("\t\t     ");
                name = Console.ReadLine();

                if (name.Length < 3)
                { 
                    invalidName = true;
                }
                else
                {
                    isReady = true;
                }
            }
            return name;
        }

        static void SetStartItems(GameInfo gameInfo)
        {
            gameInfo.user.Clothes = new Pajamas();

            gameInfo.user.Weapon = new ButterKnife();
        }

        static void ShowPrologue()
        {
            Console.SetWindowSize(75, 20);
            Console.SetBufferSize(75, 20);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\tYou woke up in the morning as always,\n");
            Console.WriteLine("\tthe sun shines brightly outside the window,\n");
            Console.WriteLine("\tand you have another busy working day ahead of you.\n\n");

            Utility.Pause();
            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\tYou came to the kitchen to cook breakfast, picked up\n");
            Console.WriteLine("\ta bread knife, but as soon as you were about to cut\n");
            Console.WriteLine("\ta piece of bread, you suddenly felt the floor\n");
            Console.WriteLine("\tfall under you and in a second you were already\n");
            Console.WriteLine("\tsitting in a clearing with a note in your hands that says:\n\n");

            Utility.Pause();
            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\t\"Wanderer, you have the opportunity to become the richest\n");
            Console.WriteLine("\tamong all living! if you are a glorious hero and it is in\n");
            Console.WriteLine("\tyour power to overcome all the way to the sacred castle of\n");
            Console.WriteLine("\tthe Goldholders, then you will have the honor of becoming\n");
            Console.WriteLine("\tthe owner of all the jewels of the treasury of the Holy Grail!\"\n\n");

            Utility.Pause();
            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\tSince you didn\'t like your job anyway, and you still needed\n");
            Console.WriteLine("\tmoney to pay rent, you decided to go on an adventure. A wooden\n");
            Console.WriteLine("\tsign in front of you says: \"Castle of the Goldholders - 100km\".\n\n");
            Console.WriteLine("\tThis is where your adventure begins...\n\n");

            Utility.Pause();
        }

        static void ShowButtons()
        {
            Console.WriteLine("\t\t    ___  __   _____  __");
            Console.WriteLine("\t\t   / _ \\/ /  / _ \\ \\/ /");
            Console.WriteLine("\t\t  / ___/ /__/ __ |\\  / ");
            Console.WriteLine("\t\t /_/  /____/_/ |_|/_/  ");

            Console.WriteLine("\t\t    _____  ____________");
            Console.WriteLine("\t\t   / __/ |/_/  _/_  __/");
            Console.WriteLine("\t\t  / _/_>  <_/ /  / /   ");
            Console.WriteLine("\t\t /___/_/|_/___/ /_/    ");
        }

        static void ShowButtons(bool flag)
        {
                Console.ForegroundColor = flag ? Console.ForegroundColor=ConsoleColor.DarkGray : Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine("\t\t    ___  __   _____  __");
                Console.WriteLine("\t\t   / _ \\/ /  / _ \\ \\/ /");
                Console.WriteLine("\t\t  / ___/ /__/ __ |\\  / ");
                Console.WriteLine("\t\t /_/  /____/_/ |_|/_/  ");
                Console.ForegroundColor = flag ? Console.ForegroundColor = ConsoleColor.White : Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t    _____  ____________");
                Console.WriteLine("\t\t   / __/ |/_/  _/_  __/");
                Console.WriteLine("\t\t  / _/_>  <_/ /  / /   ");
                Console.WriteLine("\t\t /___/_/|_/___/ /_/    ");
        }
        static void ShowGameName()
        {
            Console.WriteLine();
            Console.WriteLine("      __ _________  ____       ______  __  _____  _  ________  __ ");
            Console.WriteLine("     / // / __/ _ \\/ __ \\  __ / / __ \\/ / / / _ \\/ |/ / __/\\ \\/ /");
            Console.WriteLine("    / _  / _// , _/ /_/ / / // / /_/ / /_/ / , _/    / _/   \\  / ");
            Console.WriteLine("   /_//_/___/_/|_|\\____/  \\___/\\____/\\____/_/|_/_/|_/___/   /_/  ");
            Console.WriteLine();
        }

        static public void StartAnimation()
        {
            int waitTime = 150;

            #region logo fage in

            Thread.Sleep(waitTime);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            ShowGameName();

            Thread.Sleep(waitTime);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            ShowGameName();

            Thread.Sleep(waitTime);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            ShowGameName();

            Thread.Sleep(waitTime);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ShowGameName();

            #endregion
            #region buttons fade in

            Thread.Sleep(waitTime);
            Console.Clear();
            ShowGameName();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ShowButtons();

            Thread.Sleep(waitTime);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ShowGameName();
            Console.ForegroundColor = ConsoleColor.Gray;
            ShowButtons();


            Thread.Sleep(waitTime);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            ShowGameName();
            Console.ForegroundColor = ConsoleColor.White;
            ShowButtons();

            Thread.Sleep(waitTime);

            #endregion

            ShowMainMenu();
        }


        static public void ShowMainMenu()
        {
            int choose = 0;
            bool isChosen = false;
            while (!isChosen)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                ShowGameName();
                ShowButtons(Convert.ToBoolean(choose));

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choose > 0)
                            choose--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choose < 1)
                            choose++;
                        break;
                    case ConsoleKey.Enter:
                        isChosen = true;
                        break;
                }
            }
            switch (choose)
            {
                case 0:
                    StartNewGame();
                    break;
                case 1:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}