using System;

namespace Task_A12
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the length of array from user

            Console.WriteLine("Enter the length of array: ");
            int.TryParse(Console.ReadLine(), out int n);

            // create array

            double[,] tab = new double[n,n];

            // get the values from user

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.WriteLine("Enter the value of index [" + i + "][" + j + "]: ");
                    double.TryParse(Console.ReadLine(), out tab[i, j]);
                }
            }

            // print the array

            Console.WriteLine("Array values: ");
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.Write(tab[i,j]+" ");
                }
            }

            // count the product and print the array

            Console.WriteLine("Products: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(tab[i, j]*tab[i,j] + " ");
                }
            }

        }
    }
}
