using System;

namespace Leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year in YYYY format");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Its a leap year");
            }
            else
            {
                Console.WriteLine("its not leap year");
            }

        }
    }
}
