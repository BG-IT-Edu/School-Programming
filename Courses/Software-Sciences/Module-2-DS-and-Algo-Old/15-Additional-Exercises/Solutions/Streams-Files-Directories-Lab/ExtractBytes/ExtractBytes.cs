using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExtractBytes
{
    public class ExtractBytes
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] bytesRead = File.ReadAllBytes(binaryFilePath);

            byte[] bytesToExtract = File.ReadAllLines(bytesFilePath).Select(x => Convert.ToByte(x)).ToArray();

            byte[] extractedBytes = bytesRead.Where(byteRead => bytesToExtract.Contains(byteRead)).ToArray();
            
            File.WriteAllBytes(outputPath, extractedBytes);
        }
    }
}
