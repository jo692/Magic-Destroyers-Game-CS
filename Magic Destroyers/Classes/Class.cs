namespace MagicDestroyers.Classes
{
    using MagicDestroyers.Classes.Interfaces;
    using MagicDestroyers.Armours;
    using MagicDestroyers.Enumerations;
    using MagicDestroyers.Weapons;
    using System;
    public abstract class Class : IAttack, IDefend
    {
        //Fields
        private Faction faction;

        private Weapon weapon;
        private Armour bodyArmour;

        private bool isAlive;

        private int healthPoints;
        private int level;
        private int scores;

        private string name;

        //Properties
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Armour BodyArmour
        {
            get
            {
                return this.bodyArmour;
            }
            set
            {
                this.bodyArmour = value;
            }
        }
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine("Characters have between 1 and 100 health points, default value 75 set.");
                    this.healthPoints = 75;
                }
                else
                {
                    this.healthPoints = value;
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Character levels must be between 1 and 100, default level 1 set.");
                    this.level = 1;
                }

            }
        }
        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    this.name = "No name";
                    Console.WriteLine("Names must be between 2 and 10 characters, please input another.");
                }

            }
        }

        //Constructors
        public Class()
        {
        }

        public Class(string name, int level)
        {
            this.Name = name;
            this.Level = level;
            this.isAlive = true;
            this.scores = 0;
        }

        //Abstract methods to be overridden within the individual classes
        public abstract int Attack();
        public abstract int SpecialAttack();
        public abstract int Defend();
        //This method allows us to avoid coupling during the attack of a character, by not passing as argument the attack target
        //  instead this method seeks to directly reduce the defending characters damage.
        public void TakeDamage(int damage, string attackerName, string attackerType)
        {
            //Check if damage is enough to penetrate defense, if so apply damage
            if(this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();
                
                //Check if hes dead
                if(this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Your attack had no effect.");
            }

            //Check if the recipient of the damage is dead
            if (!this.isAlive)
            {
                Tools.TypeSpecificColourCW(this.name, this.GetType().ToString());
                Console.Write($" recieved {damage - this.Defend()} damage from ");
                Tools.TypeSpecificColourCW(attackerName, attackerType);
                Console.Write($", and has subsequently perished.\n");
                //Console.WriteLine($"{this.name} recieved {damage - this.Defend()} damage from {attackerName}, and has subsequently perished.");
            }
            else
            {
                Tools.TypeSpecificColourCW(this.name, this.GetType().ToString());
                Console.Write($" recieved {damage - this.Defend()} damage from ");
                Tools.TypeSpecificColourCW(attackerName, attackerType);
                Console.Write($", and now has {this.healthPoints} HP remaining.\n");
                //Console.WriteLine($"{this.name} recieved {damage - this.Defend()} damage from {attackerName}, and now has {this.healthPoints} HP remaining.");
            }
        }
        //When a character deals lethal damage (kills) to other character, he gains one score. Every 10 score points = level up
        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
