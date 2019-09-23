namespace MagicDestroyers.Classes.Melees
{
    using MagicDestroyers.Armours.Mail;
    using MagicDestroyers.Weapons.Sharp;
    using System;

    public class Warrior : Melee
    {
        //These cannot go into the Consts file since we cannot have instances in a static class
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private readonly ChainLink DEFAULT_ARMOUR = new ChainLink();
        public Warrior()
            : this(Consts.Warrior.DEFAULT_NAME, Consts.Warrior.DEFAULT_LEVEL)
        {
        }
        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.DEFAULT_ABILITYPOINTS)
        {
        }
        public Warrior(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            base.HealthPoints = Consts.Warrior.DEFAULT_HEALTHPOINTS;
            base.Faction = Consts.Warrior.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmour = DEFAULT_ARMOUR;
        }

        public int Strike()
        {
            //Strike will deal base weapon damage plus 10 extra damage
            return (base.Weapon.Damage + 10);
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }

        public int SkinHarden()
        {
            //Defend will return the armour points + an additional 5 defence
            return (base.BodyArmour.ArmourPoints + 5);
        }

        //Give these overriden methods access to the class specific methods through the abstract class Class
        //  this allows us to use the characters special abilities from within a List<Class>
        //  which we couldn't do before since Class warrior = new Warrior() will only have the methods
        //  outlined in Class. However by linking them like this using polymorphism we can use them.
        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}