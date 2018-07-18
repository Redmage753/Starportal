using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starportal
{
    class Program
    {
        static void Main(string[] args)
        {

            var role = "No Role";
            var playerName = "Unnamed";
            var playerAttack = 0;
            var playerDefense = 0;
            var playerHealth = 0;
            var playerCurrentHealth = 0;
            

            #region This is class selection

            Console.WriteLine("Welcome to Star Portal!\n" +
                "Please choose a class\n" +
                "1. Warrior\n" +
                "2. Magician\n" +
                "3. Scoundrel\n");

            var userInput = Console.ReadLine();

            while (true)
            {
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

                else
                {
                    Console.WriteLine($"{role} is an invalid choice. Please select:" +
                        $"1 for Warrior\n" +
                        $"2 for Magician\n" +
                        $"3 for Scoundrel\n" +
                        $"x to Exit.\n");
                }
            }
            Console.WriteLine($"You have chosen the path of the {role}!");
            #endregion

            Warrior player = new Warrior(playerName, playerAttack, playerDefense, playerHealth, playerCurrentHealth);

            






            Console.ReadLine();
        }
    }
}
