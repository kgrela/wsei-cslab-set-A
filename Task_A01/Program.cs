using System;

namespace Task_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] randoms = new int[6];

            for(int i=0;i<randoms.Length;i++)
            {
                randoms[i] = rnd.Next(1, 49);
                Console.WriteLine("Random number "+i+" = "+randoms[i]);
            }


        }
    }
}
