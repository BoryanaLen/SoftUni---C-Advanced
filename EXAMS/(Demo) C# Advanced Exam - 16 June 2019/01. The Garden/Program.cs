using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());

            string[][] garden = new string[numberRows][];

            int countOfCarrots = 0;
            int countOfPotatos = 0;
            int countOfLettuces = 0;
            int count = 0;


            for (int row = 0; row < numberRows; row++)
            {
                garden[row] = Console.ReadLine()
                    .Split()
                    .ToArray();
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of Harvest")
                {
                    break;
                }

                List<string> inputInfo = input
                    .Split()
                    .ToList();

                string command = inputInfo[0];
                int row = int.Parse(inputInfo[1]);
                int col = int.Parse(inputInfo[2]);

                if (command == "Harvest")
                {
                    if (CheckIfExists(row, col, garden, numberRows))
                    {
                        if (CheckIfVegetable(row, col, garden))
                        {
                            if (garden[row][col] == "L")
                            {
                                garden[row][col] = " ";
                                countOfLettuces++;
                            }
                            else if (garden[row][col] == "P")
                            {
                                garden[row][col] = " ";
                                countOfPotatos++;
                            }
                            else if (garden[row][col] == "C")
                            {
                                garden[row][col] = " ";
                                countOfCarrots++;
                            }
                        }
                    }
                }
                else if (command == "Mole")
                {
                    string direction = inputInfo[3];

                    count += MoveMole(row, col, garden, numberRows, direction);
                }
            }


            for (int rowToPrint = 0; rowToPrint < numberRows; rowToPrint++)
            {
                Console.WriteLine(string.Join(' ', garden[rowToPrint]));
            }

            Console.WriteLine($"Carrots: {countOfCarrots}");
            Console.WriteLine($"Potatoes: {countOfPotatos}");
            Console.WriteLine($"Lettuce: {countOfLettuces}");
            Console.WriteLine($"Harmed vegetables: {count}");
        }

        public static bool CheckIfExists(int row, int col, string[][] matrix, int numberRows)
        {
            bool result = false;

            if (row >= 0 && row < numberRows)
            {
                if (col >= 0 && col < matrix[row].Count())
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool CheckIfVegetable(int row, int col, string[][] matrix)
        {
            bool result = false;

            if (matrix[row][col] == "P" || matrix[row][col] == "C" || matrix[row][col] == "L")
            {
                result = true;
            }

            return result;
        }

        public static int MoveMole(int row, int col, string[][] matrix, int numberRows, string direction)
        {
            int count = 0;

            if (CheckIfExists(row, col, matrix, numberRows))
            {
                if (direction == "up")
                {
                    for (int i = row; i >= 0; i -= 2)
                    {
                        if (col >= 0 && col < matrix[row].Count())
                        {
                            if (CheckIfVegetable(i, col, matrix))
                            {
                                matrix[i][col] = " ";
                                count++;
                            }
                        }
                    }
                }
                else if (direction == "down")
                {
                    for (int i = row; i < numberRows; i += 2)
                    {
                        if (col >= 0 && col < matrix[row].Count())
                        {
                            if (CheckIfVegetable(i, col, matrix))
                            {
                                matrix[i][col] = " ";
                                count++;
                            }
                        }
                    }
                }
                else if (direction == "left")
                {
                    for (int i = col; i >= 0; i -= 2)
                    {
                        if (CheckIfVegetable(row, i, matrix))
                        {
                            matrix[row][i] = " ";
                            count++;
                        }
                    }
                }
                else if (direction == "right")
                {
                    for (int i = col; i < matrix[row].Count(); i += 2)
                    {
                        if (CheckIfVegetable(row, i, matrix))
                        {
                            matrix[row][i] = " ";
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
