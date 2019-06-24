using System;
using System.IO;
using System.Linq;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";

            string firstFileName = "FileOne.txt";

            string secondFileName = "FileTwo.txt";

            string resultFileName = "Output.txt";

            string firstFilePath = Path.Combine(path, firstFileName);

            string secondFilePath = Path.Combine(path, secondFileName);

            string[] linesFirstFile = File.ReadAllLines(firstFilePath);

            string[] linesSecondFile = File.ReadAllLines(secondFilePath);

            int size = Math.Min(linesFirstFile.Count(), linesSecondFile.Count());

            for (int i = 0; i < size; i++)
            {
                File.AppendAllText(resultFileName, linesFirstFile[i] + Environment.NewLine);

                File.AppendAllText(resultFileName, linesSecondFile[i] + Environment.NewLine);
            }

            if (linesFirstFile.Count() > size)
            {
                for (int j = size; j < linesFirstFile.Count(); j++)
                {
                    File.AppendAllText(resultFileName, linesFirstFile[j] + Environment.NewLine);
                }
            }

            if (linesSecondFile.Count() > size)
            {
                for (int j = size; j < linesSecondFile.Count(); j++)
                {
                    File.AppendAllText(resultFileName, linesSecondFile[j] + Environment.NewLine);
                }
            }
        }
    }
}
