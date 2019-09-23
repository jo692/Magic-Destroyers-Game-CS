namespace MagicDestroyers.Classes.Melees
{
    using System;
    public abstract class Melee : Class
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value < 0 || value > 20)
                {
                    Console.WriteLine("Melees can only have between 0 and 20 ability points. Default 10 set.");
                    this.abilityPoints = 10;
                }
                else
                {
                    this.abilityPoints = value;
                }
            }
        }

        public Melee(string name, int level, int abilityPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}
