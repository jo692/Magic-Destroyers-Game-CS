namespace MagicDestroyers
{
    using System;
    public static class Tools
    {
        public static void TypeSpecificColourCW(string message, string type)
        {
            switch (type)
            {
                case "MagicDestroyers.Classes.Melees.Warrior":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "MagicDestroyers.Classes.Melees.Knight":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "MagicDestroyers.Classes.Melees.Assassin":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "MagicDestroyers.Classes.Casters.Mage":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "MagicDestroyers.Classes.Casters.Druid":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "MagicDestroyers.Classes.Casters.Necromancer":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
