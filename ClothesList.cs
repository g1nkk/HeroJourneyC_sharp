namespace HeroJourneyC_
{
    public interface Clothes
    {
        string Name { get; }
        int Armor { get; }
        int Value { get; }
    }
    public class Pajamas : Clothes
    {
        public string Name { get; } = "Pajamas";
        public int Armor { get; } = 1;
        public int Value { get; } = 0;
    }
    public class RustyMail : Clothes
    {
        public string Name { get; } = "Rusty Mail";
        public int Armor { get; } = 2;
        public int Value { get; } = 100;
    }
    public class BrassArmor : Clothes
    {
        public string Name { get; } = "Brass Armor";
        public int Armor { get; } = 5;
        public int Value { get; } = 140;
    }
    public class LeatherJacket : Clothes
    {
        public string Name { get; } = "Leather Jacket";
        public int Armor { get; } = 6;
        public int Value { get; } = 200;
    }
    public class Cuirass : Clothes
    {
        public string Name { get; } = "Cuirass";
        public int Armor { get; } = 7;
        public int Value { get; } = 240;
    }
    public class Dragonhide : Clothes
    {
        public string Name { get; } = "Dragonhide";
        public int Armor { get; } = 9;
        public int Value { get; } = 300;
    }
    public class RobesOfTheArchmagi : Clothes
    {
        public string Name { get; } = "Robes of the Archmagi";
        public int Armor { get; } = 12;
        public int Value { get; } = 400;
    }
    public class PlateArmor : Clothes
    {
        public string Name { get; } = "Plate Armor";
        public int Armor { get; } = 14;
        public int Value { get; } = 460;
    }
    public class BoneArmor : Clothes
    {
        public string Name { get; } = "Bone Armor";
        public int Armor { get; } = 15;
        public int Value { get; } = 500;
    }
    public class EnchantedArmor : Clothes
    {
        public string Name { get; } = "Enchanted Armor";
        public int Armor { get; } = 17;
        public int Value { get; } = 1000;
    }
    public class ArmorOfGod : Clothes
    {
        public string Name { get; } = "Armor of God";
        public int Armor { get; } = 20;
        public int Value { get; } = 2000;
    }
    public class ClothesList
    {
        public Clothes[] list = new Clothes[10];

        public ClothesList()
        {
            list[0] = new RustyMail();
            list[1] = new BrassArmor();
            list[2] = new LeatherJacket();
            list[3] = new Cuirass();
            list[4] = new Dragonhide();
            list[5] = new RobesOfTheArchmagi();
            list[6] = new PlateArmor();
            list[7] = new BoneArmor();
            list[8] = new EnchantedArmor();
            list[9] = new ArmorOfGod();
        }
    }
}