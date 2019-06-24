using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo(".");

            FileInfo[] allFiles = directoryInfo.GetFiles();

            foreach(FileInfo currentFile in allFiles)
            {
                double size =  currentFile.Length / 1024d;

                string name = currentFile.Name;

                string extension = currentFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }

                if (!dirInfo[extension].ContainsKey(name))
                {
                    dirInfo[extension].Add(name, size);
                }
            }

            var sortedDictionary = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            foreach(var extension in sortedDictionary)
            {
                File.AppendAllText(path, extension.Key + Environment.NewLine);

                foreach(var file in extension.Value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{file.Key} - {Math.Round(file.Value, 3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
