using NUnit.Framework;
using System.IO;
using System.Text;

namespace FolderSize.Tests
{
    [TestFixture]
    public class TestZero
    {
        private readonly byte[] dataFileContent = Encoding.ASCII.GetBytes("Some random text.");
        private readonly byte[] dataFile2Content = Encoding.ASCII.GetBytes("Another random text. With more words. And just a little bit bigger size.");
        
        [SetUp]
        public void Setup()
        {
            Directory.CreateDirectory("TestFolder");
            CreateFile(@"TestFolder\datafile.txt", dataFileContent);

            Directory.CreateDirectory(@"TestFolder\TestFolder2");
            CreateFile(@"TestFolder\TestFolder2\dataFile2.txt", dataFile2Content);
        }
        [Test]
        public void GetFilesSizesTest0()
        {
            const string folderPath = "TestFolder";
            const string outputPath = "Output.txt";

            FolderSize.GetFolderSize(folderPath, outputPath);

            const string expectedOutput = "0.0869140625 KB";
            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(FolderSize.GetFolderSize)} output is incorrect!");
        }

        private static string CreateFile(string name, byte[] content)
        {
            File.WriteAllBytes(name, content);
            return name;
        }
    }
}
