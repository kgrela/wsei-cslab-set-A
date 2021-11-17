using System;

namespace Task_A08
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            double[] tab = new double[5];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(1, 100);
                Console.Write(tab[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] / 2 + " ");
            }
        }
    }
}
