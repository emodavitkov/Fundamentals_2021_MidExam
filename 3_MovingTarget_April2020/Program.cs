using System;
using System.Linq;
using System.Collections.Generic;

namespace _3_MovingTarget_April2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetSequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                        string input = Console.ReadLine();

            while (input?.ToUpper()!="END")
            {

                string[] commands = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                switch (commands[0])
                {
                    case "Shoot":
                        int indShoot = int.Parse(commands[1]);
                        int powerShoot = int.Parse(commands[2]);

                        if (indShoot < 0 || indShoot >= targetSequence.Count)
                        {
                            break;
                        }

                        targetSequence[indShoot] -= powerShoot;

                        if (targetSequence[indShoot]<=0)
                        {
                            targetSequence.RemoveAt(indShoot);
                        }
                        break;

                    case "Add":
                        int indAdd = int.Parse(commands[1]);
                        int powerAdd = int.Parse(commands[2]);

                        if (indAdd < 0 || indAdd >= targetSequence.Count)
                        {
                            Console.WriteLine("Invalid placement!");
                            break;
                        }

                        targetSequence.Insert(indAdd, powerAdd);

                        break;

                    case "Strike":
                        int indStrike = int.Parse(commands[1]);
                        int radiusStrike = int.Parse(commands[2]);

                        int indStrikeRangeStart = indStrike - radiusStrike;
                        int indStrikeRangeStop = indStrike + radiusStrike;

                        if (indStrikeRangeStart<0||indStrikeRangeStop>targetSequence.Count-1)
                        {
                            Console.WriteLine("Strike missed!");
                            break;
                        }

                        targetSequence.RemoveRange(indStrike-radiusStrike,((2*radiusStrike)+1));
                        
                        break;

                    default:
                        break;
                }



                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|",targetSequence));

           
        }
    }
}
