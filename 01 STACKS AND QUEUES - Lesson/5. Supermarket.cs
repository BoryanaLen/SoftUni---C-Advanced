using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    Console.WriteLine($"{people.Count} people remaining.");
                    break;
                }

                if(input == "Paid")
                {
                    foreach(var name in people)
                    {
                        Console.WriteLine(name);
                    }

                    people.Clear();
                }
                else
                {
                    people.Enqueue(input);
                }
            }
        }
    }
}
