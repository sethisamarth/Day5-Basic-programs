using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, power = 1;
            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i=1; i<=n; i++)
            {
                if (i == 1)
                {
                    power = 1;
                }
                else
                {
                    power = power * 2;
                }
                    Console.WriteLine(power);
            }
        }
    }
}
