

namespace MagicDestroyers.Classes.Casters
{
    using MagicDestroyers.Armours.Cloth;
    using MagicDestroyers.Weapons.Blunt;
    using System;

    public class Mage : Caster
    {
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_ARMOUR = new ClothRobe();

        public Mage()
            : this(Consts.Mage.DEFAULT_NAME, Consts.Mage.DEFAULT_LEVEL)
        {
        }
        public Mage(string name, int level)
            : this(name, level, Consts.Mage.DEFAULT_MANAPOINTS)
        {
        }
        public Mage(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            base.HealthPoints = Consts.Mage.DEFAULT_HEALTHPOINTS;
            base.Faction = Consts.Mage.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmour = DEFAULT_ARMOUR;
        }

        public int Fireball()
        {
            return base.Weapon.Damage + 10;
        }
        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return base.BodyArmour.ArmourPoints + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }

        public override int Defend()
        {
            return this.Meditation();
        }
    }
}