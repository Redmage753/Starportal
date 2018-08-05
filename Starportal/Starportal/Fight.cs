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
            Random rndAttack = new Random();
            Random rndBlock = new Random();

            double WeaponStrike()
            {
                return rndAttack.Next(1, Convert.ToInt32(attack));
            }

            double ShieldDefense()
            {
                return rndBlock.Next(1, Convert.ToInt32(defense));
            }

            double damageDealt = WeaponStrike() - ShieldDefense();
            if (damageDealt < 0)
            {
                Console.WriteLine("The strike deals {0} damage, but is blocked by {1} defense.", WeaponStrike(), ShieldDefense());
                Console.WriteLine("The attack was ineffective!");
                return damageDealt = 0;
            }
            else
                Console.WriteLine("The strike deals {0} damage, and is blocked by {1} defense for {2} damage.", WeaponStrike(), ShieldDefense(), damageDealt);

            return damageDealt;
        }

    }
}
