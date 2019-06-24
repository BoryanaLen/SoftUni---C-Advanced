using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int[][] array = new int[3][];

            array[0] = new int[numbers.Count];

            array[1] = new int[numbers.Count];

            array[2] = new int[numbers.Count];

            int countOne = 0;

            int countTwo = 0;

            int countThree = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i]) % 3 == 0)
                {
                    array[0][countOne] = numbers[i];

                    countOne++;
                }
                else if (Math.Abs(numbers[i]) % 3 == 1)
                {
                    array[1][countTwo] = numbers[i];

                    countTwo++;
                }
                else if (Math.Abs(numbers[i]) % 3 == 2)
                {
                    array[2][countThree] = numbers[i];

                    countThree++;
                }
            }



            Console.WriteLine(string.Join(' ', array[0].Take(countOne)));

            Console.WriteLine(string.Join(' ', array[1].Take(countTwo)));

            Console.WriteLine(string.Join(' ', array[2].Take(countThree)));
        }
    }
}
