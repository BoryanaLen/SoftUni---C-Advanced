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
            var readerWords = new StreamReader("words.txt");

            var readerText = new StreamReader("text.txt");

            Dictionary<string, int> words = new Dictionary<string, int>();

            using (readerWords)
            {
                string lineWords = readerWords.ReadLine();

                while (lineWords != null)
                {
                    List<string> wordsOnLine = lineWords
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    foreach(string word in wordsOnLine)
                    {
                        if (!words.ContainsKey(word))
                        {
                            words.Add(word, 0);
                        }
                    }

                    lineWords = readerWords.ReadLine();
                }
            }

            using (readerText)
            {
                string lineText = readerText.ReadLine();

                while (lineText != null)
                { 
                    var punctuation = lineText.Where(Char.IsPunctuation).Distinct().ToArray();

                    var wordsInLine = lineText.ToLower().Split().Select(x => x.Trim(punctuation));

                    foreach(string element in wordsInLine)
                    {
                        if (words.ContainsKey(element))
                        {
                            words[element]++;
                        }
                    }

                    lineText = readerText.ReadLine();
                }
            }

            var sortedWords = words.OrderByDescending(x => x.Value);

            using(var writer = new StreamWriter("Output.txt"))
            {
                foreach(var item in sortedWords)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
