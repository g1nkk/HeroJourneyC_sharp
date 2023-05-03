namespace HeroJourneyC_
{
    public class SmallMaxHealthPotion : Item
    {
        public int Value { get; } = 100;
        public int HealValue { get; } = 20;
        public string Name { get; } = "Small Max Health Potion";
        public string Type { get; } = "max";
    }

    public class MediumMaxHealthPotion : Item
    {
        public int Value { get; } = 200;
        public int HealValue { get; } = 35;
        public string Name { get; } = "Medium Max Health Potion";
        public string Type { get; } = "max";
    }

    public class BigMaxHealthPotion : Item
    {
        public int Value { get; } = 300;
        public int HealValue { get; } = 55;
        public string Name { get; } = "Big Max Health Potion";
        public string Type { get; } = "max";
    }

    public class MagicPotion : Item
    {
        public int Value { get; } = 100;
        public int HealValue { get; } = 25;
        public string Name { get; } = "Magic Potion";
        public string Type { get; } = "max";
    }

    public class StrengthPotion : Item
    {
        public int Value { get; } = 150;
        public int HealValue { get; } = 40;
        public string Name { get; } = "Strength Potion";
        public string Type { get; } = "max";
    }

    public class TrueHeroPotion : Item
    {
        public int Value { get; } = 150;
        public int HealValue { get; } = 35;
        public string Name { get; } = "True Hero Potion";
        public string Type { get; } = "max";
    }

    public class MaxHealthItemList
    {
        public Item[] maxHealthItemList;

        public MaxHealthItemList()
        {
            maxHealthItemList = new Item[]
            {
            new SmallMaxHealthPotion(),
            new MediumMaxHealthPotion(),
            new BigMaxHealthPotion(),
            new MagicPotion(),
            new StrengthPotion(),
            new TrueHeroPotion(),
            new SmallMaxHealthPotion(),
            new MediumMaxHealthPotion(),
            new BigMaxHealthPotion(),
            new MagicPotion()
            };
        }

        public Item GetRandomMaxHealthItem()
        {
            Random rand = new Random();
            int position = rand.Next(10);
            return maxHealthItemList[position];
        }
    }
}
