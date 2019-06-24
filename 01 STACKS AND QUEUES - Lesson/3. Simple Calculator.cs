using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] chars = Console.ReadLine().Split().ToArray();

            Stack<string> stack = new Stack<string>(chars.Reverse());

            int result = 0;

            int firstNumber = int.Parse(stack.Pop());

            result += firstNumber;

            while (stack.Count > 1)
            {
                string symbol = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if(symbol == "+")
                {
                    result += secondNumber;
                }
                else if(symbol == "-")
                {
                    result -= secondNumber;
                }
            }

            Console.WriteLine(result);
        }
    }
}
