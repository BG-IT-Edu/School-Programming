using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Text;

namespace CopyDirectory.Tests
{
    [TestFixture]
    public class TestTwo
    {
        private string directory;
        private string destination;

        private readonly byte[] dataFileContent = Encoding.ASCII.GetBytes("Some random text.");
        private readonly byte[] dataFile2Content = Encoding.ASCII.GetBytes("Another random text. With more words. And just a little bit bigger size.");

        [SetUp]
        public void Setup()
        {
            directory = Directory.GetCurrentDirectory() + @"\TestFolder";
            Directory.CreateDirectory(directory);

            CreateFile(@"TestFolder\datafile.txt", dataFileContent);
            CreateFile(@"TestFolder\binary.bin", dataFileContent);
            CreateFile(@"TestFolder\txt2.txt", dataFile2Content);
            CreateFile(@"TestFolder\what.bin", dataFile2Content);

            destination = directory + @"\DestinationFolder";
            Directory.CreateDirectory(destination);

            CreateFile(destination + @"\binary.bin", dataFileContent);
            CreateFile(destination + @"\txt2.txt", dataFile2Content);
        }
        [Test]
        public void CopyDirectoryTest2()
        {
            CopyDirectory.CopyAllFiles(directory, destination);

            Assert.IsTrue(AreFileContentsEqual(directory, destination),
                $"{nameof(CopyDirectory.CopyAllFiles)} output is incorrect!");
        }

        private static string CreateFile(string name, byte[] content)
        {
            File.WriteAllBytes(name, content);
            return name;
        }

        public static bool AreFileContentsEqual(string pathOne, string pathTwo)
        {
            var sourceFiles = Directory.GetFiles(pathOne);
            var destinationFiles = Directory.GetFiles(pathTwo);

            if (sourceFiles.Length != destinationFiles.Length)
            {
                return false;
            }

            for (int i = 0; i < sourceFiles.Length; i++)
            {
                if (!File.ReadAllBytes(sourceFiles[i]).SequenceEqual(File.ReadAllBytes(destinationFiles[i])))
                {
                    return false;
                }
            }

            return true;
        }
    }
}