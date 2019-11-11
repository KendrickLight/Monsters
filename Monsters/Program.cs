using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    // **************************************************
    //
    // Title: Monsters
    // Description: Demonstration of classes and objects
    // Author: Velis, John
    // Dated Created: 11/11/2019
    // Last Modified: 
    //
    // **************************************************    
    class Program
    {
        static void Main(string[] args)
        {
            List<Monsters> monsters = InitialaizeMonsterList();

            //
            // call Menu
            //
            DisplayMenuScreen(monsters);

        }

        static List<Monster> InitialaizeMonsterList()
        {
            List<Monster> monsters = new List<Monster>();

            //
            //Create new monsters
            //
            Monster sid = new Monster();
            Monster lucy = new Monster();

            //
            // Update monster properties
            //
            sid.Name = "Sid";
            sid.Age = 155;
            sid.Attitude = Monster.EmotionalState.happy;

            lucy.Name = "Lusy";
            lucy.Age = 143;
            lucy.Attitude = Monster.EmotionalState.angery;

            //
            //add monsters to the list 
            //
            monsters.Add(sid);
            monsters.Add(lucy);

            return monsters;

        }

        static void DisplayMenuScreen(List<Monster> monsters)
        {
            bool quitApplication = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("a) List All Monsters");
                Console.WriteLine("b) View monsters");
                Console.WriteLine("c) Add Monster");
                Console.WriteLine("d) ");
                Console.WriteLine("e) ");
                Console.WriteLine("f) ");
                Console.WriteLine("q) Quit");
                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":

                        DisplayAllMonsters(monsters);

                        break;

                    case "b":
                        DisplayViewMonsters(monsters);

                        break;

                    case "c":
                        DisplayAddMonster(monsters);
                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":

                        break;

                    case "q":
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }


            } while (!quitApplication);
        }
        static void DisplayAddMonster(List<Monster> monsters)
        {
            Monster newMonster = new Monster();

            DisplayScreenHeader("add Monster");

            //
            // Get new properties
            //

            Console.Write("name: ");
            newMonster.Name = Console.ReadLine();

            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out int age);
            newMonster.Age = age;

            Console.Write("Attitude: ");
            Enum.TryParse(Console.ReadLine(), out Monster.EmotionalState attitude);
            newMonster.Attitude = attitude;

            //
            // Echo back to user
            //
            Console.WriteLine("Monster properties");
            MonsterInfo(newMonster);

            DisplayContinuePrompt();

            monsters.Add(newMonster);
        }
        static void DisplayViewMonsters(List<Monster> monsters)
        {
            string name;
            Monster monsterToView = null;

            DisplayScreenHeader("View Monster");

            Console.WriteLine("List of monsters");
            foreach (Monster monster in monsters)
            {
                Console.WriteLine(monster.Name);
            }
            Console.WriteLine();

            //
            //User choose
            //
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            //
            // Get monster
            //
            foreach (Monster monster in monsters)
            {
                if (monster.Name == name)
                {
                    monsterToView = monster;
                    break;
                }
            }

            //monsterToView = monsters.FirstOrDefault(m => m.Name == name);

            //
            // Display detail
            //
            MonsterInfo(monsterToView);



            DisplayContinuePrompt();
        }

        static void MonsterInfo(Monster monster)
        {
            DisplayScreenHeader($"\tName: {monster.Name}");
            DisplayScreenHeader($"\tAge: {monster.Age}");
            DisplayScreenHeader($"\tAttitude: {monster.Attitude}");
        }

        static void DisplayAllMonsters(List<Monster> monsters)
        {
            DisplayScreenHeader("All Monsters");

            Console.WriteLine("------------------------");
            foreach (Monster monster in monsters)
            {
                MonsterInfo(monster);

                Console.WriteLine("------------------------");
            }



            DisplayContinuePrompt();
        }

        #region HELPER METHODS

        /// <summary>
        /// display welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThe Calculator");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using the Calculator!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
