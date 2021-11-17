using System;

namespace Task_A03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string tmp;

            tmp = Console.ReadLine();
            double.TryParse(tmp, out a);

            tmp = Console.ReadLine();
            double.TryParse(tmp, out b);

            double sum, diff, pro, quot;

            sum = a + b;
            if (a > b) diff = a - b;
            else diff = b - a;
            pro = a * b;
            if (b != 0) quot = a / b;
            else quot = 0;

            Console.WriteLine("Sum = " + sum + ", difference = " + diff + ", product = " + pro + ", quotient = " + quot);
        }
    }
}
