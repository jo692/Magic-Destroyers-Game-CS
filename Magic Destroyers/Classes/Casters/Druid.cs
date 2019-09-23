namespace MagicDestroyers.Classes.Casters
{
    using MagicDestroyers.Armours.Leather;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    public class Druid : Caster
    {
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_ARMOUR = new LeatherVest();

        public Druid()
            : this(Consts.Druid.DEFAULT_NAME, Consts.Druid.DEFAULT_LEVEL)
        {
        }
        public Druid(string name, int level)
            : this(name, level, Consts.Druid.DEFAULT_MANAPOINTS)
        {
        }
        public Druid(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = Consts.Druid.DEFAULT_HEALTHPOINTS;
            base.Faction = Consts.Druid.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmour = DEFAULT_ARMOUR;
        }

        public int Moonfire()
        {
            return base.Weapon.Damage + 10;
        }

        public int Starburst()
        {
            throw new NotImplementedException();
        }

        public int OneWithNature()
        {
            return base.BodyArmour.ArmourPoints + 5;
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.OneWithNature();
        }
    }
}