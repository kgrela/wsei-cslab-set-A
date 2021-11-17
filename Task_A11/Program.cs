using System;

namespace Task_A11
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            char[] tab = new char[n];
            
            for(int i=0; i<n; i++)
            {
                Console.Write("Enter a character with index " + i + ": ");
                char.TryParse(Console.ReadLine(), out tab[i]);
            }

            foreach(char x in tab)
            {
                Console.Write(x + " ");
            }
        }
    }
}
