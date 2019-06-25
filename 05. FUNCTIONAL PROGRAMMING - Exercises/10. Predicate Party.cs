using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string stringToContain = string.Empty;

            int length = 0;

            Predicate<string> isTheNameStartsWith = name => name.IndexOf(stringToContain) == 0;

            Predicate<string> isTheNameEndsWith =
                name => name.IndexOf(stringToContain) == name.Length - stringToContain.Length;

            Predicate<string> isTheSameLength = name => name.Length == length;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Party!")
                {
                    break;
                }

                List<string> commandInfo = input.Split().ToList();

                string action = commandInfo[0];

                string command = commandInfo[1];

                List<string> newPeople = new List<string>();

                if(command == "StartsWith")
                {
                    stringToContain = commandInfo[2];

                    newPeople = people.Where(name => isTheNameStartsWith(name)).ToList();
                }
                else if(command == "EndsWith")
                {
                    stringToContain = commandInfo[2];

                    newPeople = people.Where(name => isTheNameEndsWith(name)).ToList();
                }
                else if(command == "Length")
                {
                    length = int.Parse(commandInfo[2]);

                    newPeople = people.Where(name => isTheSameLength(name)).ToList();
                }

                if(action == "Remove")
                {
                    people = people.Where(x => !newPeople.Contains(x)).ToList();
                }
                else if(action == "Double")
                {
                    foreach(string name in newPeople)
                    {
                        int index = people.IndexOf(name);

                        people.Insert(index + 1, name);
                    }
                }
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }          
        }
    }
}
