using System;

namespace FlipCoin
{
    class Classtest
    {
        public static double Percentage(int x, int y)
        {
            double per = (x / (x + y)) * 100;
            return per;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; int totalHead = 0; int totalTail = 0; 
           const int head=1; double percentageHead = 0; double percentageTail = 0;

            Console.WriteLine("Enter value of n ,The number of times to Flip Coin.");
            int n = Convert.ToInt16(Console.ReadLine());
            Random r = new Random();

            for (i = 1; i <= n; i++)
            {
                int flipcoin = r.Next(1, 3);
                switch (flipcoin)
                {
                    case 1:
                        totalHead++;
                        break;
                    case 2:
                        totalTail++;
                        break;
                }
            }
            Console.WriteLine("the total no. of heads are :{0}", totalHead);
            Console.WriteLine("the total no. of tails are :{0}", totalTail);
            Classtest c = new Classtest();
            double v = c.Percentage(totalHead, totalTail);
        }
    }
}
