namespace MagicDestroyers
{
    using MagicDestroyers.Enumerations;

    public static class Consts
    {
        public static class Warrior
        {
            public const Faction DEFAULT_FACTION = Faction.Melee;
            public const int DEFAULT_LEVEL = 1;
            public const int DEFAULT_HEALTHPOINTS = 100;
            public const int DEFAULT_ABILITYPOINTS = 10;
            public const string DEFAULT_NAME = "Garrosh";
        }

        public static class Knight
        {
            public const Faction DEFAULT_FACTION = Faction.Melee;
            public const int DEFAULT_LEVEL = 1;
            public const int DEFAULT_HEALTHPOINTS = 100;
            public const int DEFAULT_ABILITYPOINTS = 15;
            public const string DEFAULT_NAME = "Uther";
        }

        public static class Assassin
        {
            public const Faction DEFAULT_FACTION = Faction.Melee;
            public const int DEFAULT_LEVEL = 1;
            public const int DEFAULT_HEALTHPOINTS = 80;
            public const int DEFAULT_ABILITYPOINTS = 20;
            public const string DEFAULT_NAME = "Edwin";
        }

        public static class Mage
        {
            public const Faction DEFAULT_FACTION = Faction.Caster;
            public const int DEFAULT_LEVEL = 1;
            public const int DEFAULT_HEALTHPOINTS = 75;
            public const int DEFAULT_MANAPOINTS = 25;
            public const string DEFAULT_NAME = "Khadgar";
        }

        public static class Druid
        {
            public const Faction DEFAULT_FACTION = Faction.Caster;
            public const int DEFAULT_LEVEL = 1;
            public const int DEFAULT_HEALTHPOINTS = 100;
            public const int DEFAULT_MANAPOINTS = 20;
            public const string DEFAULT_NAME = "Cenarious";
        }

        public static class Necromancer
        {
            public const Faction DEFAULT_FACTION = Faction.Caster;
            public const int DEFAULT_LEVEL = 1;
            public const int DEFAULT_HEALTHPOINTS = 85;
            public const int DEFAULT_MANAPOINTS = 20;
            public const string DEFAULT_NAME = "Kel'Thuzad";
        }
    }
}
