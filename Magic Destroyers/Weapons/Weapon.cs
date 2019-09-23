namespace MagicDestroyers.Weapons
{
    using System;
    public abstract class Weapon
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value > 0)
                {
                    this.damage = value;
                }
                else
                {
                    Console.WriteLine("Weapon damage must be greater than zero, default value 10 assigned.");
                    this.damage = 10;
                }

            }
        }

        protected Weapon()
        {
            this.Damage = 10;
        }
    }
}
