using System;
using System.IO;
using System.IO.Compression;
using NUnit.Framework;

namespace ZipAndExtract.Tests
{
    [TestFixture]
    public class TestTwo
    {
        [Test]
        public void Test_ExtractArchive()
        {
            // Arrange
            string fileContent = "some text... " + new string('a', 1000);
            var inputFile = "input" + DateTime.Now.Ticks + ".txt";
            File.WriteAllText(inputFile, fileContent);
            var zipFile = "zipfile" + DateTime.Now.Ticks + ".zip";
            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                var fileNameOnly = Path.GetFileName(inputFile);
                archive.CreateEntryFromFile(inputFile, fileNameOnly);
            }

            // Act
            var outputFile = "output" + DateTime.Now.Ticks + ".txt";
            ZipAndExtract.ExtractFileFromArchive(zipFile, inputFile, outputFile);

            // Assert
            FileAssert.Exists(outputFile);
            FileAssert.AreEqual(inputFile, outputFile);
        }
    }
}
