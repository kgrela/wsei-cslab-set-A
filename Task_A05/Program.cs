using System;

namespace Task_A05
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);

            if (a % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}
