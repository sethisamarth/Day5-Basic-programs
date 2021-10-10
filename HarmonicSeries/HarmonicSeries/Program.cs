using System;

namespace HarmonicSeries
{
    // sum of 1/1 + 1/2......1/n
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            double i = 1; double sum = 0;
            for (i = 1; i <= n; i++)
            {
                 sum += 1 / i; 
            }

            Console.WriteLine("the sum of the series is :"+sum);
        }
    }
}
