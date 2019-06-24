using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());

            int[,] array = new int[numberRows, numberRows];

            int sumLeft = 0;

            int sumRight = 0;

            for (int row = 0; row < numberRows; row++)
            {
                List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int col = 0; col < numberRows; col++)
                {
                    array[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < numberRows; row++)
            {
                sumLeft += array[row, row];

                sumRight += array[row, numberRows - row - 1];
            }

            Console.WriteLine(Math.Abs(sumLeft-sumRight));
        }
    }
}
