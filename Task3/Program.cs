using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] InitArray(int m, int n)
            {
                int[,] array = new int[m, n];
                Random rnd = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = rnd.Next(-10, 11);
                    }
                }
                return array;
            }
            string Average(int[,] array)
            {
                int rows = array.GetUpperBound(0) + 1;       // количество строк
                int columns = array.Length / rows;           // количество столбцов
                string result = null;
                for (int i = 0; i < rows; i++)
                {
                    double average = 0;
                    for (int j = 0; j < columns; j++)
                    {
                        average += (double)array[i, j];
                    }
                    average = Math.Round((average / rows), 1);
                    result += $"{average} ";
                }
                return result;
            }
            int m = 3;
            int n = 4;
            int[,] array = InitArray(m, n);
            Console.WriteLine(Average(array));

        }
    }
}
