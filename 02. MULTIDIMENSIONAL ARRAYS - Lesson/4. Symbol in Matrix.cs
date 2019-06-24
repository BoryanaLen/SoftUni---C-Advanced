using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] array = new char[size, size];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                string rowContent = Console.ReadLine();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = rowContent[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            bool exist = false;


            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if(array[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");

                        exist = true;

                        break;
                    }
                }

                if(exist == true)
                {
                    break;
                }
            }

            if(exist == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
