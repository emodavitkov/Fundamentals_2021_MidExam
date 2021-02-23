using System;
using System.Linq;
using System.Collections.Generic;

namespace MuOnline
{
    class Program
    {
        static void Main()
        {
            string[] dungeonsRooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int healthInitial = 100;
            int bitcoinsInitial = 0;

            for (int i = 0; i <= dungeonsRooms.Length-1; i++)
            {

                string[] room = dungeonsRooms[i]
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = room[0];
                int amount = int.Parse(room[1]);

                switch (command)
                {
                    case "potion":
                        int helthcurrent = healthInitial;
                        healthInitial += amount;
                        if (healthInitial>100)
                        {
                            int delta = 100 - helthcurrent;
                            healthInitial = 100;
                            
                            Console.WriteLine($"You healed for {delta} hp.");
                            Console.WriteLine($"Current health: {healthInitial} hp.");
                            continue;
                        }
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {healthInitial} hp.");
                        break;

                    case "chest":
                        bitcoinsInitial += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");
                        break;

                    default:
                        healthInitial -= amount;
                        if (healthInitial<=0)
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {i+1}");
                            return;
                        }

                        else
                        {
                            Console.WriteLine($"You slayed {command}.");
                        }
                        break;
                }

            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoinsInitial}");
            Console.WriteLine($"Health: {healthInitial}");
            
               


        }
    }
}
