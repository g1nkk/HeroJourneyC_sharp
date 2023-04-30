namespace HeroJourneyC_
{
    public class SmallHealthPotion : Item
    {
        public int Value { get; } = 50;
        public int HealValue { get; } = 25;
        public string Name { get; } = "Small Health Potion";
        public string Type { get; } = "heal";
    }
}
