using System;

namespace SwappingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            Console.WriteLine("Enter the integer values of number1 and number2");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            
            temp = number1; 
            number1 = number2;      
            number2 = temp; 
            Console.WriteLine("The respective values of number1 is {0},number2 is {1},temp is {2}", number1, number2, temp);
        }
    }
}
