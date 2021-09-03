using System;
using Task5_Library;

namespace Task5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 9);
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            TaskHelper.TransponateMatrix(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}