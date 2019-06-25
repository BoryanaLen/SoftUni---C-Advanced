using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                else if (command == "Pop")
                {
                    myStack.Pop();
                }
                else
                {
                    command = command.Remove(0, 5);

                    int[] list = command.Split(", ").Select(int.Parse).ToArray();

                    myStack.Push(list);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in myStack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
