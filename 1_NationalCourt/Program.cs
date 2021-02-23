using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
        int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
        int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
        int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());

        int peopleCount = int.Parse(Console.ReadLine());

            if (peopleCount==0)
            {
                Console.WriteLine($"Time needed: 0h.");
                return;
            }

        int peoplePerHourAllThree = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

        int hours = 0;

            while (peopleCount>0)
            {

                peopleCount -= peoplePerHourAllThree;
                hours++;

                if (hours%4==0)
                {
                    hours++;
                }
            }
        
            Console.WriteLine($"Time needed: {hours}h.");


        }
    }
}
