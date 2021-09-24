using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double size = 0;

            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            FileInfo[] filesInfos = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fileInfo in filesInfos)
            {
                size += fileInfo.Length;
            }

            size = size / 1024;

            File.WriteAllText(outputFilePath, size.ToString() + " KB");
        }
    }
}
