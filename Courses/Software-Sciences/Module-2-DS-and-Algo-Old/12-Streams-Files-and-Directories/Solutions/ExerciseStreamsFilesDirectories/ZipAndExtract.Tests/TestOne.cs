using System;
using System.IO;
using System.IO.Compression;
using NUnit.Framework;

namespace ZipAndExtract.Tests
{
    [TestFixture]
    public class TestOne
    {
        [Test]
        public void Test_ZipToArchive()
        {
            // Arrange
            string fileContent = "some text... " + new string('a', 1000);
            var inputFile = "input" + DateTime.Now.Ticks + ".txt";
            File.WriteAllText(inputFile, fileContent);
            var zipFile = "zipfile" + DateTime.Now.Ticks + ".zip";

            // Act
            ZipAndExtract.ZipFileToArchive(inputFile, zipFile);

            // Assert
            FileAssert.Exists(zipFile);
            var zip = ZipFile.OpenRead(zipFile);
            Assert.AreEqual(zip.Entries.Count, 1);
            Assert.AreEqual(zip.Entries[0].Name, inputFile);
            var zipFileContent = "outputFromZip" + DateTime.Now.Ticks + ".txt";
            zip.Entries[0].ExtractToFile(zipFileContent);
            FileAssert.AreEqual(inputFile, zipFileContent);
        }
    }
}
