using System.IO;
using NUnit.Framework;

namespace LineNumbers.Tests
{
    [TestFixture]
    public class TestThree
    {
        readonly string input = @"";
        readonly string expectedOutput = @"";

        [Test]
        public void LineNumbersTest3()
        {
            var inputPath = Directory.GetCurrentDirectory() + @"\Input.txt";
            var outputPath = @"Output.txt";

            File.WriteAllText(inputPath, input);

            LineNumbers.ProcessLines(inputPath, outputPath);

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(LineNumbers.ProcessLines)} output is incorrect!");
        }
    }
}