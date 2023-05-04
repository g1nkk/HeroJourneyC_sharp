namespace HeroJourneyC_
{
    public interface Weapon
    {
        string Name { get; }
        int Value { get; }
        int Damage { get; }
    }

    class ButterKnife : Weapon
    {
        public string Name { get; } = "Butter Knife";
        public int Value { get; } = 0;
        public int Damage { get; } = 2;
    }

    class BrassKnuckles : Weapon
    {
        public string Name { get; } = "Brass Knuckles";
        public int Value { get; } = 150;
        public int Damage { get; } = 3;
    }

    class WoodenClub : Weapon
    {
        public string Name { get; } = "Wooden Club";
        public int Value { get; } = 170;
        public int Damage { get; } = 4;
    }

    class SharpDagger : Weapon
    {
        public string Name { get; } = "Sharp Dagger";
        public int Value { get; } = 210;
        public int Damage { get; } = 5;
    }

    class BattleAxe : Weapon
    {
        public string Name { get; } = "Battle Axe";
        public int Value { get; } = 230;
        public int Damage { get; } = 8;
    }
    class OldWarriorSword : Weapon
    {
        public string Name { get; } = "Old Warrior Sword";
        public int Value { get; } = 240;
        public int Damage { get; } = 11;
    }

    class SurvivorsBow : Weapon
    {
        public string Name { get; } = "Survivors Bow";
        public int Value { get; } = 260;
        public int Damage { get; } = 13;
    }

    class EnchantedSword : Weapon
    {
        public string Name { get; } = "Enchanted Sword";
        public int Value { get; } = 290;
        public int Damage { get; } = 14;
    }

    class ExplorersMachete : Weapon
    {
        public string Name { get; } = "Explorers Machete";
        public int Value { get; } = 310;
        public int Damage { get; } = 16;
    }

    class HellFireSword : Weapon
    {
        public string Name { get; } = "Hell Fire Sword";
        public int Value { get; } = 340;
        public int Damage { get; } = 21;
    }

    class Katana : Weapon
    {
        public string Name { get; } = "Katana";
        public int Value { get; } = 370;
        public int Damage { get; } = 29;
    }

    class Mjolnir : Weapon
    {
        public string Name { get; } = "Mjolnir";
        public int Value { get; } = 390;
        public int Damage { get; } = 32;
    }

    class Glock : Weapon
    {
        public string Name { get; } = "Glock 17";
        public int Value { get; } = 400;
        public int Damage { get; } = 35;
    }

    public class WeaponList
    {
        public Weapon[] list = new Weapon[11];

        public WeaponList()
        {
            list[0] = new WoodenClub();
            list[1] = new BrassKnuckles();
            list[2] = new SharpDagger();
            list[3] = new BattleAxe();
            list[4] = new OldWarriorSword();
            list[5] = new SurvivorsBow();
            list[6] = new ExplorersMachete();
            list[7] = new HellFireSword();
            list[8] = new Katana();
            list[9] = new Mjolnir();
            list[10] = new Glock();
        }
        public Weapon GetRandomWeapon()
        {
            var random = new Random();
            int position = random.Next(10);
            return list[position];
        }
    }
}
