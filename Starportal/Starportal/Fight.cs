using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterBuilder;

namespace Starportal
{
    class Fight
    {
        public static double Round(double attack, double defense)
        {
            Random rnd = new Random();

            double WeaponStrike()
            {
                return rnd.Next(1, Convert.ToInt32(attack));
            }

            double ShieldDefense()
            {
                return rnd.Next(1, Convert.ToInt32(defense));
            }

            double strike = WeaponStrike();
            double block = ShieldDefense();


            double damageDealt = strike - block;
            if (damageDealt < 0)
            {
                Console.WriteLine("The strike deals {0} damage, but is blocked by {1} defense.\n", strike, block);
                Console.WriteLine("The attack was ineffective!\n");
                return damageDealt = 0;
            }
            else
                Console.WriteLine("The strike deals {0} damage and is blocked by {1} defense for {2} damage.", strike, block, damageDealt);

            return damageDealt;
        }

    }
}
