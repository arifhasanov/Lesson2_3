using System;

namespace Lesson2_3
{
    class Program
    {
        [Flags]
        enum Weekdays : byte
        {
            Monday = 0b_00000001,
            Tuesday = 0b_00000010,
            Wednesday = 0b_00000100,
            Thursday = 0b_00001000,
            Friday = 0b_00010000,
            Saturday = 0b_00100000,
            Sunday = 0b_01000000
        }

        static void Main(string[] args)
        {
            var office1 = Weekdays.Tuesday | Weekdays.Wednesday | Weekdays.Thursday | Weekdays.Friday;
            var office2 = Weekdays.Monday | Weekdays.Tuesday | Weekdays.Wednesday | Weekdays.Thursday | Weekdays.Friday | Weekdays.Saturday | Weekdays.Sunday;

            foreach (Weekdays wd in Enum.GetValues(typeof(Weekdays)))
            {
                bool isWorkingOrNot = (office1 & wd) == wd;
                Console.WriteLine($"Office 1 working on {wd}: {isWorkingOrNot}");
            }

            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine();

            foreach (Weekdays wd in Enum.GetValues(typeof(Weekdays)))
            {
                bool isWorkingOrNot = (office2 & wd) == wd;
                Console.WriteLine($"Office 2 working on {wd}: {isWorkingOrNot}");
            }
        }
    }
}
