namespace HeroJourneyC_
{
    static class EarlyGame
    {
        static void SetPlayerName()
        {
            bool invalidName = false;
            bool isReady = false;
            string name;

            while (!isReady)
            {
                Console.Clear();

                if (invalidName)
                {
                    Console.WriteLine("\tName must be at least 3 characters!\n\n");
                }

                Console.WriteLine("\t\tEnter your name:\n\n");
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
            
        }

        static void StartNewGame()
        {
            SetPlayerName();

            Clothes pajamas = new Pajamas();
            user.SetClothes(pajamas);

            Weapon butterKnife = new ButterKnife();
            user.SetWeapon(butterKnife);

            ShowNextStepMenu();
            Console.Clear();
        }

        static void StartPrologue()
        {
            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\tYou woke up in the morning as always,\n");
            Console.WriteLine("\tthe sun shines brightly outside the window,\n");
            Console.WriteLine("\tand you have another busy working day ahead of you.\n\n");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\tYou came to the kitchen to cook breakfast, picked up\n");
            Console.WriteLine("\ta bread knife, but as soon as you were about to cut\n");
            Console.WriteLine("\ta piece of bread, you suddenly felt the floor\n");
            Console.WriteLine("\tfall under you and in a second you were already\n");
            Console.WriteLine("\tsitting in a clearing with a note in your hands that says:\n\n");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\t\"Wanderer, you have the opportunity to become the richest\n");
            Console.WriteLine("\tamong all living! if you are a glorious hero and it is in\n");
            Console.WriteLine("\tyour power to overcome all the way to the sacred castle of\n");
            Console.WriteLine("\tthe Goldholders, then you will have the honor of becoming\n");
            Console.WriteLine("\tthe owner of all the jewels of the treasury of the Holy Grail!\"\n\n");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\t\t\tPrologue:\n\n");
            Console.WriteLine("\tSince you didn\'t like your job anyway, and you still needed\n");
            Console.WriteLine("\tmoney to pay rent, you decided to go on an adventure. A wooden\n");
            Console.WriteLine("\tsign in front of you says: \"Castle of the Goldholders - 100km\".\n\n");
            Console.WriteLine("\tThis is where your adventure begins...\n\n");

            Console.ReadKey();
        }


        static void ShowButtons(int flag)
        {
            if(flag==0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t   ___  __   _____  __");
                Console.WriteLine("\t\t  / _ \\/ /  / _ \\ \\/ /");
                Console.WriteLine("\t\t / ___/ /__/ __ |\\  / ");
                Console.WriteLine("\t\t/_/  /____/_/ |_|/_/  ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t   _____  ____________");
                Console.WriteLine("\t\t  / __/ |/_/  _/_  __/");
                Console.WriteLine("\t\t / _/_>  <_/ /  / /   ");
                Console.WriteLine("\t\t/___/_/|_/___/ /_/    ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (flag==1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\t\t   ___  __   _____  __");
                Console.WriteLine("\t\t  / _ \\/ /  / _ \\ \\/ /");
                Console.WriteLine("\t\t / ___/ /__/ __ |\\  / ");
                Console.WriteLine("\t\t/_/  /____/_/ |_|/_/  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t   _____  ____________");
                Console.WriteLine("\t\t  / __/ |/_/  _/_  __/");
                Console.WriteLine("\t\t / _/_>  <_/ /  / /   ");
                Console.WriteLine("\t\t/___/_/|_/___/ /_/    ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else // w/o color
            {
                Console.WriteLine("\t\t   ___  __   _____  __");
                Console.WriteLine("\t\t  / _ \\/ /  / _ \\ \\/ /");
                Console.WriteLine("\t\t / ___/ /__/ __ |\\  / ");
                Console.WriteLine("\t\t/_/  /____/_/ |_|/_/  ");
                Console.WriteLine("\t\t   _____  ____________");
                Console.WriteLine("\t\t  / __/ |/_/  _/_  __/");
                Console.WriteLine("\t\t / _/_>  <_/ /  / /   ");
                Console.WriteLine("\t\t/___/_/|_/___/ /_/    ");
            }
        }
        static void ShowGameName()
        {
            Console.WriteLine();
            Console.WriteLine("   __ _________  ____       ______  __  _____  _  ________  __ ");
            Console.WriteLine("  / // / __/ _ \\/ __ \\  __ / / __ \\/ / / / _ \\/ |/ / __/\\ \\/ /");
            Console.WriteLine(" / _  / _// , _/ /_/ / / // / /_/ / /_/ / , _/    / _/   \\  / ");
            Console.WriteLine("/_//_/___/_/|_|\\____/  \\___/\\____/\\____/_/|_/_/|_/___/   /_/  ");
            Console.WriteLine();
        }

        static public void StartAnimation()
        {
            #region logo fage in

            int sleepTime = 150;
            Thread.Sleep(sleepTime);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            ShowGameName();

            Thread.Sleep(sleepTime);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            ShowGameName();

            Thread.Sleep(sleepTime);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            ShowGameName();




            #endregion
            #region buttons fade in

            Thread.Sleep(sleepTime);
            Console.Clear();
            ShowGameName();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ShowButtons(2); // w\o color mode

            Thread.Sleep(sleepTime);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            ShowGameName();
            Console.ForegroundColor = ConsoleColor.Gray;
            ShowButtons(2);


            Thread.Sleep(sleepTime);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            ShowGameName();
            Console.ForegroundColor = ConsoleColor.White;
            ShowButtons(2);

            Thread.Sleep(sleepTime);

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
                ShowGameName();
                ShowButtons(choose);
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
                    //StartPrologue();
                    //StartNewGame();
                    break;
                case 1:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}