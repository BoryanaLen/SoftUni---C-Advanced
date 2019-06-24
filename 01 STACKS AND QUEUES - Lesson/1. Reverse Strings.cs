using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input.ToCharArray());

            while(stack.Count>0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
