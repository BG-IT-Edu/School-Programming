using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal.Tests
{
    [TestFixture]
    public class TestOne
    {
        private string directory;
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
        }

        private static string CreateFile(string name, byte[] content)
        {
            File.WriteAllBytes(name, content);
            return name;
        }

        [Test]
        public void TraverseDirectoryTest1()
        {
            const string expectedOutput =
                ".txt\r\n--txt-2.txt - 0.000kb\r\n--txt-3.txt - 0.000kb\r\n--txt2.txt - 0.000kb\r\n--big.txt - 0.000kb\r\n--txt.txt - 0.000kb\r\n--datafile.txt - 0.000kb\r\n--test.txt - 0.000kb\r\n--txt-1.txt - 0.000kb\r\n.bin\r\n--what.bin - 0.000kb\r\n--thisIsBin.bin - 0.000kb\r\n--binary.bin - 0.000kb\r\n--someBin.bin - 0.000kb\r\n.png\r\n--pngFile-Copy.png - 9.000kb\r\n--pngFile.png - 9.000kb\r\n--image.png - 0.000kb";

            var actualOutput = DirectoryTraversal.TraverseDirectory(directory);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(DirectoryTraversal.TraverseDirectory)} output is incorrect!");
        }
    }
}
