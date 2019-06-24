using System;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";

            string inputFileName = "text.txt";

            string outputFileName = "output.txt";

            string inputFilePath = Path.Combine(path, inputFileName);

            string[] textLines = File.ReadAllLines(inputFilePath);

            int lineCounter = 1;

            foreach(var line in textLines)
            {
                int countLetters = line.Count(x => Char.IsLetter(x));

                int countPunctuation = line.Count(x => Char.IsPunctuation(x));

                File.AppendAllText(outputFileName,($"Line {lineCounter}: {line} ({countLetters})({countPunctuation})" +
                    $"{Environment.NewLine}"));

                lineCounter++;
            }
        }
    }
}
