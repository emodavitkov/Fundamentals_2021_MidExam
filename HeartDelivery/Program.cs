using System;
using System.Linq;
using System.Collections.Generic;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> neigh = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int jumpStartIdx = 0;
            int jumpCurrentIdx = 0;
            int countValentines = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input?.ToUpper()=="LOVE!")
                {
                    break;
                }

                string[] jumpCommand = input.Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int jumpLenght = int.Parse(jumpCommand[1]);

                jumpCurrentIdx = jumpStartIdx + jumpLenght;

                if (jumpCurrentIdx>(neigh.Count-1))
                {
                    jumpCurrentIdx = 0;
                }

                if (neigh[jumpCurrentIdx]==0)
                {
                    Console.WriteLine($"Place {jumpCurrentIdx} already had Valentine's day.");
                    jumpStartIdx = jumpCurrentIdx;
                    continue;
                }
                
                    int houseHeartsValueNew = neigh[jumpCurrentIdx] - 2;
                    neigh.Insert(jumpCurrentIdx, houseHeartsValueNew);
                    neigh.RemoveAt(jumpCurrentIdx + 1);

                if (neigh[jumpCurrentIdx]==0)
                {
                    Console.WriteLine($"Place {jumpCurrentIdx} has Valentine's day.");
                    countValentines++;

                }

               
                jumpStartIdx = jumpCurrentIdx;
            }

            Console.WriteLine($"Cupid's last position was {jumpCurrentIdx}.");

            if (neigh.Sum()==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            //How many count of 0 we have e.g. 4 out of 4
            //int successfullCount = neigh.Count(x => x == 0);
            //int failCount = neigh.Count(x => x > 0);
            if (countValentines<neigh.Count)
            {

                Console.WriteLine($"Cupid has failed {(neigh.Count) -countValentines} places.");
            }

            }
        }
    }
