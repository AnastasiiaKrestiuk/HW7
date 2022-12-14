using System;
//В задаче сказано, что на вход нужно примнимать позиции и возвращать значение. В примере наоборот, на вход принято значение.
namespace Task2
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
            int GetNumbers(string massage)
            {
                int result = 0;
                bool isCorrect = false;

                while (!isCorrect)
                {
                    Console.WriteLine(massage);
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число. Введите число.");
                    }
                }

                return result;
            }
            string FindValue(int[,] array, int m, int n)
            {
                int rows = array.GetUpperBound(0) + 1;       // количество строк
                int columns = array.Length / rows;           // количество столбцов
                string massage = "Такой позиции в массиве нет";
                if (m < rows && n < columns)
                {
                    massage = $"{array[m, n]}";
                }
                return massage;
            }
            string FindPosition(int[,] array, int value)
            {
                int m = array.GetUpperBound(0) + 1;    // количество строк
                int n = array.Length / m;              // количество столбцов
                string massage = "Такого числа в массиве нет";
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if(array[i, j] == value)
                        {
                            massage = $"[{i}, {j}]";
                        }
                    }
                }
                return massage;
            }
            int m = 3;
            int n = 4;
            int[,] array = InitArray(m, n);
            int rowNumber = GetNumbers($"Введите номер строки от 0 до {m}:");
            int columnNumber = GetNumbers($"Введите номер столбца от 0 до {n}:");
            Console.WriteLine(FindValue(array, rowNumber, columnNumber));

            int value = GetNumbers("Введите значение:");
            Console.WriteLine(FindPosition(array, value));
        }
    }
}
