using System;

namespace CounterStrike_April2020exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps track of every won battle against an enemy.You will receive initial energy.
            //input
            //•	On the first line you will receive initial energy – an integer[1 - 10000].

            //Afterwards you will start receiving the distance you need to go to reach an enemy until the "End of battle" command is given, or until you run out of energy.
            //•	On the next lines, you will be receiving distance of the enemy – an integer[1 - 10000]

            int initCurrentEnergy = int.Parse(Console.ReadLine());
            int countWin = 0;
            int distanceEnemy = 0;
            bool noEnergy = false;

            while (true)
            {
                string input = Console.ReadLine();
               
                if (input=="End of battle")
                {
                    noEnergy = true;
                    break;
                }

                distanceEnemy = int.Parse(input);

                if (distanceEnemy>initCurrentEnergy)
                {
                    break;
                }

                initCurrentEnergy -= distanceEnemy;
                countWin++;

                if (countWin%3==0)
                {

                    initCurrentEnergy += countWin;

                }
                

            }
            if (!noEnergy)
            {
                Console.WriteLine($"Not enough energy! Game ends with {countWin} won battles and {initCurrentEnergy} energy");
            }

            else
            {
                Console.WriteLine($"Won battles: {countWin}. Energy left: {initCurrentEnergy}");
            }
            


            
            
            //The energy you need for reaching an enemy is equal to the distance you receive.Each time you reach an enemy, your energy is reduced.
            //This is considered a successful battle(win).If you don't have enough energy to reach an the enemy, print:
            //"Not enough energy! Game ends with {count} won battles and {energy} energy"
            //and end the program.

            //Every third won battle increases your energy with the value of your current count of won battles.

            //Upon receiving the "End of battle" command, print the count of won battles in the following format:
            //"Won battles: {count}. Energy left: {energy}"



            //output
            //•	The description contains the proper output messages for each case and the format in which they should be print.

        }
    }
}
