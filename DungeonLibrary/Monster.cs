using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public, make it a child of Character
    public class Monster : Character
    {

        //FIELDS
        private int _minDamage;
        //PROPERTIES
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //CONSTRUCTORS
        public Monster(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description)
            : base(name, hitChance, dodge, maxLife)
        {
            //MaxDamage must be set before MinDamage
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        //default ctor for default monsters later
        //If your parent class does not have a parameterless ctor, you CANNOT have one in the child classes.
        public Monster() : base()
        {
            MaxDamage = 2;
            MinDamage = 1;
            Description = "Default monster";
            Name = "Default name";
        }
        //METHODS
        public override string ToString()
        {
            return "************* MONSTER *************\n" +
                base.ToString() +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Description: {Description}";
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
        public static Monster GetMonster()
        {
            Monster m1 = new("Ricardio the Heartbreaker", 50, 20, 70, 35, 10, "Ricardio, the charming yet sinister heart of the Ice King, emerges as a formidable enemy in the depths of the dungeon." +
                "With a face as handsome as his intentions are vile, Ricardio lures unsuspecting adventurers with promises of aid and knowledge.");
            Monster m2 = new("Magic Man", 50, 20, 75, 35, 10, "Magic Man is an enigmatic and unpredictable sorcerer. With a gleeful cackle and a flick of his wand," +
                "Magic Man sets his sights on tormenting and confounding any who dare to cross his path.");
            Monster m3 = new("Me-Mow", 50, 20, 70, 25, 15, "Me-Mow, the diminutive yet deadly assassin, lurks in the shadows of the dungeon, poised to strike " +
                "with deadly precision at a moment's notice. This cunning feline is a fearsome adversary and should never be let out of your sight.");
            Monster m4 = new("Orgalorg", 70, 40, 80, 25, 15, "Orgalorg, the ancient cosmic entity, slumbers deep within the cosmos, its true form shrouded in mystery. " +
                "When awakened, its presence causes stars to tremble and worlds to quake. Orgalorg's thirst for power knows no bounds, and it seeks to consume entire galaxies to fuel its cosmic might.");
            Monster m5 = new Penguin("Gunter", 50, 20, 50, 25, 10, "Gunter, also known as Orgalorg, has now awakened his true power and " +
                "seeks to unleash cosmic chaos upon the land. Don't let his humble penguin-appearance fool you, for he is an ancient cosmic entity.", true);
            Monster m6 = new Worm("Worm", 50, 20, 45, 15, 8, "", true);
            Monster m7 = new Cat("Cat Prince", 50, 20, 50, 20, 10, "Cat Prince, a feline of royal bearing, roams the land with an air of entitlement. His elegant yet deceivingly agile movements make him a formidable foe. " +
                "While not inherently malicious, he guards his territory with a princely pride, challenging all who dare to cross his path.", true);
            Monster m8 = new NormalMan("Normal Man", 50, 20, 50, 20, 10, "Normal Man, once a powerful wizard, now mischievous and unpredictable. " +
                "He appears frail and unassuming, but his magic is tricky and potent. His attacks may seem harmless at first but can quickly overwhelm the unprepared.", true);


            List<Monster> monsters = new List<Monster>()
            {
                m1, m1, m1,
                m2, m2, m2,
                m3, m3, m3,
                m4, m4, m4,
                m5,
                m6,
                m7,
                m8
            };

            int randomIndex = new Random().Next(monsters.Count);
            Monster monster = monsters[randomIndex];
            return monster;

        }
        public static Monster GetBossMonster()
        {
            Monster boss = new("The Lich", 90, 50, 95, 30, 15, "The Lich is a master of dark magic, capable of casting powerful spells that manipulate reality itself. " +
                "\nHe seeks to bring about the end of all life in Ooo and unleash chaos upon the world. " +
                "\nWith his dark powers, he can raise the dead, control minds, and warp the fabric of existence to suit his sinister will.");
            return boss;
        }

    }
}
