using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterBuilder;

namespace Starportal
{
    class Program
    {
        static void Main(string[] args)
        {

            var role = "No Role";
            var race = "No Race";
            var gender = "No gender";
            var userInput = "No Race";

            var characterName = "Unnamed";
            var characterAttack = 0;
            var characterDefense = 0;
            var characterHealth = 0;
            var characterCurrentHealth = 0;
            var pointDistribution = 30;

            Console.WriteLine("Welcome to the Infinity Continuum Inn & Tavern! \n\nAdventurers come to us from around the world to explore the dangerous worlds found beyond the infamous Star Portal!\n\n " +
                              "Right now, we’ve managed a modicum of control – we can send you to any of the primordial elemental planes. The problem is, we don’t know which one you will get before – you’ll find out only once you’ve passed through. We believe if you can recover an elemental core from each location, our resident warlock Vanarak will be able to develop a more precise control unit. He may even be able to amplify the power to reach other locations!\n\n" +
                              "If this task is too dangerous, there is still a wealth of treasures to be found in the realms. Feel free to pursue as shallow or deep as you want into each world. Just remember where your exit door is, or you won’t be able to return!\n\n" +
                              "Now, let’s find out who our explorers are today!");


            #region Class selection

            Console.WriteLine("Please choose a class\n" +
                "1. Warrior\n" +
                "2. Magician\n" +
                "3. Scoundrel\n +" +
                "x to exit at any time.");


            while (true)
            {
                userInput = Console.ReadLine();

                role = userInput.ToString();
                if (role == "1")
                {
                    role = "Warrior";
                    break;
                }

                if (role == "2")
                {
                    role = "Magician";
                    break;
                }

                if (role == "3")
                {
                    role = "Scoundrel";
                    break;
                }
                
                if (role == "x")
                {
                    Console.WriteLine("Goodbye.");
                    break;                    
                }

                else
                {
                    Console.WriteLine($"{role} is an invalid choice. Please select:" +
                        $"1 for Warrior\n" +
                        $"2 for Magician\n" +
                        $"3 for Scoundrel\n" +
                        $"x to Exit.\n");
                }
            }
            #endregion

            #region Race selection
            
            Console.WriteLine("Please choose a race by entering the associated number:\n" +
                "1. Human\n" +
                "2. Elf\n" +
                "3. Dwarf\n" +
                "4. Halfling\n.");     

            while (true)
            {
                race = "No Race";

                userInput = Console.ReadLine();

                race = userInput.ToString();
                if (race == "1")
                {
                    race = "Human";
                    break;
                }

                if (race == "2")
                {
                    race = "Elf";
                    break;
                }

                if (race == "3")
                {
                    race = "Dwarf";
                    break;
                }

                if (race == "4")
                {
                    race = "Halfling";
                    break;
                }

                if (race == "x")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                    
                }


                else
                {
                    Console.WriteLine($"{race} is an invalid choice. Please select:" +
                        $"1 for Human\n" +
                        $"2 for Elf\n" +
                        $"3 for Dwarf\n" +
                        $"4 for Halfling\n" +
                        $"x to Exit.\n");
                }
            }
            #endregion
            Console.WriteLine($"You have chosen the path of the {race} {role}!\n");
            #region Name & Stats

            Console.WriteLine($"What is your {race} {role}'s name?\n");
            characterName = Console.ReadLine();

            Console.WriteLine($"You have {pointDistribution} to spread between Attack, Health, and Defense.");

            Console.WriteLine($"Out of {pointDistribution}, how strong is {characterName}'s attack?\n");
            characterAttack = int.Parse(Console.ReadLine());

            if (characterAttack >= pointDistribution-1 || characterAttack < 1)
            {
                while (characterAttack >= pointDistribution-1 || characterAttack < 1)
                {
                    Console.WriteLine($"Invalid Choice. Please select an option greater than 1 and less than {pointDistribution}.\n");

                    Console.WriteLine($"Out of {pointDistribution}, how strong is {characterName}'s attacks?\n");
                    characterAttack = int.Parse(Console.ReadLine());
                }
                pointDistribution -= characterAttack;
            }
            else pointDistribution -= characterAttack;

            Console.WriteLine($"Out of {pointDistribution}, how healthy is {characterName}?\n");
            characterHealth = int.Parse(Console.ReadLine());

            if (characterHealth >= pointDistribution || characterHealth < 1)
            {
                while (characterHealth >= pointDistribution || characterHealth < 1)
                {
                    Console.WriteLine($"Invalid Choice. Please select an option greater than 1 and less than {pointDistribution}.\n");

                    Console.WriteLine($"Out of {pointDistribution}, how strong is {characterName}?\n");
                    characterHealth = int.Parse(Console.ReadLine());
                }
                pointDistribution -= characterHealth;
            }
            else pointDistribution -= characterHealth;

            characterCurrentHealth = characterHealth;

            Console.WriteLine($"Out of {pointDistribution}, how strong is {characterName}'s self defense?\n");
            characterDefense = int.Parse(Console.ReadLine());

            if (characterDefense > pointDistribution || characterDefense < 1)
            {
                while (characterDefense > pointDistribution || characterDefense < 1)
                {
                    Console.WriteLine($"Invalid Choice. Please select an option greater than 1 and less than {pointDistribution}.\n");

                    Console.WriteLine($"Out of {pointDistribution}, how strong is {characterName}'s self defense?\n");
                    characterDefense = int.Parse(Console.ReadLine());
                }
                pointDistribution -= characterDefense;
            }
            else pointDistribution -= characterDefense;

            Console.WriteLine($"{characterName} has a strength of {characterAttack}, {characterHealth} hitpoints, and a defense of {characterDefense}.");

            #endregion
            #region Gender selection

            Console.WriteLine($"{characterName} is \n" +
                "1. Male \n" +
                "2. Female \n" +
                "3. Other \n" +
                "x to Exit.\n");

            while (true)
            {
                userInput = Console.ReadLine();

                gender = userInput.ToString();
                if (gender == "1")
                {
                    gender = "Male";
                    break;
                }

                if (gender == "2")
                {
                    gender = "Female";
                    break;
                }

                if (gender == "3")
                {
                    gender = "Other";
                    break;
                }

                if (gender == "x")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }

                else
                {
                    Console.WriteLine($"{characterName} is \n" +
                        $"1. Male \n" +
                        $"2. Female \n" +
                        $"3. Other \n" +
                        $"x to Exit.\n");
                }
            }
            #endregion
            Warrior playerOne = new Warrior(characterName, characterAttack, characterDefense, characterHealth, characterCurrentHealth);
            
            Console.WriteLine($"{playerOne.Name} has a strength of {playerOne.Attack}, a defense of {playerOne.Defend}, and {playerOne.CurrentHealth} health.");







            Console.ReadLine();
        }
    }
}
