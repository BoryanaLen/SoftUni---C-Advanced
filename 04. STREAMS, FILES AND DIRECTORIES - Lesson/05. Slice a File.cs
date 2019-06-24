using System;
using System.IO;

namespace _05._Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var inputFile = new FileStream(@"files\sliceMe.txt", FileMode.Open))
            {
                long size = inputFile.Length;

                long partSize = (long)Math.Ceiling((double)size / 4);

                byte[] buffer = new byte[partSize];

                for (int i = 1; i <=4; i++)
                {
                    using(var outputFile = new FileStream($"files\\text-{i}.txt", FileMode.Create))
                    {
                        int readedBytes = inputFile.Read(buffer, 0, (int)partSize);

                        outputFile.Write(buffer, 0, readedBytes);
                    }
                }
            }
        }
    }
}
