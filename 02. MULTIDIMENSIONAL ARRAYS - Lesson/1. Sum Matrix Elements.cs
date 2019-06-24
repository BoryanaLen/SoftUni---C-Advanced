using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int rowsCount = dimensions[0];

            int columnsCount = dimensions[1];

            int[,] array = new int[rowsCount, columnsCount];

            int sum = 0;

            for (int rows = 0; rows <array.GetLength(0); rows++)
            {
                List<int> rowContent = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

                sum += rowContent.Sum();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[rows, col] = rowContent[col];
                }
            }

            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
