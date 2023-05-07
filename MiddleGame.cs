namespace HeroJourneyC_
{
    class MiddleGame
    {
        public static void ShowNextStepMenu(GameInfo gameInfo)
        {
            Console.SetWindowSize(49, 6);
            Console.SetBufferSize(49, 6);

            bool isChosen = false;
            int choose = 0;
            while (!isChosen)
            {
                Console.Clear();

                Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.DarkGray : ConsoleColor.White;
                Console.WriteLine("\n\n\t\tCONTINUE TRAVEL");
                Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.White : ConsoleColor.DarkGray;
                Console.WriteLine("\t\tPLAYER STATISTICS");
                Console.ForegroundColor = ConsoleColor.White;

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
                    MakeNextStep(gameInfo);
                    break;
                case 1:
                    gameInfo.user.ShowPlayerStatistics();
                    Utility.Pause();
                    ShowNextStepMenu(gameInfo);
                    break;
            }
        }

        static void MakeNextStep(GameInfo gameInfo)
        {
            gameInfo.user.Km += 1;
            CheckNextStepKM(gameInfo);
        }

        static void CheckNextStepKM(GameInfo gameInfo)
        {
            Console.SetWindowSize(49, 8);
            Console.SetBufferSize(49, 8);
            Console.Clear();

            Random rand = new();

            gameInfo.user.reduceHp(100);
            var randomEventsControl = new RandomEventsControl();
            randomEventsControl.SetRandomEvent();
            randomEventsControl.randomEvent.Invoke(gameInfo);

            //if (gameInfo.user.Km == 100)
            //{
            //    Console.SetWindowSize(54, 10);
            //    Console.SetBufferSize(54, 10);
            //    Console.WriteLine("\n\tYou continued your adventure");
            //    Console.WriteLine("\tCurrent km: " + gameInfo.user.Km);
            //    Console.WriteLine("\tYou came across a castle in front of you...");
            //    Console.WriteLine("\tYou entered it.");
            //    Console.WriteLine("\tThere is Dragon on the way!");
            //    Console.WriteLine("\tThe fight begin...");
            //    gameInfo.user.monster = gameInfo.monsterList.getFinalBoss();
            //    StartFight(gameInfo);
            //}
            //else if (gameInfo.user.Km % 5 == 0)
            //{
            //    Console.SetWindowSize(75, 9);
            //    Console.SetBufferSize(75, 9);

            //    Console.WriteLine("\n\t    On the way you came across a secret shop.");
            //    Console.WriteLine("\t   Shopkeeper noticed you and greeted you cheerfully:");
            //    Console.WriteLine("\t     \"Welcome to the secret shop, wanderer!");
            //    Console.WriteLine("\tChoose from the best range of goods in the entire valley!\"\n\t");
            //    Utility.Pause();
            //    ShowSecretShop(gameInfo);
            //}
            //else if (rand.Next(10) == 3)
            //{
            //    var randomEventsControl = new RandomEventsControl();
            //    randomEventsControl.SetRandomEvent();
            //    randomEventsControl.randomEvent.Invoke(gameInfo);
            //}
            //else
            //{
            //    gameInfo.user.monster = gameInfo.monsterList.getRandomMonster(gameInfo.user.Km);

            //    Console.WriteLine("\n\t You continued your adventure");
            //    Console.WriteLine("\t Current km: " + gameInfo.user.Km);
            //    Console.WriteLine("\t There is " + gameInfo.user.monster.Name + " on the way!");
            //    Console.WriteLine("\t The fight begin...");
            //    StartFight(gameInfo);
            //}
        }
        static void ShowSecretShop(GameInfo gameInfo)
        {
            var rand = new Random();
            int shopType = rand.Next(2);

            gameInfo.secretShop.SetRandomProduct(gameInfo);
            gameInfo.secretShop.VisitShop(shopType, gameInfo);
        }

        static void StartFight(GameInfo gameInfo)
        {
            while (gameInfo.user.Hp > 0 && gameInfo.user.monster.Hp > 0)
            {
                Utility.Pause();
                FightLogic(gameInfo);
            }

            if (gameInfo.user.Hp <= 0)
            {
                EndGame.GameOver(gameInfo);
            }
            else if (gameInfo.user.monster.Hp <= 0)
            {
                Console.SetWindowSize(50, 7);
                Console.SetBufferSize(50, 7);
                Console.Clear();

                if (gameInfo.user.Km == 100) // final boss fight
                {
                    EndGame.ShowGoodEnd(gameInfo);
                }
                else
                {
                    Console.WriteLine("\n\t You won the fight!");
                    Console.WriteLine($"\t {gameInfo.user.monster.Name} died.");
                    Console.WriteLine($"\t You got {gameInfo.user.monster.Revard} gold!");

                    gameInfo.user.Gold += gameInfo.user.monster.Revard;
                    gameInfo.user.monster.restoreHP();

                    Utility.Pause();

                    Random rand = new Random();
                    int luck = rand.Next(5);
                    if (luck >= 2)
                    {
                        GetItemAfterDeath(gameInfo);
                    }

                    ShowNextStepMenu(gameInfo);
                }
            }
        }
        static void FightLogic(GameInfo gameInfo)
        {
            Console.SetWindowSize(45, 5);
            Console.SetBufferSize(45, 5);

            bool isChosen = false;
            int choose = 0;

            while (!isChosen)
            {
                Console.Clear();

                Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.DarkGray : ConsoleColor.White;
                Console.WriteLine("\n\n\t\t    ATTACK");
                Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.White : ConsoleColor.DarkGray;
                Console.WriteLine("\t\t   USE ITEM");
                Console.ForegroundColor = ConsoleColor.White;


                switch ((Console.ReadKey().Key))
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
                    Console.Clear();
                    Console.SetWindowSize(53, 13);
                    Console.SetBufferSize(53, 13);

                    gameInfo.user.heroAttack();
                    gameInfo.user.monsterAttack();
                    break;
                case 1:
                    if (gameInfo.user.itemList.Count == 0)
                    {
                        Console.SetWindowSize(45, 8);
                        Console.SetBufferSize(45, 8);

                        Console.WriteLine("\n\t   Inventory is empty!");
                    }
                    else
                    {
                        chooseItem(gameInfo);
                    }
                    break;
            }
        }

        static void chooseItem(GameInfo gameInfo)
        {
            Console.SetWindowSize(70, 4 + gameInfo.user.itemList.Count);
            Console.SetBufferSize(70, 4 + gameInfo.user.itemList.Count);


            bool isChosen = false;
            int choose = 0;

            while (!isChosen)
            {
                Console.Clear();
                Console.WriteLine();
                for (int i = 0; i < gameInfo.user.itemList.Count; i++)
                {
                    if (i == choose)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }

                    Console.Write($"\t{gameInfo.user.itemList[i].Name} | heal value: {gameInfo.user.itemList[i].Name}");
                    Console.WriteLine($" | type: {gameInfo.user.itemList[i].Type}");

                    Console.ForegroundColor = ConsoleColor.White;
                }


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choose > 0)
                            choose--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choose < gameInfo.user.itemList.Count - 1)
                            choose++;
                        break;
                    case ConsoleKey.Enter:
                        isChosen = true;
                        break;
                }
            }

            gameInfo.user.useItem(choose);
        }

        static void GetItemAfterDeath(GameInfo gameInfo)
        {
            Console.SetWindowSize(60, 9);
            Console.SetBufferSize(60, 9);

            Random rand = new Random();

            int type = rand.Next(0, 4);
            bool isChosen = false;
            int choose = 0;
            int pos = GetRandomPos(gameInfo);

            switch (type) //0-cloth 1-weapon 2-max 3-health
            {
                case 0:
                    while (!isChosen)
                    {
                        Console.Clear();

                        Console.WriteLine($"\n\tYou received {gameInfo.clothesList.list[pos].Name}!");
                        Console.WriteLine($"\t{gameInfo.clothesList.list[pos].Name} | armor: {gameInfo.clothesList.list[pos].Armor}");
                        Console.WriteLine($"\tYour armor: {gameInfo.user.Armor}");
                        Console.WriteLine("\tYou want to equip new armor?\n");

                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.DarkGray : ConsoleColor.White;
                        Console.WriteLine("\t\tEQUIP");
                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.White : ConsoleColor.DarkGray;
                        Console.WriteLine("\t\tLEAVE");
                        Console.ForegroundColor = ConsoleColor.White;

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
                            Console.Clear();
                            Console.WriteLine($"\n\tYou equipped {gameInfo.clothesList.list[pos].Name}!");
                            gameInfo.user.Clothes = gameInfo.clothesList.list[pos];
                            Utility.Pause();
                            break;
                        case 1:
                            Console.WriteLine("\n\tYou continued your adventure...");
                            Utility.Pause();
                            break;
                    }
                    break;

                case 1:
                    isChosen = false;
                    choose = 0;
                    while (!isChosen)
                    {
                        Console.Clear();

                        Console.WriteLine($"\n\tYou received {gameInfo.weaponList.list[pos].Name}!");
                        Console.WriteLine($"\t{gameInfo.weaponList.list[pos].Name} | damage: {gameInfo.weaponList.list[pos].Damage}");
                        Console.WriteLine($"\tYour weapon damage: {gameInfo.user.Damage}");
                        Console.WriteLine("\tYou want to equip new weapon?\n");

                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.DarkGray : ConsoleColor.White;
                        Console.WriteLine("\t\tEQUIP");
                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.White : ConsoleColor.DarkGray;
                        Console.WriteLine("\t\tLEAVE");
                        Console.ForegroundColor = ConsoleColor.White;

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

                    Console.Clear();
                    switch (choose)
                    {
                        case 0:
                            Console.WriteLine($"\tYou equipped {gameInfo.weaponList.list[pos].Name}!");
                            gameInfo.user.Weapon = gameInfo.weaponList.list[pos];
                            break;
                        case 1:
                            Console.WriteLine("\tYou continued your adventure...");
                            Utility.Pause();
                            break;
                    }
                    break;

                case 2:
                    Console.Clear();
                    gameInfo.user.itemList.Add(gameInfo.maxHealthItemList.GetRandomMaxHealthItem());
                    Console.WriteLine($"\n\t  You received {gameInfo.user.itemList[gameInfo.user.itemList.Count - 1].Name}");
                    Utility.Pause();
                    break;
                case 3:
                    Console.Clear();
                    gameInfo.user.itemList.Add(gameInfo.healthItemList.GetRandomHealthItem());
                    Console.WriteLine($"\n\t  You received {gameInfo.user.itemList[gameInfo.user.itemList.Count - 1].Name}");
                    Utility.Pause();
                    break;
            }
        }

        static int GetRandomPos(GameInfo gameInfo)
        {
            Random rand = new Random();
            int position;

            if (gameInfo.user.Km > 10)
            {
                position = rand.Next(0, gameInfo.user.Km / 10);
            }
            else
            {
                position = rand.Next(0, 2);
            }

            return position;
        }
    }
}
