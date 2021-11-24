using System;

namespace Task_A32
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int n);

            string dec = "";

            for(int i = 0; n >= 1; i++)
            {
                dec = dec + (n % 2);
                n = n / 2;
            }

            char[] decArray = new char[dec.Length];
            decArray = dec.ToCharArray();

            Array.Reverse(decArray);

            for(int i=0; i<decArray.Length; i++)
            {
                Console.Write(decArray[i]);
            }


        }
    }
}
