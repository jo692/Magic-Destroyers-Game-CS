using System;
namespace MagicDestroyers.Classes.Casters
{
    public abstract class Caster : Class
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value < 0 || value > 25)
                {
                    Console.WriteLine("Casters can only have between 0 and 25 mana points. Default 20 set.");
                    this.manaPoints = 20;
                }
                else
                {
                    this.manaPoints = value;
                }
            }
        }

        public Caster(string name, int level, int manaPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}
