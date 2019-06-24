using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int numberRows = dimensions[0];

            int numberCols = dimensions[1];

            string snake = Console.ReadLine();

            char[,] array = new char[numberRows, numberCols];

            int currentIndex = 0;

            for (int row = 0; row <numberRows; row++)
            {
                for (int col = 0; col < numberCols; col++)
                {
                    array[row, col] = snake[currentIndex];

                    currentIndex++;

                    if (currentIndex > snake.Length - 1)
                    {
                        currentIndex -= snake.Length;
                    }
                }
            }

            for (int row = 0; row < numberRows; row++)
            {
                for (int col = 0; col < numberCols; col++)
                {
                    Console.Write($"{array[row, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
