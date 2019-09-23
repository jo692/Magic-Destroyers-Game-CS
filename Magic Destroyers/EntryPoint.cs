namespace MagicDestroyers
{
    using MagicDestroyers.Classes;
    using MagicDestroyers.Classes.Casters;
    using MagicDestroyers.Classes.Melees;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();

            Melee currentMelee;
            Caster currentCaster;

            bool gameOver = false;

            //Initialise all characters in the game
            List<Class> characters = new List<Class>()
            {
                new Warrior(),                  //Name text = Red
                new Knight("Jamie", 1),         // "     "  = Pink
                new Assassin("Joe", 1, 20),     // "     "  = Yellow
                new Mage(),                     // "     "  = Blue
                new Druid("Dan", 1),            // "     "  = Green
                new Necromancer("Luke", 1, 20)  // "     "  = Purple
            };

            //Instantiate the teams
            List<Melee> meleeTeam = new List<Melee>();
            List<Caster> casterTeam = new List<Caster>();

            //Populate the teams
            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Caster)
                {
                    casterTeam.Add((Caster)character);
                }
            }

            //Game loop
            while (!gameOver)
            {
                //Select the attackers this turn
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentCaster = casterTeam[rng.Next(0, casterTeam.Count)];

                //Melee char attacks caster char
                currentCaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                Thread.Sleep(750);  //Give a brief pause between console outputs rather than just printing a block of text

                //Check if the caster is dead, if so remove from team
                if (!currentCaster.IsAlive)
                {
                    currentMelee.WonBattle();    //Allocate score to the killer
                    casterTeam.Remove(currentCaster);

                    //Check if there are any spellcasters left, if not, gameOver = true
                    if (casterTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team is victorious!");
                        //gameOver = true;
                        break;
                    }
                    else
                    {
                        //Select new caster to be the attacker
                        currentCaster = casterTeam[rng.Next(0, casterTeam.Count)];
                    }
                }

                // If dead, select another caster to be the attacker

                currentMelee.TakeDamage(currentCaster.Attack(), currentCaster.Name, currentCaster.GetType().ToString());
                Thread.Sleep(750);

                //Check if the melee is dead, if so remove from team
                if (!currentMelee.IsAlive)
                {
                    currentCaster.WonBattle();  //Allocate score to the killer
                    meleeTeam.Remove(currentMelee);

                    //Check if there are any melees left, if not, gameOver = true
                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Caster team is victorious!");
                        //gameOver = true;
                        break;
                    }
                    else
                    {
                        //Select new melee to be the attacker
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }
            }
        }
    }
}

