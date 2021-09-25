using System;
using System.IO;
using System.Linq;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] sourceFileBytes = File.ReadAllBytes(sourceFilePath);
            int fileSize = sourceFileBytes.Length;
            int partOneSize = fileSize / 2 + fileSize % 2;

            byte[] partOneBytes = sourceFileBytes.Take(partOneSize).ToArray();
            File.WriteAllBytes(partOneFilePath, partOneBytes);

            byte[] partTwoBytes = sourceFileBytes.Skip(partOneSize).ToArray();
            File.WriteAllBytes(partTwoFilePath, partTwoBytes);
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] partOneBytes = File.ReadAllBytes(partOneFilePath);
            byte[] partTwoBytes = File.ReadAllBytes(partTwoFilePath);

            byte[] joinedFileBytes = partOneBytes.Concat(partTwoBytes).ToArray();
            File.WriteAllBytes(joinedFilePath, joinedFileBytes);
        }
    }
}