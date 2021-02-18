using System;
using System.Linq;
using System.Collections.Generic;

namespace _2_ShootforTheWin_April2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targetSequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotTargets = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                int index = int.Parse(input);

                if (index>targetSequence.Length-1)
                {
                    continue;
                }

                int shotTarget = targetSequence[index];
                targetSequence[index] = -1;

                for (int i = 0; i <= targetSequence.Length - 1; i++)
                {
                    if (targetSequence[i] == -1)
                    {
                        continue;
                    }

                    if (shotTarget < targetSequence[i])
                    {
                        targetSequence[i] -= shotTarget;
                    }

                    else if (shotTarget >= targetSequence[i])
                    {
                        targetSequence[i] += shotTarget;
                    }



                }
                shotTargets++;


            }

            Console.Write($"Shot targets: {shotTargets} -> ");
            foreach (var item in targetSequence)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
