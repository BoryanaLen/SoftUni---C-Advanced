using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            List<string> userNames = new List<string>();

            for (int i = 0; i < numberLines; i++)
            {
                string name = Console.ReadLine();

                if (!userNames.Contains(name))
                {
                    userNames.Add(name);
                }
            }

            foreach(var name in userNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
