using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starportal
{
    class Warrior : ICharacterStats, ICharacterActions
    {
        // initialize interface contract
        public string Name { get; set; } = "UnknownPlayer";
        public double Attack { get; set; } = 10.0;
        public double Defend { get; set; } = 10.0;
        public double Health { get; set; } = 100.0;
        public double currentHealth { get; set; } = 100.0;

        public double Eat(double food)
        {
            return Health + food;
        }

        public double Rest(double rest)
        {
            return currentHealth = Health;
        }
        
        // Warrior Constructor
        public Warrior(string name, double attack, double defend, double health, double currentHealth)
        {
            Name = name;
            Attack = attack;
            Defend = defend;
            Health = health;
            this.currentHealth = currentHealth;
        }





    }
}
