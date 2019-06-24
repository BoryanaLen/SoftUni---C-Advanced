using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int [,] array = new int[size, size];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                List<int> rowContent = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = rowContent[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                sum += array[row, row];
            }

            Console.WriteLine(sum);
        }
    }
}
