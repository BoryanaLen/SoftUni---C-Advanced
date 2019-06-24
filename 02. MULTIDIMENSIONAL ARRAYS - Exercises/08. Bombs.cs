using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] array = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                List<int> inputRow = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int col = 0; col < size; col++)
                {
                    array[row, col] = inputRow[col];
                }
            }

            List<string> bombs = Console.ReadLine().Split().ToList();

            for (int i = 0; i < bombs.Count; i++)
            {
                List<int> dimensions = bombs[i].Split(',').Select(int.Parse).ToList();

                int bombRow = dimensions[0];

                int bombCol = dimensions[1];

                if (bombRow >= 0 && bombRow < size && bombCol >= 0 && bombCol < size)
                {
                    if (array[bombRow, bombCol] > 0)
                    {
                        if (IsInBorder(bombRow - 1, bombCol - 1, size))
                        {
                            if(IsPositiveNumber(bombRow - 1, bombCol - 1, array))
                            {
                                array[bombRow - 1, bombCol - 1] -= array[bombRow, bombCol];
                            }
                        }
                        if (IsInBorder(bombRow - 1, bombCol, size))
                        {
                            if (IsPositiveNumber(bombRow - 1, bombCol, array))
                            {
                                array[bombRow - 1, bombCol] -= array[bombRow, bombCol];
                            }
                        }
                        if (IsInBorder(bombRow - 1, bombCol + 1, size))
                        {
                            if (IsPositiveNumber(bombRow - 1, bombCol + 1, array))
                            {
                                array[bombRow - 1, bombCol + 1] -= array[bombRow, bombCol];
                            }
                        }
                        if (IsInBorder(bombRow, bombCol - 1, size))
                        {
                            if (IsPositiveNumber(bombRow, bombCol - 1, array))
                            {
                                array[bombRow, bombCol - 1] -= array[bombRow, bombCol];
                            }
                        }
                        if (IsInBorder(bombRow, bombCol + 1, size))
                        {
                            if (IsPositiveNumber(bombRow, bombCol + 1, array))
                            {
                                array[bombRow, bombCol + 1] -= array[bombRow, bombCol];
                            }
                        }
                        if (IsInBorder(bombRow + 1, bombCol - 1, size))
                        {
                            if (IsPositiveNumber(bombRow + 1, bombCol - 1, array))
                            {
                                array[bombRow + 1, bombCol - 1] -= array[bombRow, bombCol];
                            }
                        }
                        if (IsInBorder(bombRow + 1, bombCol, size))
                        {
                            if (IsPositiveNumber(bombRow + 1, bombCol, array))
                            {
                                array[bombRow + 1, bombCol] -= array[bombRow, bombCol];
                            }
                        }
                        if (IsInBorder(bombRow + 1, bombCol + 1, size))
                        {
                            if (IsPositiveNumber(bombRow + 1, bombCol + 1, array))
                            {
                                array[bombRow + 1, bombCol + 1] -= array[bombRow, bombCol];
                            }
                        }

                        array[bombRow, bombCol] = 0;
                    }
                }
            }

            int countAlivecells = 0;

            int sumAlivecells = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (array[row, col] > 0)
                    {
                        countAlivecells++;
                        sumAlivecells += array[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {countAlivecells}");

            Console.WriteLine($"Sum: {sumAlivecells}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{array[row, col]} ");
                }

                Console.WriteLine();
            }

        }

        public static bool IsInBorder(int row, int col, int size)
        {
            bool result = false;

            if (row >= 0 && row < size && col >= 0 && col < size)
            {
                result = true;
            }

            return result;
        }

        public static bool IsPositiveNumber (int row, int col, int [,] array)
        {
            bool result = false;

            if (array[row,col]>0)
            {
                result = true;
            }

            return result;
        }
    }
}
