using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedPerson = new SortedSet<Person>();

            HashSet<Person> hashPerson = new HashSet<Person>();

            for (int i = 0; i < numberRows; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person currentPerson = new Person(name, age);

                sortedPerson.Add(currentPerson);
                hashPerson.Add(currentPerson);
            }

            Console.WriteLine(sortedPerson.Count);
            Console.WriteLine(hashPerson.Count);
        }
    }
}
