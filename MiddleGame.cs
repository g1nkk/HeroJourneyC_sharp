using System.Diagnostics.Metrics;

namespace HeroJourneyC_
{
    class MiddleGame
    {
        public int GetRandomPos(Hero user)
        {
            Random rand = new Random();
            int position;

            if (user.Km > 10)
            {
                position = rand.Next(0, user.Km / 10);
            }
            else
            {
                position = rand.Next(0, 2);
            }

            return position;
        }

        public void GetItemAfterDeath(Hero user, WeaponList weaponList, ClothesList clothesList, HealthItemList healthItemList, MaxHealthItemList maxHealthItemList)
        {
            Random rand = new Random();

            int type = rand.Next(0, 4);
            bool isChosen = false;
            int choose = 0;
            int pos = GetRandomPos(user);

            switch (type) //0-cloth 1-weapon 2-max 3-health
            {
                case 0:
                    while (!isChosen)
                    {
                        Console.Clear();

                        Console.WriteLine($"\n\tYou received {clothesList.list[pos].Name}!");
                        Console.WriteLine($"\t{clothesList.list[pos].Name} | armor: {clothesList.list[pos].Armor}");
                        Console.WriteLine($"\tYour armor: {user.Armor}");
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
                            Console.WriteLine($"\tYou equipped {clothesList.list[pos].Name}!");
                            user.Clothes = clothesList.list[pos];
                            Console.ReadKey();
                            break;
                        case 1:
                            Console.WriteLine("\tYou continued your adventure...");
                            Console.ReadKey();
                            break;
                    }
                    break;

                case 1:
                    isChosen = false;
                    choose = 0;
                    while (!isChosen)
                    {
                        Console.Clear();

                        Console.WriteLine($"\n\tYou received {weaponList.list[pos].Name}!");
                        Console.WriteLine($"\t{weaponList.list[pos].Name} | damage: {weaponList.list[pos].Damage}");
                        Console.WriteLine($"\tYour weapon damage: {user.Damage}");
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

                        int c = Console.ReadKey(true).KeyChar;
                        switch (c)
                        {
                            case KEY_UP:
                                if (choose > 0)
                                    choose--;
                                break;
                            case KEY_DOWN:
                                if (choose < 1)
                                    choose++;
                                break;
                            case ENTER:
                                isChosen = true;
                                break;
                        }
                    }

                    Console.Clear();
                    switch (choose)
                    {
                        case 0:
                            Console.WriteLine($"\tYou equipped {weaponList.list[pos].getName()}!");
                            user.setWeapon(weaponList.list[pos]);
                            break;
                        case 1:
                            Console.WriteLine("\tYou continued your adventure...");
                            Console.ReadKey();
                            break;
                    }
                    break;

                case 2:
                    Console.Clear();
                    user.itemList.Add(maxHealthItemList.getRandomMaxHealthItem());
                    Console.WriteLine($"\n\tYou received {user.itemList[user]}");
                    break;
            }
        }
    }
}
