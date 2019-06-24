using System;
using System.IO;
using System.IO.Compression;

namespace _06._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";

            string fileName = "copyMe.png";

            string zippedFilePath = @"..\..\..\myZip.zip";

            string targetPath = Path.Combine(path, fileName);

            using(var archive = ZipFile.Open(zippedFilePath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(targetPath, Path.GetFileName(targetPath));
            }
        }
    }
}
