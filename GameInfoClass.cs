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
}
