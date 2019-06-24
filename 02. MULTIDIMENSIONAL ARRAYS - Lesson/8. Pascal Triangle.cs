using System;

namespace _8._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());

            long[][] array = new long[numberRows][];

            for (int row = 0; row < numberRows; row++)
            {
                array[row] = new long[row + 1];

                if(row == 0)
                {
                    array[row][0] = 1;
                }
                else if (row == 1)
                {
                    array[row][0] = 1;

                    array[row][1] = 1;
                }
                else
                {
                    array[row][0] = 1;

                    array[row][row] = 1;

                    for (int col = 1; col < row; col++)
                    {
                        array[row][col] = array[row - 1][col-1] + array[row - 1][col];
                    }
                }
            }

            foreach(var item in array)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
