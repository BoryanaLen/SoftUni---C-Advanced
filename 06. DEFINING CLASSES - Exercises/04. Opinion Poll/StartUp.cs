using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberLines; i++)
            {
                List<string> inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string name = inputInfo[0];
                int age = int.Parse(inputInfo[1]);

                Person newMember = new Person(name, age);

                if (newMember != null)
                {
                    family.AddMember(newMember);
                }
            }

            var modifiedFamily = family.Members.Where(x => x.Age > 30).OrderBy(x => x.Name);

            foreach(var person in modifiedFamily)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
