namespace MagicDestroyers.Armours
{
    using System;
    public abstract class Armour
    {
        private int armourPoints;

        public int ArmourPoints
        {
            get
            {
                return this.armourPoints;
            }
            set
            {
                if (value >= 0)  //Cloth with zero armour points isn't too ridiculous?
                {
                    this.armourPoints = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate armour value assigned, default value 10 set.");
                    this.armourPoints = 10;
                }

            }
        }

        protected Armour()
        {
            this.ArmourPoints = 10;
        }
    }
}
