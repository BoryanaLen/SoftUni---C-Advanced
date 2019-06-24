using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int numberRows = dimensions[0];

            int numberColumns = dimensions[1];

            int[,] array = new int[numberRows, numberColumns];

            int[,] finalArray = new int[numberRows, numberColumns];

            List<int> bombParameters = Console.ReadLine().Split().Select(int.Parse).ToList();

            int targetRow = bombParameters[0];

            int targetColumn = bombParameters[1];

            int radius = bombParameters[2];

            for (int row = 0; row < numberRows; row++)
            {
                for (int col = 0; col < numberColumns; col++)
                {
                    array[row, col] = 0;
                }
            }

            for (int row = 0; row < numberRows; row++)
            {
                for (int col = 0; col < numberColumns; col++)
                {
                    if((Math.Pow(row - targetRow, 2) + Math.Pow(col - targetColumn, 2)) <= Math.Pow(radius,2))
                    {
                        array[row, col] = 1;
                    }
                }
            }

            int count = 0;

            int startRow = targetRow;

            for (int row = 0; row < numberRows; row++)
            {
                if (row > radius + radius)
                {
                    for (int col = 0; col < numberColumns; col++)
                    {
                        finalArray[row, col] = 0;
                    }
                }
                else
                {
                    if (targetRow >= numberRows / 2)
                    {
                        for (int col = 0; col < numberColumns; col++)
                        {
                            finalArray[row, col] = array[startRow, col];
                        }

                        count++;

                        if (count % 2 != 0)
                        {
                            startRow--;
                        }
                    }
                    else
                    {
                        for (int col = 0; col < numberColumns; col++)
                        {
                            finalArray[row, col] = array[startRow, col];
                        }

                        count++;

                        if (count % 2 != 0)
                        {
                            startRow++;
                        }
                    }
                   
                }
            }

            for (int row = 0; row < numberRows; row++)
            {
                for (int col = 0; col < numberColumns; col++)
                {
                    Console.Write(finalArray[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
