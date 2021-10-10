using System;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            for (i = 2; i < n * n; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        Console.WriteLine(i);
                        n = n / i;
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
