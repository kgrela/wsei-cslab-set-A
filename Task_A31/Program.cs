using System;

namespace Task_A31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of an array: ");
            int.TryParse(Console.ReadLine(), out int n);

            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the value of index [" + i + "] = ");
                int.TryParse(Console.ReadLine(), out tab[i]);
            }

            Array.Sort(tab);

            for(int i = 0; i<tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }

        }
    }
}
