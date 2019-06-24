using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> follows = new Dictionary<string, List<string>>();

            Dictionary<string, List<string>> followed = new Dictionary<string, List<string>>();

            while (true)
            {
                string inputRow = Console.ReadLine();

                if(inputRow == "Statistics")
                {
                    break;
                }

 
                if(inputRow.Contains("joined"))
                {
                    List<string> commandInfo = inputRow.Split().ToList();

                    string name = commandInfo[0];

                    if (!followed.ContainsKey(name) && !follows.ContainsKey(name))
                    {
                        follows.Add(name, new List<string>());

                        followed.Add(name, new List<string>());
                    }
                }
                else if (inputRow.Contains("followed"))
                {
                    List<string> commandInfo = inputRow.Split().ToList();

                    string firstName = commandInfo[0];

                    string secondName = commandInfo[2];

                    if (follows.ContainsKey(firstName) && follows.ContainsKey(secondName) && firstName != secondName)
                    {
                        if (!follows[firstName].Contains(secondName))
                        {
                            follows[firstName].Add(secondName);
                        }

                        if (!followed[secondName].Contains(firstName))
                        {
                            followed[secondName].Add(firstName);
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {followed.Count()} vloggers in its logs.");

            var sortedNames = followed
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => follows[x.Key].Count());

            int number = 1;

            foreach (var name in sortedNames)
            {
                Console.WriteLine($"{number}. {name.Key} : {name.Value.Count()} followers, {follows[name.Key].Count()} following ");

                if(number == 1)
                {
                    if (name.Value.Count() > 0)
                    {
                        name.Value.Sort();

                        foreach (var item in name.Value)
                        {
                            Console.WriteLine($"*  {item}");
                        }
                    }
                }

                number++;
            }
        }
    }
}
