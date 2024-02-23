using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Worm : Monster
    {
        //FIELDS
        //--ONLY IF YOU HAVE BUSINESS RULES


        //PROPERTIES
        //! At least one property. These should behave differently in each of your subtypes.
        public bool IsHypnotized
        { get; set; }

        //CONSTRUCTORS
        public Worm(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description, bool isHypnotized)
            : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            
        }
        public Worm()
        {
            Name = "Gunter";
            HitChance = 30;
            Dodge = 10;
            MaxLife = 30;
            MinDamage = 10;
            MaxDamage = 25;
            IsHypnotized = true;
        }



        //METHODS
        public override string ToString()
        {
            return base.ToString() +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Description: {Description}";
        }
        public override int CalcHitChance()
        {
            int chance = HitChance;
            Random random = new Random();

            if (random.Next(1, 101) < 70)
            {
                chance -= 10;
            }
            return chance;
        }
    }
}