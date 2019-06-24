using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOperations = int.Parse(Console.ReadLine());

            string text = string.Empty;

            Stack<string> undoCommands = new Stack<string>();

            for (int i = 0; i < numberOperations; i++)
            {
                List<string> commandInfo = Console.ReadLine().Split().ToList();

                int commandNumber = int.Parse(commandInfo[0]);

                if (commandNumber == 1)
                {
                    undoCommands.Push(text);

                    text += commandInfo[1];
                }
                else if (commandNumber == 2)
                {
                    int count = int.Parse(commandInfo[1]);

                    undoCommands.Push(text);

                    text = text.Substring(0, text.Length - count);
                }
                else if (commandNumber == 3)
                {
                    int position = int.Parse(commandInfo[1]) - 1;

                    Console.WriteLine(text[position]);
                }
                else if (commandNumber == 4)
                {
                    text = undoCommands.Pop();
                }
            }
        }
    }
}
