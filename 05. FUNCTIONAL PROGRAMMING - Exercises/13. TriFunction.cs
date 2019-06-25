using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> IsNameSameLength = IsSameLength;

            string name = FindNameWithLength(names, number);

            Console.WriteLine(name);
        }

        public static string FindNameWithLength (List<string>allNames, int length )
        {
            string name = string.Empty;

            for (int i = 0; i < allNames.Count; i++)
            {
                if (IsSameLength(allNames[i],length))
                {
                    name = allNames[i];

                    break;
                }
            }

            return name;
        }

        public static bool IsSameLength (string name, int length)
        {
            bool result = false;

            int sumCharacters = name.Sum(x => x);

            if(sumCharacters >= length)
            {
                result = true;
            }

            return result;
        }
    }
}
