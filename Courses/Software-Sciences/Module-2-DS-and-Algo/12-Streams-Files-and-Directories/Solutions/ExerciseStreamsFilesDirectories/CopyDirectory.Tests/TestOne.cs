using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Text;

namespace CopyDirectory.Tests
{
    [TestFixture]
    public class TestOne
    {
        private string directory;
        private string destination;

        private readonly byte[] dataFileContent = Encoding.ASCII.GetBytes("Some random text.");
        private readonly byte[] dataFile2Content = Encoding.ASCII.GetBytes("Another random text. With more words.");

        [SetUp]
        public void Setup()
        {
            directory = Directory.GetCurrentDirectory() + @"\TestFolder";
            Directory.CreateDirectory(directory);

            CreateFile(@"TestFolder\test.txt", dataFileContent);
            CreateFile(@"TestFolder\someBin.bin", dataFileContent);
            CreateFile(@"TestFolder\txt.txt", dataFile2Content);
            CreateFile(@"TestFolder\thisIsBin.bin", dataFile2Content);
            CreateFile(@"TestFolder\big.txt", dataFileContent.Concat(dataFile2Content).ToArray());
            CreateFile(@"TestFolder\image.png", dataFileContent.Concat(dataFile2Content).ToArray());

            destination = directory + @"\DestinationFolder";
            Directory.CreateDirectory(destination);
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

        [Test]
        public void CopyDirectoryTest1()
        {
            CopyDirectory.CopyAllFiles(directory, destination);

            Assert.IsTrue(AreFileContentsEqual(directory, destination),
                $"{nameof(CopyDirectory.CopyAllFiles)} output is incorrect!");
        }
    }
}
