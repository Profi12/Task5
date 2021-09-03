namespace Task5_Library
{
    public class TaskHelper
    {
        public static int Min(int[,] array)
        {
            (int i, int j) = MinIndex(array);

            return array[i, j];
        }

        public static int Max(int[,] array)
        {
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

    }
}