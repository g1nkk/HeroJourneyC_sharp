namespace HeroJourneyC_
{
    public interface Monster
    {
        string Name { get; }
        int Strength { get; }
        int Revard { get; }
        int Hp { get; set; }
        int Armor { get; }
        void restoreHP();
    }

    class Slime : Monster
    {
        public string Name { get; } = "SLIME";
        public int Strength { get; } = 3;
        public int Revard { get; } = 14;
        public int Hp { get; set; } = 8;
        public int Armor { get; } = 0;
        public void restoreHP()
        {
            Hp = 8;
        }
    }

    class Pirate : Monster
    {
        public string Name { get; } = "PIRATE";
        public int Strength { get; } = 21;
        public int Revard { get; } = 75;
        public int Hp { get; set; } = 75;
        public int Armor { get; } = 5;
        public void restoreHP()
        {
            Hp = 75;
        }
    }

    class HeadlessHorseman : Monster
    {
        public string Name { get; } = "HEADLESS HORSEMAN";
        public int Strength { get; } = 12;
        public int Revard { get; } = 75;
        public int Hp { get; set; } = 65;
        public int Armor { get; } = 5;
        public void restoreHP()
        {
            Hp = 65;
        }
    }

    class Yeti : Monster
    {
        public string Name { get; } = "YETI";
        public int Strength { get; } = 15;
        public int Revard { get; } = 112;
        public int Hp { get; set; } = 70;
        public int Armor { get; } = 1;
        public void restoreHP()
        {
            Hp = 100;
        }
    };

    class Giant : Monster
    {
        public string Name { get; } = "GIANT";
        public int Strength { get; } = 7;
        public int Revard { get; } = 150;
        public int Hp { get; set; } = 120;
        public int Armor { get; } = 9;
        public void restoreHP()
        {
            Hp = 120;
        }
    }

    class Golem : Monster
    {
        public string Name { get; } = "GOLEM";
        public int Strength { get; } = 7;
        public int Revard { get; } = 150;
        public int Hp { get; set; } = 60;
        public int Armor { get; } = 12;
        public void restoreHP()
        {
            Hp = 60;
        }
    };

    class CursedWarrior : Monster
    {
        public string Name { get; } = "CURSED WARRIOR";
        public int Strength { get; } = 21;
        public int Revard { get; } = 150;
        public int Hp { get; set; } = 55;
        public int Armor { get; } = 3;
        public void restoreHP()
        {
            Hp = 55;
        }
    }

    class GoblinThief : Monster
    {
        public string Name { get; } = "GOBLIN THIEF";
        public int Strength { get; } = 6;
        public int Revard { get; } = 40;
        public int Hp { get; set; } = 21;
        public int Armor { get; } = 0;
        public void restoreHP()
        {
            Hp = 21;
        }
    }

    class Ghoul : Monster
    {
        public string Name { get; } = "GHOUL";
        public int Strength { get; } = 7;
        public int Revard { get; } = 40;
        public int Hp { get; set; } = 25;
        public int Armor { get; } = 2;
        public void restoreHP()
        {
            Hp = 25;
        }
    }

    class Necromancer : Monster
    {
        public string Name { get; } = "NECROMANCCER";
        public int Strength { get; } = 10;
        public int Revard { get; } = 133;
        public int Hp { get; set; } = 62;
        public int Armor { get; } = 6;
        public void restoreHP()
        {
            Hp = 62;
        }
    }

    class Demon : Monster
    {
        public string Name { get; } = "DEMON";
        public int Strength { get; } = 12;
        public int Revard { get; } = 72;
        public int Hp { get; set; } = 19;
        public int Armor { get; } = 5;
        public void restoreHP()
        {
            Hp = 19;
        }
    }

    class Zombie : Monster
    {
        public string Name { get; } = "ZOMBIE";
        public int Strength { get; } = 5;
        public int Revard { get; } = 65;
        public int Hp { get; set; } = 22;
        public int Armor { get; } = 2;
        public void restoreHP()
        {
            Hp = 22;
        }
    }

    class GoblinMage : Monster
    {
        public string Name { get; } = "GOBLIN MAGE";
        public int Strength { get; } = 12;
        public int Revard { get; } = 65;
        public int Hp { get; set; } = 21;
        public int Armor { get; } = 0;
        public void restoreHP()
        {
            Hp = 21;
        }
    }

    class EscapedPrisoner : Monster
    {
        public string Name { get; } = "ESCAPED PRISONER";
        public int Strength { get; } = 4;
        public int Revard { get; } = 51;
        public int Hp { get; set; } = 36;
        public int Armor { get; } = 0;
        public void restoreHP()
        {
            Hp = 36;
        }
    }

    class Werewolf : Monster
    {
        public string Name { get; } = "WAREWOLF";
        public int Strength { get; } = 8;
        public int Revard { get; } = 75;
        public int Hp { get; set; } = 35;
        public int Armor { get; } = 5;
        public void restoreHP()
        {
            Hp = 35;
        }
    }

    class SkeletonWarrior : Monster
    {
        public string Name { get; } = "SKELETON WARRIOR";
        public int Strength { get; } = 12;
        public int Revard { get; } = 110;
        public int Hp { get; set; } = 22;
        public int Armor { get; } = 2;
        public void restoreHP()
        {
            Hp = 22;
        }
    }

    class Spider : Monster
    {
        public string Name { get; } = "SPIDER";
        public int Strength { get; } = 6;
        public int Revard { get; } = 30;
        public int Hp { get; set; } = 15;
        public int Armor { get; } = 0;
        public void restoreHP()
        {
            Hp = 15;
        }
    }

    class Dragon : Monster
    {
        public string Name { get; } = "DRAGON";
        public int Strength { get; } = 21;
        public int Revard { get; } = 0;
        public int Hp { get; set; } = 200;
        public int Armor { get; } = 4;
        public void restoreHP()
        {
            Hp = 200;
        }
    }

    public class MonsterList
    {
        Monster[] list = new Monster[20];

        public Monster getFinalBoss()
        {
            return new Dragon();
        }

        public Monster getRandomMonster(int currentKm)
        {
            var rand = new Random();

            int position;

            if (currentKm > 3)
            {
                position = rand.Next((currentKm / 4));
            }
            else
            {
                position = 0;
            }

            if (position < 17)
                return list[position];
            else
                return list[16];
        }

        public MonsterList()
        {
            list[0] = new Slime();
            list[1] = new GoblinThief();
            list[2] = new Spider();
            list[3] = new Zombie();
            list[4] = new Ghoul();
            list[5] = new GoblinMage();
            list[6] = new SkeletonWarrior();
            list[7] = new EscapedPrisoner();
            list[8] = new Werewolf();
            list[9] = new Demon();
            list[10] = new Necromancer();
            list[11] = new Pirate();
            list[12] = new Yeti();
            list[13] = new Giant();
            list[14] = new HeadlessHorseman();
            list[15] = new Golem();
            list[16] = new CursedWarrior();
        }
    };
}