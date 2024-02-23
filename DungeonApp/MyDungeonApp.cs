using DungeonLibrary;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace DungeonApp
{
    internal class MyDungeonApp
    {
        static void Main(string[] args)
        {
            #region Title / Introduction
            Console.WriteLine("Vault of Ooo\n");
            Console.WriteLine("The beginning of the end has arrived. The Lich's influence spreads far and wide, corrupting everything it touches. Will you be able to defeat him?\n");
            #endregion

            #region Player set up

            #endregion

            Console.WriteLine("What is your name, hero?");
            Console.WriteLine();
            string userName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Welcome to Ooo, {userName}!\n\n Please choose your race:");
            //confirmation loop
            bool confirmRace = false;
            Race selectedRace = Race.Rainicorn;
            string description = "";
            while (!confirmRace)
            {
                List<Race> raceList = Enum.GetValues<Race>().ToList();
                int indexRace = 1;
                foreach (Race item in raceList)
                {
                    Console.WriteLine($"{indexRace++}) {item}");
                }
                Console.WriteLine();
                string userRace = Console.ReadLine();
                switch (userRace)
                {
                    case "1":
                        selectedRace = Race.Candy;
                        description = "\n~~~~~ Candy Stats ~~~~~" +
                            "\nHit Chance +6\nDodge +2" +
                            "\n\nSweet and resilient, Candy People are made from various science experiments conducted by the princess of the Candy Kingdom. " +
                        "They specialize in healing and agility.";
                        break;
                    case "2":
                        selectedRace = Race.Hyooman;
                        description = "\n~~~~~ Hyooman Stats ~~~~~" +
                            "\nHit Chance +8\nDodge +5" +
                            "\n\nThe descendants of humans who survived the Mushroom War, Hyoomans possess a wide range of skills and abilities. " +
                        "They excel in craftsmanship and adaptability.";
                        break;
                    case "3":
                        selectedRace = Race.Human;
                        description = "\n~~~~~ Human Stats ~~~~~" +
                            "\nHit Chance +5\nDodge +3" +
                            "\n\nBrave and outgoing, but rare. There are very few pure humans left in the land of Ooo. " +
                        "They're normally viewed as well-rounded, but no one is sure about them entirely.";
                        break;
                    case "4":
                        selectedRace = Race.Rainicorn;
                        description = "\n~~~~~ Rainicorn Stats ~~~~~" +
                            "\nHit Chance +10\nDodge -3" +
                            "\n\nProud and majestic, Rainicorns are a race of rainbow-colored creatures with the ability to fly and manipulate the colors in the environment around them. " +
                        "They are especially skilled in aerial combat, using their elemental powers to distract enemies.";
                        break;
                    case "5":
                        selectedRace = Race.Slime;
                        description = "\n~~~~~ Slime Stats ~~~~~" +
                            "\nHit Chance +5\nDodge +10" +
                            "\n\nPlayful and mischievious, Slime People are gooey blobs capable of shapeshifting and regenerating lost limbs. " +
                       "They are especially skilled in stealth and trickery; they're slippery little boogers.";
                        break;
                    case "6":
                        selectedRace = Race.Vampire;
                        description = "\n~~~~~ Vampire Stats ~~~~~" +
                            "\nHit Chance +5\nDodge +4" +
                            "\n\nSome are half-human, some are half-demon... It's a long story. Nonetheless, they possess supernatural abilities that set them apart from mere mortals." +
                        "They command powers of darkness and illusion, yet they prefer to keep a weapon on their back.";
                        break;
                    case "7":
                        selectedRace = Race.Wizard;
                        description = "\n~~~~~ Wizard Stats ~~~~~" +
                            "\nHit Chance +10\nDodge -4" +
                            "\n\nArmed with a book full of enchantments and spells, Wizards are masters of both offensive and defensive magic. " +
                        "They're adaptable and eccentric, but their curosity and demeanor can get the best of them at times.";
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please choose a valid race.");
                        continue;
                }

                Console.WriteLine($"You've chosen: {selectedRace} \n {description}");
                Console.WriteLine("\n\nConfirm your choice with 'Y' or press any other key to see your race options again.");
                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    confirmRace = true;
                }

            }
            Console.Clear();

            Console.WriteLine($"You've selected {selectedRace}! You're going to need a weapon, too.\n\n Take your pick:");
            //confirm weapon loop
            bool confirmWeapon = false;
            WeaponType selectedWeapon = WeaponType.Axe;
            while (!confirmWeapon)
            {
                List<WeaponType> weaponList = Enum.GetValues<WeaponType>().ToList();
                int indexWeapon = 1;
                foreach (WeaponType item in weaponList)
                {
                    Console.WriteLine($"{indexWeapon++}) {item}");
                }
                Console.WriteLine();
                string userWeapon = Console.ReadLine();
                switch (userWeapon)
                {
                    case "1":
                        selectedWeapon = WeaponType.Blood_Sword;
                        description = "\n~~~~~ Blood Sword ~~~~~" +
                            "\nDamage: 15 - 30\nBonus Hit Chance: 60" +
                            "\n\nA sword crafted from the blood of a demon. Its blade is razor-sharp and glows with a faint crimson aura.";
                        break;
                    case "2":
                        selectedWeapon = WeaponType.Axe;
                        description = "\n~~~~~ Axe Bass ~~~~~" +
                            "\nDamage: 16 - 35\nBonus Hit Chance: 30" +
                            "\n\n The Axe Bass is a unique and versatile weapon, combining the sharp edge of an axe with the melodic tones of a bass guitar.";
                        break;
                    case "3":
                        selectedWeapon = WeaponType.Slingshot;
                        description = "\n~~~~~ Slime Slingshot ~~~~~" +
                            "\nDamage: 14 - 30\nBonus Hit Chance: 60" +
                            "\n\nThe frame of the Slingshot is made from a sturdy, elastic material infused with slime, giving it a vibrant green color and a rubbery texture." +
                            "\nThe pouch where the projectile rests is lined with a layer of sticky slime, ensuring that the projectile sticks to the target upon impact.";
                        break;
                    case "4":
                        selectedWeapon = WeaponType.Daggers;
                        description = "\n~~~~~ Ice Daggers ~~~~~" +
                           "\nDamage: 15 - 27\nBonus Hit Chance: 65" +
                           "\n\nCrafted from enchanted ice harvested from the Ice Kingdom, these daggers are as deadly as they are beautiful. The blades shimmer with an icy blue hue.";
                        break;
                    case "5":
                        selectedWeapon = WeaponType.Flame_Thrower;
                        description = "\n~~~~~ Flame Thrower ~~~~~" +
                           "\nDamage: 18 - 40\nBonus Hit Chance: 55" +
                           "\n\nCrafted by the Queen of the Flame Kingdom, this fearsome weapon harnesses the power of fire to scorch enemies and light up the darkest corners of Ooo.";
                        break;
                    default:
                        selectedWeapon = WeaponType.Staff;
                        description = "\n~~~~~ Staff ~~~~~" +
                            "\nDamage: 15 - 28\nBonus Hit Chance: 55" +
                            "\n\nA majestic weapon crafted by the Rainicorns, the Staff is known for their vibrant colors and mystical powers." +
                            "\nThe staff is adorned with intricate carvings and shimmering gemstones that seem to glow with an otherworldly light.";
                        break;
                }
                Console.WriteLine($"You've selected {description}");
                Console.WriteLine("\nConfirm your choice with 'Y' or press any other key to see your weapon options again.");
                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    confirmWeapon = true;
                }
            }
            Console.Clear();
            Player player = new Player(userName, 70, 50, 100, selectedRace, new Weapon(selectedWeapon));
            #region Main Game Loop

            bool exit = false;//if true, quit the whole game
            do
            {
                Monster monster = null;
                if (player.Score >= 5)
                {
                    monster = Monster.GetBossMonster();
                }
                else
                {
                    monster = Monster.GetMonster();
                }

                string room = GetRoom();

                Console.WriteLine(room);
                Console.Write("In this room... ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(monster.Name);
                Console.ResetColor();

                #region Encounter loop
                bool newRoom = false;
                do
                {
                    #region MENU
                    //Prompt the user
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "E) Enemy Info\n" +
                        "X) Exit\n");

                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case "A":
                            Console.WriteLine("ATTACK!");
                            bool deadMonster = Combat.DoBattle(player, monster);
                            newRoom = deadMonster;
                            break;

                        case "R":
                            //monster free attack chance
                            Console.WriteLine("Run away!!!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee...");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            newRoom = true;
                            break;

                        case "P":
                            Console.WriteLine("Oh! A hero...");
                            Console.WriteLine(player);
                            break;

                        case "E":
                            Console.WriteLine("Enemy stats: ");
                            Console.WriteLine(monster);
                            break;

                        case "X":
                            Console.WriteLine("Where are you going, hero? The Lich is only getting stronger...");
                            exit = true;
                            break;

                        default:
                            #region Invalid Input
                            Console.WriteLine("You have made a grave error. Wanna try again?");
                            #endregion
                            break;
                    }

                    #endregion

                    #region Check player life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Waaaaaah!\a");
                        exit = true; //ends the game
                    }
                    #endregion
                } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                #endregion
            } while (!exit);//while exit is not true, keep looping

            #endregion

            #region Outro
            Console.WriteLine($"You defeated {player.Score} monster(s).");

            #region Endings
            //TODO endings/boss ending
            if (player.Score == 0)
            {
                Console.WriteLine("Ending 1 of 3:");
                Console.WriteLine("\nAs the gates of the Vault creak open, a chilling wind carries the dark laughter of the Lich and his minions." +
                    "\nDespite your valiant efforts, the forces of darkness have emerged victorious, their malevolent presence spreading like a shadow over the land of Ooo." +
                    "\nRest easy, " + userName + ".");
            }
            if (player.Score >= 5)
            {
                Console.WriteLine("Ending 2 of 3:");
                Console.WriteLine("\nAs you stand before the towering gates of the Vault, you can't help but feel a pang of regret. Despite your best efforts, the dark aura of the Lich looms in the distance, its power too great for you to overcome. " +
                    "\nThe people of Ooo, however, are safe for now, thanks to your valiant efforts in keeping the monsters at bay.");
            }
            if (player.Score == 6)
            {
                Console.WriteLine("Ending 3 of 3:");
                Console.WriteLine("\nAs the final blow lands, The Lich lets out a deafening scream, crumbling into dust before your eyes. " +
                    "The once dark and foreboding presence is no more, and a wave of relief washes over the Land of Ooo.");
            }

            #endregion
            Console.ReadKey(true);
            #endregion//Final Score, end the story
        }

        private static string GetRoom()
        {
            string[] rooms =
            {
                "Endless shelves of dusty tomes line the walls of this sprawling chamber, their contents ranging from arcane spells to forgotten histories. Flickering torches cast dancing shadows across towering bookcases, while wisps of magic linger in the air.", //0
                "A riot of colors greets you as you step into this verdant chamber, where exotic flowers bloom in abundance and fairies flutter through the air. Sparkling fountains gurgle amidst lush foliage, while mystical runes glow faintly beneath your feet.", //1
                "Crumbling stone pillars and weathered statues bear silent witness to the passage of time in this forgotten chamber. Intricate carvings adorn the walls, telling tales of a bygone era and hinting at untold mysteries hidden within.", //2
                "Darkness enevelops you as you enter the crypt, the air thick with an eerie stillness. Cobwebs cling to the walls, and ancient sarcophagi line the chamber, their contents shrouded in mystery.", //3
                "Starlight fills this celestial chamber, where telescopes and intricate charts are scattered amongst the dusty cobblestone. Cosmic energies crackle in the air, and the twinkle of distant galaxies illuminates the darkness."  //4
            };
            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];

            return room;

            //refactoring -> rewriting code
            //return rooms[new Random().Next(rooms.Length)];
        }
    }
}
