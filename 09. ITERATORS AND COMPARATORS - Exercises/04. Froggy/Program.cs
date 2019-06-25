using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            Lake lake = new Lake(stones);

            StringBuilder sb = new StringBuilder();

            foreach(int stone in lake)
            {
                sb.Append($"{stone}, ");
            }

            sb.Remove(sb.Length - 2, 2);

            Console.WriteLine(sb.ToString());
        }
    }
}
