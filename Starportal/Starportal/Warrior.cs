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
        public string Role { get; set; } = "Null";
        public string Race { get; set; } = "Null";
        public string Gender { get; set; } = "Null";
        public double Attack { get; set; } = 0.0;
        public double Defend { get; set; } = 0.0;
        public double Health { get; set; } = 0.0;
        public double CurrentHealth { get; set; } = 0.0;
        public double Level { get; set; } = 0;

        //for adding D&D Ruleset in a future version
        public int CharacterStrength { get; set; } = 8;
        public int CharacterWisdom { get; set; } = 8;
        public int CharacterDexterity { get; set; } = 8;
        public int CharacterIntelligence { get; set; } = 8;
        public int CharacterConstitution { get; set; } = 8;
        public int CharacterCharisma { get; set; } = 8;



        // Warrior Constructor - For a basic model
        public Warrior(string name, string gender, string race, string role, double attack, double defend, double health, double currentHealth, double level)
        {
            this.Name = name;
            this.Gender = gender;
            this.Race = race;
            this.Role = role;
            this.Attack = attack;
            this.Defend = defend;
            this.Health = health;
            this.CurrentHealth = currentHealth;
            this.Level = level;
        }

        // Will interact with Tavern module to replenish a retreating characters health.
        public double Eat(double food)
        {
            return CurrentHealth += food;
        }

        public double Rest(double rest)
        {
            return CurrentHealth = Health;
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


        #region Warrior Constructor - for a D&D Ruleset in a future version

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
        #endregion

    }
}
