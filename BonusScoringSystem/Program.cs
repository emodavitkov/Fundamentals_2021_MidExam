using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double bonus = 0;
            double bonusMax = 0;
            int studenAttendanceBonusMax = 0;
            for (int i = 1; i <= countStudents; i++)
            {
                int attendanceStudent = int.Parse(Console.ReadLine());

                //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
                bonus = (attendanceStudent / (double)countLectures) * (5 + (double)initialBonus);

                if (bonus > bonusMax)
                {
                bonusMax = bonus;
                studenAttendanceBonusMax = attendanceStudent;

                }
            bonus = 0;
            }

            
            Console.WriteLine($"Max Bonus: {Math.Ceiling(bonusMax)}.");
            Console.WriteLine($"The student has attended {studenAttendanceBonusMax} lectures.");


        }
    }
}
