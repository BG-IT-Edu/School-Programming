using System;
using System.IO;
using NUnit.Framework;

namespace ZipAndExtract.Tests
{
    [TestFixture]
    public class TestZero
    {
        [Test]
        public void Test_ZipAndExtract()
        {
            // Arrange
            string fileContent = "some text... " + new string('a', 1000);
            var inputFile = "input" + DateTime.Now.Ticks + ".txt";
            File.WriteAllText(inputFile, fileContent);
            var zipFile = "zipfile" + DateTime.Now.Ticks + ".zip";
            var outputFile = "output" + DateTime.Now.Ticks + ".txt";

            // Act
            ZipAndExtract.ZipFileToArchive(inputFile, zipFile);
            ZipAndExtract.ExtractFileFromArchive(zipFile, inputFile, outputFile);

            // Assert
            FileAssert.Exists(zipFile);
            FileAssert.AreEqual(inputFile, outputFile);
        }
    }
}
