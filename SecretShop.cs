namespace HeroJourneyC_
{
    public class SecretShop
    {
        private Weapon[] weapons = new Weapon[8];
        private Item[] healthItems = new Item[8];
        private Item[] maxHealthItems = new Item[8];

        public void VisitShop(int type, GameInfo gameInfo) // 0 - weapons, 1 - maxHealth, 2 - health
        {
            Console.SetWindowSize(55, 17);
            Console.SetBufferSize(55, 17);


            int choose = 0;
            bool isChosen = false;

            while (!isChosen)
            {
                Console.Clear();
                Console.WriteLine("\n\tSectet Shop Goods:");

                if (type == 0) ShowWeapons(choose, gameInfo);
                else ShowItems(type, choose, gameInfo);

                if (choose == 8) // leave button
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n LEAVE");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("\n LEAVE");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n Your gold: {gameInfo.user.Gold}");
                Console.ResetColor();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choose > 0)
                        {
                            choose--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (choose < 8)
                        {
                            choose++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        isChosen = true;
                        break;
                }
            }

            Console.SetWindowSize(55, 5);
            Console.SetBufferSize(55, 5);
            Console.Clear();

            if (choose == 8) // leave button
            {
                Console.Clear();
                Console.WriteLine("\n\tYou left the health shop.");
                Utility.Pause();
                MiddleGame.ShowNextStepMenu(gameInfo);
            }
            else
            {
                if (AbleToBuy(type, choose, gameInfo))
                {
                    BuyItem(type, choose, gameInfo);

                    Utility.Pause();

                    choose = 0;
                    isChosen = false;

                    while (!isChosen)
                    {
                        Console.Clear();

                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.DarkGray : ConsoleColor.White;
                        Console.WriteLine("\n\t\t   BUY ONE MORE ITEM");
                        Console.ForegroundColor = Convert.ToBoolean(choose) ? ConsoleColor.White : ConsoleColor.DarkGray;
                        Console.WriteLine("\t\t        LEAVE");

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
                            Utility.Pause();
                            MiddleGame.ShowNextStepMenu(gameInfo);
                            break;
                    }
                }
                else 
                {

                    Console.WriteLine("\n\tYou don't have enough gold to buy this item!");
                    Utility.Pause();
                    VisitShop(type, gameInfo);
                }
            }
            Utility.Pause();
        }

        public void SetRandomProduct(GameInfo gameInfo)
        {
            for (int i = 0; i < 8; i++)
            {
                weapons[i] = gameInfo.weaponList.GetRandomWeapon();
                healthItems[i] = gameInfo.healthItemList.GetRandomHealthItem();
                maxHealthItems[i] = gameInfo.maxHealthItemList.GetRandomMaxHealthItem();
            }
        }

        void BuyItem(int type, int choose, GameInfo gameInfo)
        {
            if (type == 0)
            {
                Console.WriteLine($"\n\t{weapons[choose].Name} equipped!");
                gameInfo.user.Weapon = weapons[choose];
                gameInfo.user.Gold -= weapons[choose].Value;
            }
            else if (type == 1)
            {
                Console.WriteLine($"\n\t{maxHealthItems[choose].Name} added to your inventory!");
                gameInfo.user.itemList.Add(maxHealthItems[choose]);
                gameInfo.user.Gold -= maxHealthItems[choose].Value;
            }
            else if (type == 2)
            {
                Console.WriteLine($"\n\t{healthItems[choose].Name} added to your inventory!");
                gameInfo.user.itemList.Add(healthItems[choose]);
                gameInfo.user.Gold -= healthItems[choose].Value;
            }
        }

        bool AbleToBuy(int type, int choose, GameInfo gameInfo)
        {
            if (type == 0) // weapon
            {
                if (weapons[choose].Value > gameInfo.user.Gold)
                {
                    return false;
                }
                else return true;
            }
            else if (type == 1) // max
            {
                if (maxHealthItems[choose].Value > gameInfo.user.Gold)
                {
                    return false;
                }
                else return true;
            }
            else // health
            {
                if (healthItems[choose].Value > gameInfo.user.Gold)
                {
                    return false;
                }
                else return true;
            }
        }

        void ShowWeapons(int choose, GameInfo gameInfo)
        {
            for (int i = 0; i < 8; i++) 
            {
                if (i == choose)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($" {weapons[i].Name} | damage: {weapons[i].Damage} | price: {weapons[i].Value}");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (weapons[i].Value < gameInfo.user.Gold)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($" {weapons[i].Name} | damage: {weapons[i].Damage} | price: {weapons[i].Value}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($" {weapons[i].Name} | damage: {weapons[i].Damage} | price: {weapons[i].Value}");
                    Console.ResetColor();
                }
            }

        }
        void ShowItems(int type, int choose, GameInfo gameInfo)
        {
            for (int i = 0; i < 8; i++)
            {
                if (type == 1) // max health
                {
                    if (i == choose)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($" {maxHealthItems[i].Name} | type: {maxHealthItems[i].Type} | price: {maxHealthItems[i].Value}");
                        Console.ResetColor();
                        Console.BackgroundColor= ConsoleColor.Black;
                    }
                    else if (healthItems[i].Value < gameInfo.user.Gold)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($" {maxHealthItems[i].Name} | type: {maxHealthItems[i].Type} | price: {maxHealthItems[i].Value}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($" {maxHealthItems[i].Name} | type: {maxHealthItems[i].Type} | price: {maxHealthItems[i].Value}");
                        Console.ResetColor();
                    }
                }
                else // health
                {
                    if (i == choose)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($" {healthItems[i].Name} | type: {healthItems[i].Type} | price: {healthItems[i].Value}");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (healthItems[i].Value < gameInfo.user.Gold)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($" {healthItems[i].Name} | type: {healthItems[i].Type} | price: {healthItems[i].Value}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($" {healthItems[i].Name} | type: {healthItems[i].Type} | price: {healthItems[i].Value}");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
