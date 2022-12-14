using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] InitArray(int m, int n)
            {
                double[,] array = new double[m, n];
                Random rnd = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = Math.Round(rnd.NextDouble() * ((5.0 - (-10.0)) + (-10.0)), 2);
                    }
                }
                return array;
            }
            void PrintArray(double[,] array, int m, int n)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            int m = 3;
            int n = 4;
            PrintArray(InitArray(m, n), m, n);
        }
    }
}
