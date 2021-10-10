using System;

namespace QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Quotient = 0; int Remainder = 0;
            Console.WriteLine("Enter the value Dividend");
            int Dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value Divisor");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            Quotient = Dividend / Divisor;
            Remainder= Dividend % Divisor;
            Console.WriteLine("The value of Quotient and Remainder is {0},{1}", Quotient, Remainder);
        }
    }
}
