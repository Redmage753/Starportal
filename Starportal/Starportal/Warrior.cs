using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder
{
    class Warrior : ICharacterTraits, ICharacterActions, ICharacterStats
    {
        // initialize interface contract
        public string Name { get; set; } = "UnknownPlayer";
        public double Attack { get; set; } = 0.0;
        public double Defend { get; set; } = 0.0;
        public double Health { get; set; } = 0.0;
        public double CurrentHealth { get; set; } = 0.0;

        public int CharacterStrength { get; set; } = 8;
        public int CharacterWisdom { get; set; } = 8;
        public int CharacterDexterity { get; set; } = 8;
        public int CharacterIntelligence { get; set; } = 8;
        public int CharacterConstitution { get; set; } = 8;
        public int CharacterCharisma { get; set; } = 8;

        public double Eat(double food)
        {
            return CurrentHealth += food;
        }

        public double Rest(double rest)
        {
            return CurrentHealth = Health;
        }
        
        // Warrior Constructor - For a basic model
        public Warrior(string name, double attack, double defend, double health, double currentHealth)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defend = defend;
            this.Health = health;
            this.CurrentHealth = currentHealth;
        }

        // Warrior Constructor - for a D&D model

        public Warrior(string name, double weapon, double armorclass, double health, double currentHealth, int strength, int wisdom, int dexterity, int intelligence, int constitution, int charisma)
        {
            this.Name = name;
            this.Attack = weapon;
            this.Defend = armorclass;
            this.Health = health;
            this.CurrentHealth = currentHealth;

            this.CharacterCharisma = charisma;
            this.CharacterConstitution = constitution;
            this.CharacterStrength = strength;
            this.CharacterWisdom = wisdom;
            this.CharacterIntelligence = intelligence;
            this.CharacterDexterity = dexterity;
        }






    }
}
