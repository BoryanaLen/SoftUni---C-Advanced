using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int numberRols = dimensions[0];

            int numberCols = dimensions[1];

            char[,] array = new char[numberRols, numberCols];

            for (int row = 0; row < numberRols; row++)
            {
                List<char> symbols = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToList();

                for (int col = 0; col < numberCols; col++)
                {
                    array[row, col] = symbols[col];
                }
            }

            int countEqualMatrix = 0;

            for (int row = 0; row < numberRols - 1; row++)
            {
                for (int col = 0; col < numberCols - 1; col++)
                {
                   if(array[row,col] == array[row,col+1] && array[row, col] == array[row + 1, col] 
                        && array[row, col] == array[row + 1, col + 1])
                    {
                        countEqualMatrix++;
                    }
                }
            }

            Console.WriteLine(countEqualMatrix);
        }
    }
}
