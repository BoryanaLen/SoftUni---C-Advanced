using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";

            string inputFileNameWords = "words.txt";

            string inputFileNameText = "text.txt";

            string pathWords = Path.Combine(path, inputFileNameWords);

            string pathText = Path.Combine(path, inputFileNameText);

            string[] textLines = File.ReadAllLines(pathText);

            string[] words = File.ReadAllLines(pathWords);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach(var word in words)
            {
                string wordToLower = word.ToLower();

                if (!wordsCount.ContainsKey(wordToLower))
                {
                    wordsCount.Add(wordToLower, 0);
                }
            }

            char[] punctuations = new char[] { '-', ',', '.', '!', '?',' ','\'',':',';' };

            foreach (var line in textLines)
            {
                string[] currentLineWords = line
                    .ToLower()
                    .Split(punctuations, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach(var currentWord in currentLineWords)
                {
                    if (wordsCount.ContainsKey(currentWord))
                    {
                        wordsCount[currentWord]++;
                    }
                }
            }

            string actualResultFileName = "actualResults.txt";

            string expectedResultFileName = "expectedResult.txt";

            foreach(var item in wordsCount)
            {
                File.AppendAllText(actualResultFileName, $"{item.Key} - {item.Value}{Environment.NewLine}");
            }

            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultFileName, $"{item.Key} - {item.Value}{Environment.NewLine}");
            }

        }
    }
}
