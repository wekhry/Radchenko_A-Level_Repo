using GameMini.Characters;
using GameMini.Enemies;
using GameMini.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMini
{
    internal class TextInterface
    {
        private ICharacter? player;
        private ICharacter? enemy;
        private IAction? playerEquipment;

        public void StartGame()
        {
            Console.WriteLine("Welcome to the mini game!");

            Console.WriteLine("Choose your character: \n(1) Wizard \n(2) Warrior \n(3) Elf");
            int characterChoice = Convert.ToInt32(Console.ReadLine());

            switch (characterChoice)
            {
                case 1:
                    player = new Wizard();
                    break;

                case 2:
                    player = new Warrior();
                    break;

                case 3:
                    player = new Elf();
                    break;

                default:
                    Console.WriteLine("Invalid choise. Defaulting to Elf.");
                    player = new Elf();
                    break;
            }

            Console.WriteLine("Choose your starter equipment: \n(1) Sword \n(2) Wand \n(3) Lance");
            int equipmentChoise = Convert.ToInt32(Console.ReadLine());

            switch (equipmentChoise)
            {
                case 1:
                    playerEquipment = new Sword();
                    break;

                case 2:
                    playerEquipment = new Wand();
                    break;

                case 3:
                    playerEquipment = new Lance();
                    break;

                default:
                    Console.WriteLine("Invalid choise. Defaulting a Lance.");
                    playerEquipment = new Lance();
                    break;
            }

            Random random = new Random();
            int enemyChoice = random.Next(1, 4);

            switch (enemyChoice)
            {
                case 1:
                    enemy = new Goblin();
                    break;

                case 2:
                    enemy = new Troll();
                    break;

                case 3:
                    enemy = new Witch();
                    break;
            }

            Console.WriteLine("A wild " + enemy?.GetType().Name + " appears!");

            bool battleOver = false;
            while(!battleOver)
            {
                Console.WriteLine("Choose your action: \n(1) Action \n(2) Block");
                int actionChoise = Convert.ToInt32(Console.ReadLine());

                switch (actionChoise)
                {
                    case 1:
                        player.Attack();
                        enemy?.Block();
                        break;

                    case 2:
                        player.Block();
                        enemy?.Attack();
                        break;

                    default:
                        Console.WriteLine("Invalid choise. Defaulting to Attack.");
                        player.Attack();
                        enemy?.Block();
                        break;
                }
                Console.WriteLine("The battle continues!");

                Console.WriteLine("Do you want to equip the defeated enemy's equipment? (Y/N)");
                string? equipChoise = Console.ReadLine();

                switch (equipChoise?.ToUpper())
                {
                    case "Y":
                        playerEquipment.PerformAction();
                        break;
                    case "N":
                        Console.WriteLine("You attack one more time!");
                        break;
                    default:
                        Console.WriteLine("Invalid choise. Battle is over!");
                        break;
                }

                battleOver = true;
            }

            Console.WriteLine("Congrats you won!");
            Console.WriteLine("Game over!");
            Console.ReadKey();
        }
    }
}
