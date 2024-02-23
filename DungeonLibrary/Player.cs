using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //PROPERTIES
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }

        //CONSTRUCTORS
        public Player(string name, int hitChance, int dodge, int maxLife,
            Race playerRace, Weapon equippedWeapon) 
            : base(name, hitChance, dodge, maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Racial Bonuses
            switch (playerRace)
            {
                case Race.Rainicorn:
                    HitChance += 10;
                    Dodge -= 3;
                    break;
                case Race.Hyooman:
                    HitChance += 8;
                    Dodge += 5;
                    break;
                case Race.Slime:
                    HitChance += 5;
                    Dodge += 10;
                    break;
                case Race.Wizard:
                    HitChance += 10;
                    Dodge -= 4;
                    break;
                case Race.Candy:
                    HitChance += 6;
                    Dodge += 2;
                    break;
                case Race.Human:
                    HitChance += 5;
                    Dodge += 3;
                    break;
                case Race.Vampire:
                    HitChance += 5;
                    Dodge += 4;
                    break;
                default: 
                    break;
            }
            #endregion
        }

        //METHODS
        public override string ToString()
        {
            #region Race descriptions
            string description = "";
            switch (PlayerRace)
            {
                case Race.Rainicorn:
                    description = "Proud and majestic, Rainicorns are a race of rainbow-colored creatures with the ability to fly and manipulate the colors in the environment around them. " +
                        "They are especially skilled in aerial combat, using their elemental powers to distract enemies.";
                    break;
                case Race.Hyooman:
                    description = "The descendants of humans who survived the Mushroom War, Hyoomans possess a wide range of skills and abilities. " +
                        "They excel in craftsmanship and adaptability.";
                    break;
                case Race.Slime:
                    description = "Playful and mischievious, Slime People are gooey blobs capable of shapeshifting and regenerating lost limbs. " +
                        "They are especially skilled in stealth and trickery; they're slippery little boogers.";
                    break;
                case Race.Wizard:
                    description = "Armed with a book full of enchantments and spells, Wizards are masters of both offensive and defensive magic. " +
                        "They're adaptable and eccentric, but their curosity and demeanor can get the best of them at times.";
                    break;
                case Race.Candy:
                    description = "Sweet and resilient, Candy People are made from various science experiments conducted by the princess of the Candy Kingdom. " +
                        "They specialize in healing and agility.";
                    break;
                case Race.Human:
                    description = "Brave and outgoing, but rare. There are very few pure humans left in the land of Ooo. " +
                        "They're normally viewed as well-rounded, but no one is sure about them entirely.";
                    break;
                case Race.Vampire:
                    description = "Some are half-human, some are half-demon... It's a long story. Nonetheless, they possess supernatural abilities that set them apart from mere mortals." +
                        "They command powers of darkness and illusion, yet they prefer to keep a weapon on their back.";
                    break;
                default:
                    break;
            }
            #endregion

            return base.ToString() + $"Score: {Score}" +
                $"\nWeapon: {EquippedWeapon.Name}\n" +
                $"Description: {description}";
        }
        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage);
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
