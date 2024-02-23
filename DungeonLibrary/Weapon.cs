using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public!
    public class Weapon
    {
        //FIELDS
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;


        //PROPERTIES
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        //CONSTRUCTORS
        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            if (minDamage >= maxDamage)
            {
                throw new ArgumentException("Min Damage must be less than max damage.");
            }
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }
        public Weapon(WeaponType weapons)
        {
            switch (weapons)
            {
                case WeaponType.Blood_Sword:
                    Name = "Blood Sword";
                    MinDamage = 15;
                    MaxDamage = 30;
                    BonusHitChance = 60;
                    IsTwoHanded = false;
                    Type = WeaponType.Blood_Sword;
                    break;
                case WeaponType.Daggers:
                    Name = "Ice Daggers";
                    MinDamage = 15;
                    MaxDamage = 27;
                    BonusHitChance = 65;
                    IsTwoHanded = true;
                    Type = WeaponType.Daggers;
                    break;
                case WeaponType.Axe:
                    Name = "Axe Bass";
                    MinDamage = 16;
                    MaxDamage = 35;
                    BonusHitChance = 30;
                    IsTwoHanded = true;
                    Type = WeaponType.Axe;
                    break;
                case WeaponType.Flame_Thrower:
                    Name = "Flame Thrower";
                    MinDamage = 18;
                    MaxDamage = 40;
                    BonusHitChance = 55;
                    IsTwoHanded = false;
                    Type = WeaponType.Flame_Thrower;
                    break;
                case WeaponType.Slingshot:
                    Name = "Slingshot";
                    MinDamage = 14;
                    MaxDamage = 30;
                    BonusHitChance = 60;
                    IsTwoHanded = false;
                    Type = WeaponType.Slingshot;
                    break;
                case WeaponType.Staff:
                    Name = "Staff";
                    MinDamage = 15;
                    MaxDamage = 28;
                    BonusHitChance = 55;
                    IsTwoHanded = false;
                    Type = WeaponType.Staff;
                    break;
            }
        }


        //METHODS
        public override string ToString()
        {
            return base.ToString() +
                    $"{Name}\n" +
                    $"Damage: {MinDamage} - {MaxDamage}\n" +
                    $"Bonus Hit: {BonusHitChance}%\n" +
                    $"{(IsTwoHanded ? "Two" : "One")}-Handed {Type}";
        }
    }
}
