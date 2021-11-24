using System;

namespace Task_A22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;

            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int n);

            for(int i=2; i<n; i++)
            {
                if(n%i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime);
        }
    }
}
