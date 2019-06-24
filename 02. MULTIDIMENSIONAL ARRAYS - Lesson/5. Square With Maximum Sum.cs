using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int[,] array = new int[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                List<int> rowContent = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[rows, col] = rowContent[col];
                }
            }

            int maxSum = int.MinValue;

            int[] maxArrayRow = new int[2];

            int[] maxArrayCol= new int[2];

            for (int rows = 0; rows < array.GetLength(0) - 1; rows++)
            {
                for (int col = 0; col < array.GetLength(1) -1 ; col++)
                {
                    int currentSum = array[rows, col] + array[rows, col + 1] + array[rows + 1, col] + array[rows + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxArrayRow[0] = array[rows, col];

                        maxArrayRow[1] = array[rows, col + 1];

                        maxArrayCol[0] = array[rows + 1, col];

                        maxArrayCol[1] = array[rows + 1, col + 1];

                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', maxArrayRow));

            Console.WriteLine(string.Join(' ', maxArrayCol));

            Console.WriteLine(maxSum);
        }
    }
}
