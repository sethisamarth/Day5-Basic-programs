using System;

namespace VowelOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a alphabet to check its vowel or not");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("its a Vowel");
            }
            else
            {
                Console.WriteLine("its a Consonant");
            }
        }
    }
}
