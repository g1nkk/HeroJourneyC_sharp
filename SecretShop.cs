using System.Diagnostics.Metrics;

namespace HeroJourneyC_
{
    public class SecretShop
    {
        private Weapon[] weapons = new Weapon[4];
        private Item[] healthItems = new Item[4];
        private Item[] maxHealthItems = new Item[4];

        public void VisitShop(int type, GameInfo gameInfo) // 1 - weapons, 2 - maxHealth, 3 - health
        {
            SetRandomProduct(gameInfo);

            int choose = 0;
            bool isChosen = false;

            while (!isChosen)
            {
                Console.Clear();
                Console.WriteLine("\n\tSectet Shop Goods:");

                if (type == 0) ShowWeapons(choose, gameInfo);
                else ShowItems(type, choose, gameInfo);

                if (choose == 4) // leave button
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nLEAVE");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("\nLEAVE");
                }

                Console.WriteLine($"\nYour gold: {gameInfo.user.Gold}");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choose > 0)
                        {
                            choose--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (choose < 4)
                        {
                            choose++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        isChosen = true;
                        break;
                }
            }

            Console.Clear();

            if (choose != 4)
            {
                if (healthItems[choose].Value > gameInfo.user.Gold)
                {
                    Console.WriteLine("\tYou don't have enough gold to buy this item!");
                    Utility.Pause();
                    VisitShop(type, gameInfo);
                }
                else // succesful
                {
                    Console.WriteLine($"\n\t{healthItems[choose].Name} added to your inventory!\n");
                    Utility.Pause();

                    gameInfo.user.itemList.Add(healthItems[choose]);
                    gameInfo.user.Gold -= healthItems[choose].Value;

                    choose = 0;
                    isChosen = false;

                    while (!isChosen)
                    {
                        Console.Clear();

                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.DarkGray : ConsoleColor.White;
                        Console.WriteLine("\n\tBUY ONE MORE ITEM");
                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.White : ConsoleColor.DarkGray;
                        Console.WriteLine("\tLEAVE");

                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.UpArrow:
                                if (choose > 0)
                                {
                                    choose--;
                                }
                                break;

                            case ConsoleKey.DownArrow:
                                if (choose < 1)
                                {
                                    choose++;
                                }
                                break;

                            case ConsoleKey.Enter:
                                isChosen = true;
                                break;
                        }
                    }

                    switch (choose)
                    {
                        case 0:
                            VisitShop(type, gameInfo);
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\tYou left the health shop.");
                            break;
                    }
                }
            }
            else if(choose==4) // leave
            {
                Console.Clear();
                Console.WriteLine("\tYou left the health shop.");
            }
            Utility.Pause();
        }

        void SetRandomProduct(GameInfo gameInfo)
        {
            string[] dots = { ".", "..", "...", "...." };
            for (int i = 0; i < 4; i++)
            {
                //Console.Clear();
                //Console.WriteLine($"\n\tGenerating shop range{dots[i]}");
                //Thread.Sleep(700);
                weapons[i] = gameInfo.weaponList.GetRandomWeapon();
                healthItems[i] = gameInfo.healthItemList.GetRandomHealthItem();
                maxHealthItems[i] = gameInfo.maxHealthItemList.GetRandomMaxHealthItem();
            }
        }

        void ShowWeapons(int choose, GameInfo gameInfo)
        {
            for (int i = 0; i < 4; i++) 
            {
                if (i == choose)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{weapons[i].Name} | damage: {weapons[i].Damage} | price: {weapons[i].Value}");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (weapons[i].Value < gameInfo.user.Gold)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{weapons[i].Name} | damage: {weapons[i].Damage} | price: {weapons[i].Value}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{weapons[i].Name} | damage: {weapons[i].Damage} | price: {weapons[i].Value}");
                    Console.ResetColor();
                }
            }

        }
        void ShowItems(int type, int choose, GameInfo gameInfo)
        {
            for (int i = 0; i < 4; i++)
            {
                if (type == 1) // max health
                {
                    if (i == choose)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{maxHealthItems[i].Name} | type: {maxHealthItems[i].Type} | price: {maxHealthItems[i].Value}");
                        Console.ResetColor();
                        Console.BackgroundColor= ConsoleColor.Black;
                    }
                    else if (healthItems[i].Value < gameInfo.user.Gold)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{maxHealthItems[i].Name} | type: {maxHealthItems[i].Type} | price: {maxHealthItems[i].Value}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"{maxHealthItems[i].Name} | type: {maxHealthItems[i].Type} | price: {maxHealthItems[i].Value}");
                        Console.ResetColor();
                    }
                }
                else // health
                {
                    if (i == choose)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{healthItems[i].Name} | type: {healthItems[i].Type} | price: {healthItems[i].Value}");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (healthItems[i].Value < gameInfo.user.Gold)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{healthItems[i].Name} | type: {healthItems[i].Type} | price: {healthItems[i].Value}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"{healthItems[i].Name} | type: {healthItems[i].Type} | price: {healthItems[i].Value}");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
