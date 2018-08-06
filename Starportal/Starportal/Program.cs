using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterBuilder;
using ScenarioBuilder;

namespace Starportal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            var role = "No Role";
            var race = "No Race";
            var gender = "No gender";
            var userInput = "Null";

            var characterName = "NullName";
            var characterGender = "NullGender";
            var characterRole = "NullRole";
            var characterRace = "NullRace";
            var characterAttack = 0;
            var characterDefense = 0;
            var characterHealth = 0;
            var characterCurrentHealth = 0;
            var pointDistribution = 30;
            #endregion

            Console.WriteLine("Welcome to the Infinity Continuum Inn & Tavern! \n\nAdventurers come to us from around the world to explore the dangerous worlds found beyond the infamous Star Portal.\n\n" +
                              "Right now, we’ve managed a modicum of control – we can send you to any of the primordial elemental planes. The problem is, we don’t know which one you will get before – you’ll find out only once you’ve passed through. We believe if you can recover an elemental core from each location, our resident warlock Vanarak will be able to develop a more precise control unit. He may even be able to amplify the power to reach other locations!\n\n" +
                              "If this task is too dangerous, there is still a wealth of treasures to be found in the realms. Feel free to pursue as shallow or deep as you want into each world. Just remember where your exit door is, or you won’t be able to return!\n\n" +
                              "Now, let’s find out who our explorers are today!\n");


            #region Class selection

            Console.WriteLine("Please choose a class\n" +
                "1. Warrior\n" +
                "2. Magician\n" +
                "3. Scoundrel\n");


            while (true)
            {
                userInput = Console.ReadLine();

                role = userInput.ToString();
                if (role == "1")
                {
                    characterRole = "Warrior";
                    break;
                }

                if (role == "2")
                {
                    characterRole = "Magician";
                    break;
                }

                if (role == "3")
                {
                    characterRole = "Scoundrel";
                    break;
                }

                else
                {
                    Console.WriteLine($"{role} is an invalid choice. Please select:" +
                        $"1 for Warrior\n" +
                        $"2 for Magician\n" +
                        $"3 for Scoundrel\n");
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
                    characterRace = "Human";
                    break;
                }

                if (race == "2")
                {
                    characterRace = "Elf";
                    break;
                }

                if (race == "3")
                {
                    characterRace = "Dwarf";
                    break;
                }

                if (race == "4")
                {
                    characterRace = "Halfling";
                    break;
                }


                else
                {
                    Console.WriteLine($"{race} is an invalid choice. Please select:" +
                        $"1 for Human\n" +
                        $"2 for Elf\n" +
                        $"3 for Dwarf\n" +
                        $"4 for Halfling\n");
                }
            }
            #endregion

            #region Gender selection

            Console.WriteLine($"Your characters gender is:\n" +
                "1. Male \n" +
                "2. Female \n" +
                "3. Other \n");

            while (true)
            {
                userInput = Console.ReadLine();

                gender = userInput.ToString();
                if (gender == "1")
                {
                    characterGender = "Male";
                    break;
                }

                if (gender == "2")
                {
                    characterGender = "Female";
                    break;
                }

                if (gender == "3")
                {
                    characterGender = "Other";
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

            Console.WriteLine($"You have chosen the path of the {characterRace} {characterRole}!\n");
            #region Name & Stats

            Console.WriteLine($"What is your {characterRace} {characterRole}'s name?\n");
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



            #region Character Object creation & Printer
            

            // if (characterRole == "Warrior") {
            Warrior playerOne = new Warrior(characterName, characterGender, characterRace, characterRole, characterAttack, characterDefense, characterHealth, characterCurrentHealth, 0);
            
            Console.WriteLine($"{playerOne.Name}, {playerOne.Gender} {playerOne.Race} {playerOne.Role}, has a strength of {playerOne.Attack}, a defense of {playerOne.Defend}, and {playerOne.CurrentHealth} health.");
            // }
            /*
            // FIXME  - change to Magician class when filled out
            if (characterRole == "Magician") {
            Warrior playerOne = new Warrior(characterName, characterGender, characterRace, characterRole, characterAttack, characterDefense, characterHealth, characterCurrentHealth);
            
            Console.WriteLine($"{playerOne.Name}, {playerOne.Gender} {playerOne.Race} {playerOne.Role}, has a strength of {playerOne.Attack}, a defense of {playerOne.Defend}, and {playerOne.CurrentHealth} health.");
            }

            // FIXME  - change to Scoundrel class when filled out
            if (characterRole == "Scoundrel") {
            Warrior playerOne = new Warrior(characterName, characterGender, characterRace, characterRole, characterAttack, characterDefense, characterHealth, characterCurrentHealth);
            
            Console.WriteLine($"{playerOne.Name}, {playerOne.Gender} {playerOne.Race} {playerOne.Role}, has a strength of {playerOne.Attack}, a defense of {playerOne.Defend}, and {playerOne.CurrentHealth} health.");
            }
            */
            #endregion

            #region FireDungeon Creation
            Dungeon PlaneOfFireLevel1 = new Dungeon ("You have entered the primordial plane of Fire. Around you, a desolate hellscape of volcanic ash fills the air. Streams of lava flow over an obsidian landscape. Before you are 2 fire elemental guardians. \n", "South", "North");
            NPC FireGuardian1 = new NPC("Fire Elemental 1", "Other", "Elemental", "Enemy", 5, 2, 15, 15);
            NPC FireGuardian2 = new NPC("Fire Elemental 2", "Other", "Elemental", "Enemy", 5, 2, 15, 15);

            Dungeon PlaneOfFireLevel2 = new Dungeon("You proceed north. As you approach the Temple, you see a gathering of Yuan-ti. \n", "South", "East");
            NPC FireSalamandar1 = new NPC("Kaladin", "Other", "Yuan-ti", "Enemy", 10, 6, 20, 20);
            NPC FireSalamandar2 = new NPC("Kendric", "Other", "Yuan-ti", "Enemy", 6, 4, 20, 20);

            Dungeon PlaneOfFireLevel3 = new Dungeon("You proceed north. As you approach the Temple, you see a gathering of Yuan-ti. \n", "South", "East");
            NPC FireDevilBoss = new NPC("Err'tu", "Other", "Devil", "Enemy", 15, 10, 40, 40);

            #endregion


            #region Adventure Interactions
            while (true)
                {
                var userAction = "0";
                Console.WriteLine("\nEnter the portal? (Y, N)\n");

                userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y" && playerOne.Level == 0)
                    {
                    // FIXME: randomly choose an elemental room for the appropriate level
                    
                    #region FireTest
                    bool exit = false;
                    while (exit == false) // non random for testing
                    {
                        Console.WriteLine($"{PlaneOfFireLevel1.RoomDescription}");
                        Console.WriteLine($"Looking over your shoulder to the {PlaneOfFireLevel1.DoorExit}, you see the Portal back to the tavern. Behind {FireGuardian1.Name}, you see a Temple in the {PlaneOfFireLevel1.DoorProgress}.\nDefeat the guardians to proceed!\n");

                        while (FireGuardian1.CurrentHealth + FireGuardian2.CurrentHealth > 0 && playerOne.CurrentHealth > 0)
                        {

                            // test statement
                            // Console.WriteLine($"Encounter Health: {FireGuardian1.CurrentHealth} + {FireGuardian2.CurrentHealth} = {FireGuardian1.CurrentHealth + FireGuardian2.CurrentHealth}");
                            // end test
                            double HealthLoss = 0;
                            Console.WriteLine("\n" +
                                "1. Attack\n" +
                                "2. Retreat\n");
                            userAction = Console.ReadLine();

                            if (userAction == "1")
                            {
                                var userTarget = "0";
                                // if one is defeated and the two isn't, autofight number 2.
                                if (FireGuardian1.CurrentHealth <= 0 && FireGuardian2.CurrentHealth > 0)
                                {
                                    HealthLoss = Fight.Round(playerOne.Attack, FireGuardian2.Defend);
                                    FireGuardian2.CurrentHealth -= HealthLoss;
                                    Console.WriteLine($"{FireGuardian2.Name} has {FireGuardian2.CurrentHealth} hitpoints left.\n");

                                    if (FireGuardian2.CurrentHealth > 0)
                                    {
                                        Console.WriteLine($"{FireGuardian2.Name} strikes back!\n");
                                        HealthLoss = Fight.Round(FireGuardian2.Attack, playerOne.Defend);
                                        playerOne.CurrentHealth -= HealthLoss;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{FireGuardian2.Name} is defeated!");
                                        FireGuardian2.CurrentHealth = 0;
                                    }
                                    Console.WriteLine($"{playerOne.Name} has {playerOne.CurrentHealth} hitpoints left.\n");

                                }
                                // if two is defeated and one isn't, autofight number 1.
                                if (FireGuardian2.CurrentHealth <= 0 && FireGuardian1.CurrentHealth > 0)
                                {
                                    HealthLoss = Fight.Round(playerOne.Attack, FireGuardian1.Defend);
                                    FireGuardian1.CurrentHealth -= HealthLoss;
                                    Console.WriteLine($"{FireGuardian1.Name} has {FireGuardian1.CurrentHealth} hitpoints left.\n");

                                    if (FireGuardian1.CurrentHealth > 0)
                                    {
                                        Console.WriteLine($"{FireGuardian1.Name} strikes back!\n");
                                        HealthLoss = Fight.Round(FireGuardian1.Attack, playerOne.Defend);
                                        playerOne.CurrentHealth -= HealthLoss;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{FireGuardian1.Name} is defeated!");
                                        FireGuardian1.CurrentHealth = 0;
                                    }
                                    Console.WriteLine($"{playerOne.Name} has {playerOne.CurrentHealth} hitpoints left.\n");
                                }
                                // if both are alive:
                                else
                                {
                                    Console.WriteLine("Which one do you want to attack?\n" +
                                        "1. {0}\n" +
                                        "2. {1}\n", FireGuardian1.Name, FireGuardian2.Name);
                                    userTarget = Console.ReadLine();
                                    bool turnExit = false;
                                    while (turnExit == false)
                                    {
                                        if (userTarget == "1")
                                        {
                                            Console.WriteLine($"{playerOne.Name} attacks!\n");
                                            HealthLoss = Fight.Round(playerOne.Attack, FireGuardian1.Defend);
                                            FireGuardian1.CurrentHealth -= HealthLoss;

                                            if (FireGuardian1.CurrentHealth > 0)
                                            {
                                                Console.WriteLine($"{FireGuardian1.Name} strikes back!\n");
                                                HealthLoss = Fight.Round(FireGuardian1.Attack, playerOne.Defend);
                                                playerOne.CurrentHealth -= HealthLoss;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{FireGuardian1.Name} is defeated!");
                                                FireGuardian1.CurrentHealth = 0;
                                            }

                                            Console.WriteLine($"{FireGuardian2.Name} strikes!\n");
                                            HealthLoss = Fight.Round(FireGuardian2.Attack, playerOne.Defend);
                                            playerOne.CurrentHealth -= HealthLoss;

                                            turnExit = true;
                                            break;
                                        }

                                        if (userTarget == "2")
                                        {
                                            Console.WriteLine($"{playerOne.Name} attacks!\n");
                                            HealthLoss = Fight.Round(playerOne.Attack, FireGuardian2.Defend);
                                            FireGuardian2.CurrentHealth -= HealthLoss;

                                            Console.WriteLine($"{FireGuardian2.Name} strikes back!\n");
                                            HealthLoss = Fight.Round(FireGuardian2.Attack, playerOne.Defend);
                                            playerOne.CurrentHealth -= HealthLoss;

                                            Console.WriteLine($"{FireGuardian1.Name} strikes!\n");
                                            HealthLoss = Fight.Round(FireGuardian1.Attack, playerOne.Defend);
                                            playerOne.CurrentHealth -= HealthLoss;

                                            turnExit = true;
                                            break;
                                        }
                                        if (userTarget != "1" && userTarget != "2")
                                        {
                                            Console.WriteLine("Please choose 1 or 2.");
                                            userTarget = Console.ReadLine();
                                        }
                                    }
                                }
                                Console.WriteLine($"{FireGuardian1.Name} has {FireGuardian1.CurrentHealth} hitpoints left.");
                                Console.WriteLine($"{FireGuardian2.Name} has {FireGuardian2.CurrentHealth} hitpoints left.");
                                Console.WriteLine($"{playerOne.Name} has {playerOne.CurrentHealth} hitpoints left.");
                            }
                            if (userAction == "2")
                            {
                                Console.WriteLine("You escape through the {0} exit.", PlaneOfFireLevel1.DoorExit);
                                exit = true;
                                break;
                            }
                            if (userAction != "1" && userAction != "2")
                            {
                                Console.WriteLine("Invalid choice. Fight, or retreat!\n");
                            }

                        }

                        if (playerOne.CurrentHealth <= 0)
                        {
                            Console.WriteLine($"{playerOne.Name} has died. Game Over");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                        if (FireGuardian1.CurrentHealth == 0 && FireGuardian2.CurrentHealth == 0 && playerOne.Level <= 0)
                        {
                            Console.WriteLine("You leveled!");
                            playerOne.Level += 1;
                            playerOne.Attack += 3;
                            playerOne.Defend += 3;
                            playerOne.Health += 5;
                        }

                        else if (exit == true) { break; }
                                           

                        // add levels 2 and 3 here.
                        else
                        {
                            while (true)
                            {               
                                Console.WriteLine($"Do you proceed {PlaneOfFireLevel1.DoorProgress} toward the Temple or return {PlaneOfFireLevel1.DoorExit} to the tavern?" +
                                    $"\n1. Proceed." +
                                    $"\n2. Return to Tavern.\n");
                                userAction = Console.ReadLine();
                                if (userAction == "1")
                                {
                                    Console.WriteLine("This is level 2.\n");
                                    Console.ReadLine();

                                }

                                if (userAction == "2")
                                {
                                    Console.WriteLine("You retreat through the portal to the safety of the Tavern.");
                                    exit = true;
                                    break;
                                }
                                if (userAction != "1" && userAction != "2")
                                { Console.WriteLine("Please select a valid option.\n"); }
                            }
                            
                        }
                        // all monsters defeated
                        exit = true;
                        #endregion
                    }
                }

                if (userInput == "N" || userInput == "n")
                    {
                        // make fun tavern interactions - patron teasing, barmaid or owner banter/rumors. Offer tavern menu options.
                        // make a class filled with a random select that outputs a teasing line
                    Console.WriteLine("\nJeering Adventurer: What are you, a coward!?\n");
                    Console.WriteLine("While being jeered; you decide to eat and rest up.\n");
                    playerOne.CurrentHealth = playerOne.Health;
                    Console.WriteLine("Minutes later, you feel refreshed. (You have {0} hitpoints}", playerOne.CurrentHealth);
                }

                if (userInput != "Y" && userInput != "y" && userInput != "n" && userInput != "N")
                    {
                        Console.WriteLine("Invalid Option, please try again.\n");
                    }
                }
            #endregion


        }
    }
}
