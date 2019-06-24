using System;
using System.Collections.Generic;

namespace _6._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int count = int.Parse(Console.ReadLine());

            Queue<string> names = new Queue<string>(input);

            while(names.Count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    names.Enqueue(names.Dequeue());
                }

                Console.WriteLine($"Removed {names.Dequeue()}");
            }

            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
