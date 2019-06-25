using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> createCommand = Console.ReadLine().Split().ToList();

            List<string> list = createCommand.GetRange(1, createCommand.Count - 1).ToList();

            ListyIterator<string> myListyIterator;

            if (list.Count > 1)
            {
                myListyIterator = new ListyIterator<string>(list);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
                myListyIterator = new ListyIterator<string>();
                return;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                if(input == "HasNext")
                {
                    Console.WriteLine(myListyIterator.HasNext());
                }
                else if(input == "Print")
                {
                    myListyIterator.Print();
                }
                else if(input == "Move")
                {
                    Console.WriteLine(myListyIterator.Move());
                }
                else if(input == "PrintAll")
                {
                    myListyIterator.PrintAll();
                }
            }
        }
    }
}
