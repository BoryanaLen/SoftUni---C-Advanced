using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";

            string fileName = "copyMe.png";

            string copiedFileName = "copyMe-copy.png";

            string filePath = Path.Combine(path, fileName);

            using(FileStream streamReader = new FileStream(filePath, FileMode.Open))
            {
                using(FileStream streamWriter = new FileStream(copiedFileName, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];

                        int size = streamReader.Read(byteArray, 0, byteArray.Length);

                        if(size == 0)
                        {
                            break;
                        }

                        streamWriter.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}
