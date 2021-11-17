using System;

namespace Task_A04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Square = " + a * a);
            Console.WriteLine("Cube = " + a * a * a);
            Console.WriteLine("Square root = " + Math.Sqrt(a));
        }
    }
}
