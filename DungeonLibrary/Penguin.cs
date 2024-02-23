using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Penguin : Monster
    {
        //FIELDS
        //--ONLY IF YOU HAVE BUSINESS RULES


        //PROPERTIES
        //! At least one property. These should behave differently in each of your subtypes.
        public bool IsBaby
        { get; set; }

        //CONSTRUCTORS
        public Penguin(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description, bool isBaby)
            : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            IsBaby = isBaby;
        }
        public Penguin()
        {
            Name = "Gunter";
            HitChance = 30;
            Dodge = 10;
            MaxLife = 30;
            MinDamage = 10;
            MaxDamage = 25;
            IsBaby = true;
        }


        
        //METHODS
        public override string ToString()
        {
            return base.ToString() +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Description: {Description}";
        }
        public override int CalcDamage()
        {
           int damage = MaxDamage;
            Random random = new Random();

            if (random.Next(1, 101) < 70)
            {
                IsBaby = true;
                damage -= 10;
            }
            return damage;
        }
    }
}

