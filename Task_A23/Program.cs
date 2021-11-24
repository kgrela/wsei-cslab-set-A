using System;

namespace Task_A23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int n);

            string tmp = "";
            n *= 2;

            while (n > 10)
            {
                tmp = tmp + (n % 10);
                n = n / 10;
            }

            tmp = tmp + n;

            char[] tab = tmp.ToCharArray();
            Array.Reverse(tab);

            for(int i = 0; i<tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
