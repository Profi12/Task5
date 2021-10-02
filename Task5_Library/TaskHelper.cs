using System;

namespace Task5_Library
{
    public class TaskHelper
    {
        public static int Min(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            (int i, int j) = MinIndex(array);

            return array[i, j];
        }

        public static int Max(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException();
            }
            (int i, int j) = MaxIndex(array);

            return array[i, j];
        }

        public static (int i, int j) MinIndex(int[,] array)
        {
            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minI, minJ] > array[i, j])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            return (minI, minJ);
        }

        public static (int i, int j) MaxIndex(int[,] array)
        {
            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxI, maxJ] < array[i, j])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            return (maxI, maxJ);
        }

        public static int GetNeighboursCounter(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    count += IsMoreThanNeighbours(array, i, j) ? 1 : 0;
                }
            }

            return count;
        }

        public static void TransponateMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = i + 1; j < array.GetLength(1); ++j)
                {
                    if(j < array.GetLength(0) && i < array.GetLength(1))
                    {
                        Swap(ref array[i, j], ref array[j, i]);
                    }
                }
            }
        }

        private static bool IsMoreThanNeighbours(int[,] array, int i, int j)
        {
            bool moreThanNeighbours = true;
            if ((i - 1) >= 0)
            {
                if (array[i, j] <= array[i - 1, j])
                {
                    moreThanNeighbours = false;
                }
            }
            if ((i + 1) < array.GetLength(0))
            {
                if (array[i, j] <= array[i + 1, j])
                {
                    moreThanNeighbours = false;
                }
            }
            if ((j - 1) >= 0)
            {
                if(array[i, j] <= array[i, j - 1])
                {
                    moreThanNeighbours = false;
                }
            }
            if ((j + 1) < array.GetLength(1))
            {
                if (array[i, j] <= array[i, j + 1])
                {
                    moreThanNeighbours = false;
                }
            }

            return moreThanNeighbours;
        }

        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}