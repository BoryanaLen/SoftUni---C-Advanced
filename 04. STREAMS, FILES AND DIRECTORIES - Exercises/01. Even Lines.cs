using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> symbolsToReplace = new List<char>() { '-', ',', '.', '!', '?' };

            string path = "files";

            string fileName = "text.txt";

            string filePath = Path.Combine(path, fileName);

            using (var reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();

                int numberLine = 0;

                while (line != null)
                {
                    if (numberLine % 2 == 0)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (symbolsToReplace.Contains(line[i]))
                            {
                                line = line.Replace(line[i], '@');
                            }
                        }

                        List<string> words = line.Split().ToList();

                        words.Reverse();

                        Console.WriteLine(string.Join(' ', words));
                    }

                    line = reader.ReadLine();

                    numberLine++;
                }
            }
        }
    }
}
