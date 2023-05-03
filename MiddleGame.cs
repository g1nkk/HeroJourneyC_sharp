using System.Diagnostics.Metrics;

namespace HeroJourneyC_
{
    class MiddleGame
    {
        public int GetRandomPos(GameInfo gameInfo)
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

        public void GetItemAfterDeath(GameInfo gameInfo)
        {
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

                        if (choose == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\tEQUIP");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tLEAVE");
                        }
                        else if (choose == 1)
                        {
                            Console.WriteLine("\t\tEQUIP");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\tLEAVE");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

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
                            Console.WriteLine($"\tYou equipped {gameInfo.clothesList.list[pos].Name}!");
                            gameInfo.user.Clothes = gameInfo.clothesList.list[pos];
                            Utility.Pause();
                            break;
                        case 1:
                            Console.WriteLine("\tYou continued your adventure...");
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

                        if (choose == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\tEQUIP");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tLEAVE");
                        }
                        else if (choose == 1)
                        {
                            Console.WriteLine("\t\tEQUIP");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\tLEAVE");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

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
                    Console.WriteLine($"\n\tYou received {gameInfo.user.itemList.Count}");
                    Utility.Pause();
                    break;
                case 3:
                    Console.Clear();
                    gameInfo.user.itemList.Add(gameInfo.healthItemList.GetRandomHealthItem());
                    Console.WriteLine($"\n\tYou received {gameInfo.user.itemList.Count}");
                    Utility.Pause();
                    break;
            }
        }
    }
}
