using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            int length = sequence.Length;

            if (length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> openBrackets = new Stack<char>();

            int count = 0;

            for (int i = 0; i < length; i++)
            {
                char symbol = sequence[i];

                if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    openBrackets.Push(symbol);
                }
                else if (symbol == '}' || symbol == ']' || symbol == ')')
                {
                    if (openBrackets.Count > 0)
                    {
                        char symbolOpen = openBrackets.Pop();

                        if ((symbol == '}' && symbolOpen == '{') || (symbol == ')' && symbolOpen == '(') || (symbol == ']' && symbolOpen == '['))
                        {
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }

            if(count == length / 2)
            {
                Console.WriteLine("YES");
            }
           
        }
    }
}
