namespace MagicDestroyers.Classes.Melees
{
    using MagicDestroyers.Armours.Leather;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    public class Assassin : Melee
    {
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_ARMOUR = new LeatherVest();

        public Assassin()
            : this(Consts.Assassin.DEFAULT_NAME, Consts.Assassin.DEFAULT_LEVEL)
        {
        }
        public Assassin(string name, int level)
            : this(name, level, Consts.Assassin.DEFAULT_ABILITYPOINTS)
        {
        }
        public Assassin(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = Consts.Assassin.DEFAULT_HEALTHPOINTS;
            base.Faction = Consts.Assassin.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmour = DEFAULT_ARMOUR;
        }

        public int Bleed()
        {
            return base.Weapon.Damage + 10;
        }
        public int Raze()
        {
            throw new NotImplementedException();
        }
        public int Survival()
        {
            return base.BodyArmour.ArmourPoints + 5;
        }

        public override int Attack()
        {
            return this.Bleed();
        }

        public override int SpecialAttack()
        {
            return this.Raze();
        }

        public override int Defend()
        {
            return this.Survival();
        }
    }
}