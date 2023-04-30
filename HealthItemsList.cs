namespace HeroJourneyC_
{
    public class SmallHealthPotion : Item
    {
        public int Value { get; } = 50;
        public int HealValue { get; } = 25;
        public string Name { get; } = "Small Health Potion";
        public string Type { get; } = "heal";
    }

    public class MediumHealthPotion : Item
    {
        public int Value { get; } = 70;
        public int HealValue { get; } = 25;
        public string Name { get; } = "Medium Health Potion";
        public string Type { get; } = "heal";
    }

    public class BigHealthPotion : Item
    {
        public int Value { get; } = 90;
        public int HealValue { get; } = 38;
        public string Name { get; } = "Big Health Potion";
        public string Type { get; } = "heal";
    }

    public class FieryFoliage : Item
    {
        public int Value { get; } = 50;
        public int HealValue { get; } = 20;
        public string Name { get; } = "Fiery Foliage";
        public string Type { get; } = "heal";
    }

    public class ChimericMoss : Item
    {
        public int Value { get; } = 60;
        public int HealValue { get; } = 25;
        public string Name { get; } = "Chimeric Moss";
        public string Type { get; } = "heal";
    }

    public class DragonRosehip : Item
    {
        public int Value { get; } = 70;
        public int HealValue { get; } = 30;
        public string Name { get; } = "Dragon Rosehip";
        public string Type { get; } = "heal";
    }

    public class JohnsWort : Item
    {
        public int Value { get; } = 55;
        public int HealValue { get; } = 17;
        public string Name { get; } = "St. John's wort";
        public string Type { get; } = "heal";
    }

    public class Honeycomb : Item
    {
        public int Value { get; } = 65;
        public int HealValue { get; } = 25;
        public string Name { get; } = "Honeycomb";
        public string Type { get; } = "heal";
    }

    public class HerbsSet : Item
    {
        public int Value { get; } = 55;
        public int HealValue { get; } = 15;
        public string Name { get; } = "Herbs Set";
        public string Type { get; } = "heal";
    }

    public class MysteriousBottle : Item
    {
        public int Value { get; } = 80;
        public int HealValue { get; } = 35;
        public string Name { get; } = "Mysterious Bottle";
        public string Type { get; } = "heal";
    }
    public class HealthItemList
    {
        private Item[] healthItemList = new Item[10];

        public HealthItemList()
        {
            healthItemList = new Item[]
            {
            new SmallHealthPotion(),
            new MediumHealthPotion(),
            new BigHealthPotion(),
            new FieryFoliage(),
            new ChimericMoss(),
            new DragonRosehip(),
            new JohnsWort(),
            new Honeycomb(),
            new HerbsSet(),
            new MysteriousBottle()
            };
        }

        public Item GetRandomHealthItem()
        {
            Random random = new Random();
            int position = random.Next(0, 10);
            return healthItemList[position];
        }
    }
}