using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder
{
    class NPC : ICharacterTraits
    {
        public string Name { get; set; } = "UnknownMonster";
        public string Role { get; set; } = "Null";
        public string Race { get; set; } = "Null";
        public string Gender { get; set; } = "Null";
        public double Attack { get; set; } = 0.0;
        public double Defend { get; set; } = 0.0;
        public double Health { get; set; } = 0.0;
        public double CurrentHealth { get; set; } = 0.0;

        public NPC(string name, string gender, string race, string role, double attack, double defend, double health, double currentHealth)
        {
            this.Name = name;
            this.Gender = gender;
            this.Race = race;
            this.Role = role;
            this.Attack = attack;
            this.Defend = defend;
            this.Health = health;
            this.CurrentHealth = currentHealth;
        }

        public NPC(double health)
        {
            this.CurrentHealth = health;
        }

        public static NPC operator +(NPC a, NPC b)
        {
            double EncounterHealth = a.CurrentHealth + b.CurrentHealth;
            NPC Encounter = new NPC(EncounterHealth);

            return Encounter;
        }

        /*
        Random rndAttack = new Random();
        Random rndBlock = new Random();

        public double WeaponStrike()
        {
            return rndAttack.Next(1, Convert.ToInt32(Attack));
        }

        public double ShieldDefense()
        {
            return rndBlock.Next(1, Convert.ToInt32(Defend));
        }
        */


    }
}
