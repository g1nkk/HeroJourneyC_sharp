namespace HeroJourneyC_
{
    public class Inventory
    {
        protected Clothes clothes;
        protected Weapon weapon;

        public List<Item> itemList = new List<Item>();

        public void showInventory()
        {
            Console.WriteLine("Inventory:\n");
            Console.WriteLine("Clothes: " + clothes.Name + " - " + clothes.Armor + " armor.");
            Console.WriteLine("Weapon: " + weapon.Name + " - " + weapon.Damage + " damage.");
            Console.WriteLine("Items: ");
            showItemList();
        }

        public void showItemList()
        {
            Console.WriteLine();
            foreach (var item in itemList)
            {
                Console.WriteLine("type: " + item.Type + " | value: " + item.HealValue + " | " + item.Name);
            }
            Console.WriteLine();
        }

        public Clothes Clothes
        {
            set { clothes = value; }
        }

        public Weapon Weapon
        {
            set { weapon = value; }
        }

        public int Armor
        {
            get { return clothes.Armor; } 
        }

        public int Damage
        {
            get { return weapon.Damage; }
        }
    }

    public class Hero : Inventory
    {
        private readonly string name;
        private int hp = 150;
        private int maxHp = 150;
        private int currentKm = 0;
        private int gold = 0;

        public Monster monster;

        public Hero(string name) { this.name = name; }

        public void useItem(int itemPos)
        {
            Console.Clear();
            Console.WriteLine("\t\tYou used " + itemList[itemPos].Name + "!\n");

            if (itemList[itemPos].Type.Equals("max"))
            {
                MaxHp += itemList[itemPos].HealValue;

                Console.WriteLine("Your max health increased by " + itemList[itemPos].HealValue + "!");
                Console.WriteLine("Your new max health: " + MaxHp);
            }
            else
            {
                MaxHp += itemList[itemPos].HealValue;

                Console.WriteLine("Your health increased by " + itemList[itemPos].HealValue + "!");
                Console.WriteLine("Your health: " + hp);
            }

            itemList.RemoveAt(itemPos); // remove item after use
        }

        public int Km
        {
            set
            {
                currentKm++;
            }
            get
            {
                return currentKm;
            }
        }

        public int Hp
        {
            set
            {
                hp += value;
                if (hp > maxHp)
                {
                    hp = maxHp;
                }
            }
            get
            {
                return hp;
            }
        }
        public int MaxHp
        {
            set
            {
                maxHp += value;
            }
            get
            {
                return maxHp;
            }
        }

        public int Gold
        {
            set 
            {
                gold += value;
            }
            get
            {
                return gold;
            }
        }

        public void reduceGold(int gold)
        {
            this.gold -= gold;
        }

        public void ShowPlayerStatistics()
        {
            Console.Clear();
            Console.WriteLine($"{name} statistics: \n");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"MAX HP: {maxHp}");
            Console.WriteLine($"GOLD: {gold}");
            Console.WriteLine($"TRAIL: {currentKm} / 100km.\n");

            showInventory();
        }

        public void monsterAttack()
        {
            Console.WriteLine($"\n\tEnemy attacked with {monster.Strength} damage!");

            int finalDamage=0;
            if (monster.Strength < hp)
            {
                finalDamage = monster.Strength - clothes.Armor;
            }
            else
            {
                hp = 0;
            }

            if (finalDamage > 0)
            {
                Console.WriteLine($"\tArmor absorbed {monster.Strength - finalDamage} damage!");
                Console.WriteLine($"\tYou got {finalDamage} damage!");
                hp -= finalDamage;
            }
            else
            {
                Console.WriteLine($"\tArmor absorbed {monster.Strength} damage!");
                Console.WriteLine($"\tYou got 0 damage!");
            }

            Console.WriteLine($"\tCurrent hp: {hp}");
        }
        void heroAttack()
        {
            Console.WriteLine($"\n\tYou attacked {monster.Name} with {weapon.Damage} strength!");

            int finalDamage;

            if (monster.Armor < weapon.Damage)
                finalDamage = weapon.Damage - monster.Armor;
            else finalDamage = 0;

            monster.Hp-=finalDamage;

            Console.WriteLine($"\t {monster.Name} got {finalDamage} damage!");
            Console.WriteLine($"\t {monster.Name}  hp: {monster.Hp}");
        }
    }
}
