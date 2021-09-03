using System;
using Task5_Library;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 4];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 100);
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            
            Console.WriteLine(TaskHelper.Min(array));
        }
    }
}