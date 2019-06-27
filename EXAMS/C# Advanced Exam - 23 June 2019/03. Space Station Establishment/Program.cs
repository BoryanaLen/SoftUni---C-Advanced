using System;
using System.Collections.Generic;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] galaxy = new char[size][];

            int stephenRow = -1;
            int stephenCol = -1;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();

                galaxy[row] = input.ToCharArray();

                if (input.Contains("S"))
                {
                    stephenRow = row;

                    stephenCol = input.IndexOf("S");
                }
            }

            galaxy[stephenRow][stephenCol] = '-';

            int energy = 0;

            bool inVoid = false;

            bool maxEnergy = false;

            while (true)
            {
                string command = Console.ReadLine();

                List<int> newDimensions = MovePlayer(galaxy, stephenRow, stephenCol, command);

                if (IsInBorder(newDimensions, size))
                {
                    stephenRow = newDimensions[0];

                    stephenCol = newDimensions[1];

                    if (Char.IsDigit(galaxy[stephenRow][stephenCol]))
                    {
                        energy += galaxy[stephenRow][stephenCol] - '0';

                        galaxy[stephenRow][stephenCol] = '-';
                    }
                    else if(galaxy[stephenRow][stephenCol] == 'O')
                    {
                        galaxy[stephenRow][stephenCol] = '-';

                        for (int row = 0; row < size; row++)
                        {
                            for (int col = 0; col < size; col++)
                            {
                                if(galaxy[row][col] == 'O')
                                {
                                    stephenRow = row;
                                    stephenCol = col;
                                    galaxy[row][col] = '-';
                                }
                            }
                        }
                    }

                    if (energy >= 50)
                    {
                        maxEnergy = true;
                        galaxy[stephenRow][stephenCol] = 'S';
                        break;
                    }
                }
                else
                {
                    inVoid = true;
                    break;
                }
            }

            if (inVoid)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else if (maxEnergy)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {energy}");

            for (int row = 0; row < size; row++)
            {
                Console.WriteLine(string.Join("", galaxy[row]));
            }
        }

        public static bool IsInBorder(List<int>dimensions, int size)
        {
            bool result = false;

            int row = dimensions[0];
            int col = dimensions[1];

            if (row >= 0 && row < size && col >= 0 && col < size)
            {
                result = true;
            }

            return result;
        }

        public static List<int> MovePlayer(char[][] galaxy, int row, int col, string command)
        {
            if(command == "up")
            {
                row--;
            }
            else if(command == "down")
            {
                row++;
            }
            else if(command == "left")
            {
                col--;
            }
            else if(command == "right")
            {
                col++;
            }

            List<int> dimensions = new List<int>() { row, col };

            return dimensions;
        }
    }
}
