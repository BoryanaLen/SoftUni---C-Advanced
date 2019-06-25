using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                List<string> inputInfo = input.Split().ToList();

                string name = inputInfo[0];
                int age = int.Parse(inputInfo[1]);
                string town = inputInfo[2];

                Person currentPerson = new Person(name, age, town);

                people.Add(currentPerson);
            }

            int position = int.Parse(Console.ReadLine());

            int index = position - 1;

            if (index < 0 || index >= people.Count)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Person personToCompare = people[index];

                int same = 0;
                int notSame = 0;

                foreach(var item in people)
                {
                    if(item.CompareTo(personToCompare) == 0)
                    {
                        same++;
                    }
                    else
                    {
                        notSame++;
                    }
                }

                if (same == 1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine($"{same} {notSame} {people.Count}");
                }
            }
        }
    }
}
