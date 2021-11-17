using System;

namespace Task_A07
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Random rnd = new Random();

            while (i <= 1000)
            {
                Console.WriteLine(i + ". " + rnd.Next());
                i++;
            }
        }
    }
}
