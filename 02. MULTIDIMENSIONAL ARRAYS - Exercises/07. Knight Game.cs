using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());

            char[,] array = new char[boardSize, boardSize];

            for (int row = 0; row <boardSize; row++)
            {
                string inputRow = Console.ReadLine();

                for (int col = 0; col < boardSize; col++)
                {
                    array[row, col] = inputRow[col];
                }
            }

            int minimumCount = 0;

            int maxAttack = 0;
            int maxCol = -1;
            int maxRow = -1;

            while (true)
            {
                for (int row = 0; row < boardSize; row++)
                {
                    for (int col = 0; col < boardSize; col++)
                    {
                        int currentAttack = 0;

                        if (array[row, col] == 'K')
                        {
                            if (IsOnBoard(row - 1, col - 2, boardSize))
                            {
                                if (array[row - 1, col - 2] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                            if (IsOnBoard(row - 1, col + 2, boardSize))
                            {
                                if (array[row - 1, col + 2] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                            if (IsOnBoard(row - 2, col + 1, boardSize))
                            {
                                if (array[row - 2, col + 1] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                            if (IsOnBoard(row - 2, col - 1, boardSize))
                            {
                                if (array[row - 2, col - 1] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                            if (IsOnBoard(row + 1, col - 2, boardSize))
                            {
                                if (array[row + 1, col - 2] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                            if (IsOnBoard(row + 1, col + 2, boardSize))
                            {
                                if (array[row + 1, col + 2] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                            if (IsOnBoard(row + 2, col + 1, boardSize))
                            {
                                if (array[row + 2, col + 1] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                            if (IsOnBoard(row + 2, col - 1, boardSize))
                            {
                                if (array[row + 2, col - 1] == 'K')
                                {
                                    currentAttack++;
                                }
                            }
                        }

                        if (currentAttack > maxAttack)
                        {
                            maxRow = row;
                            maxCol = col;
                            maxAttack = currentAttack;
                        }
                    }
                }

                if (maxAttack == 0)
                {
                    break;
                }
                else
                {
                    array[maxRow, maxCol] = '0';
                    minimumCount++;
                    maxAttack = 0;
                }
            }

            Console.WriteLine(minimumCount);
        }

        private static bool IsOnBoard(int row, int column, int n)
        {
            bool result = false;

            if(row >= 0 && row < n && column >= 0 && column < n)
            {
                result = true;
            }

            return result;
        }
    }
}
