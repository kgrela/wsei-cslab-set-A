using System;

namespace Task_A06
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);

            for (int i = 1; i <= a; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
