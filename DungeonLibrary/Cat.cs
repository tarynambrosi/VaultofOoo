using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Cat : Monster
    {
        //FIELDS
        //--ONLY IF YOU HAVE BUSINESS RULES


        //PROPERTIES
        //! At least one property. These should behave differently in each of your subtypes.
        public bool HasCrown
        { get; set; }

        //CONSTRUCTORS
        public Cat(string name, int hitChance, int dodge, int maxLife,
            int maxDamage, int minDamage, string description, bool hasCrown)
            : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {

        }
        public Cat()
        {
            Name = "Cat Prince";
            HitChance = 30;
            Dodge = 10;
            MaxLife = 30;
            MinDamage = 10;
            MaxDamage = 25;
            HasCrown = true;
        }



        //METHODS
        public override string ToString()
        {
            return base.ToString() +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Description: {Description}";
        }
        public override int CalcDodge()
        {
            int dodge = Dodge;
            Random random = new Random();

            if (random.Next(1, 50) <30)
            {
                dodge -= 10;
            }
            return dodge;
        }
    }
}