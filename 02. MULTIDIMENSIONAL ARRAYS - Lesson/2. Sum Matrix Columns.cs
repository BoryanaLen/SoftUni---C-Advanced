using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int[,] array = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                List<int>rowContent = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = rowContent[col];
                }
            }

            for (int col = 0; col < array.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < array.GetLength(0); row++)
                {
                    sum += array[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
