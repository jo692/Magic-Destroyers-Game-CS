namespace MagicDestroyers.Classes.Casters
{
    using MagicDestroyers.Armours.Cloth;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    public class Necromancer : Caster
    {
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly ClothRobe DEFAULT_ARMOUR = new ClothRobe();

        public Necromancer()
            : this(Consts.Necromancer.DEFAULT_NAME, Consts.Necromancer.DEFAULT_LEVEL)
        {
        }
        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.DEFAULT_MANAPOINTS)
        {
        }
        public Necromancer(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = Consts.Necromancer.DEFAULT_HEALTHPOINTS;
            base.Faction = Consts.Necromancer.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmour = DEFAULT_ARMOUR;
        }

        public int ShadowRage()
        {
            return base.Weapon.Damage + 10;
        }

        public int VampiricTouch()
        {
            throw new NotImplementedException();
        }

        public int BoneShield()
        {
            return base.BodyArmour.ArmourPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.VampiricTouch();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }
    }
}