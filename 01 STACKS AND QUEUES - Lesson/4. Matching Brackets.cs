using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> positionOpenBrackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    positionOpenBrackets.Push(i);
                }

                if(input[i] == ')')
                {
                    int startIndex = positionOpenBrackets.Pop();
                    int length = i - startIndex + 1;

                    string text = input.Substring(startIndex, length);

                    Console.WriteLine(text);
                }
            }
        }
    }
}
