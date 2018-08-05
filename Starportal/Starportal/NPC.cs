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




    }
}
