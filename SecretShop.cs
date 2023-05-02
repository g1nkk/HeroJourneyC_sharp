namespace HeroJourneyC_
{
    class SecretShop
    {
        protected Hero user;

        private Weapon[] weapons = new Weapon[4];
        private Item[] healthItems = new Item[4];
        private Item[] maxHealthItems = new Item[4];

        private WeaponList weaponList;
        private HealthItemList healthItemList;
        private MaxHealthItemList maxHealthItemList;

        public enum ShopType { Weapon, Health, MaxHealth }

        public SecretShop(WeaponList wl, HealthItemList hil, MaxHealthItemList mhil, Hero user)
        {
            weaponList = wl;
            healthItemList = hil;
            maxHealthItemList = mhil;
            this.user = user;
        }

        public void SetRandomProduct()
        {
            string[] dots = { ".", "..", "...", "...." };
            for (int i = 0; i < 4; i++)
            {
                Console.Clear();
                Console.WriteLine($"\n\tGenerating shop range{dots[i]}");
                Thread.Sleep(700);
                weapons[i] = weaponList.getRandomWeapon();
                healthItems[i] = healthItemList.GetRandomHealthItem();
                maxHealthItems[i] = maxHealthItemList.GetRandomMaxHealthItem();
            }
        }
    }
}
