namespace MagicDestroyers.Classes.Melees
{
    using MagicDestroyers.Armours.Mail;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    public class Knight : Melee
    {
        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private readonly ChainLink DEFAULT_ARMOUR = new ChainLink();

        public Knight()
            : this(Consts.Knight.DEFAULT_NAME, Consts.Knight.DEFAULT_LEVEL)
        {
        }
        public Knight(string name, int level)
            : this(name, level, Consts.Knight.DEFAULT_ABILITYPOINTS)
        {
        }
        public Knight(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = Consts.Knight.DEFAULT_HEALTHPOINTS;
            base.Faction = Consts.Knight.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmour = DEFAULT_ARMOUR;
        }

        public int HolyBlow()
        {
            return base.Weapon.Damage + 10;
        }

        public int PurifySoul()
        {
            throw new NotImplementedException();
        }

        public int RighteousWings()
        {
            return base.BodyArmour.ArmourPoints + 5;
        }

        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}