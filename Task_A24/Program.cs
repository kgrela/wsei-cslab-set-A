using System;

namespace Task_A24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[2];
            fib[0] = 1;
            fib[1] = 1;

            Console.WriteLine("How many fibbonacci elements should I print? ");
            int.TryParse(Console.ReadLine(), out int n);

            int tmp;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    tmp = fib[0] + fib[1];
                    Console.WriteLine(tmp);

                    fib[0] = fib[1];
                    fib[1] = tmp;
                }
            }

        }
    }
}
