using System;

namespace OddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if its even or odd");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("its a even number");
            }
            else
            {
                Console.WriteLine("its not  even number");

            }
        }
    }
}
