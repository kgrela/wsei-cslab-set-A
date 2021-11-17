using System;

namespace Task_A02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;

            Console.WriteLine("Enter string A: ");
            a = Console.ReadLine();

            Console.WriteLine("Enter string B: ");
            b = Console.ReadLine();

            string c = a + b;
            Console.WriteLine("Merged string C: " + c);
        }
    }
}
