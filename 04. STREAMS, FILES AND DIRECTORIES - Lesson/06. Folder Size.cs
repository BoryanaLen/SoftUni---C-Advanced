using System;
using System.IO;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "TestFolder";

            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            FileInfo[] allFiles = directoryInfo.GetFiles("*.*");

            double totalSize = 0;

            foreach(var file in allFiles)
            {
                double size = file.Length * 0.00000095367432;

                totalSize += size;
            }

            File.AppendAllText("Output.txt", totalSize.ToString());
        }
    }
}
