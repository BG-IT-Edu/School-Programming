using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace OddLines.Tests
{
    [TestFixture]
    public class TestThree
    {
        [Test]
        public void TakeOddLinesTest3()
        {
            var inputPath = "Input.txt";
            var outputPath = "Output.txt";

            var input = @"In fair Verona, where we lay our scene.
";

            File.WriteAllText(inputPath, input);

            OddLines.ExtractOddLines(inputPath, outputPath);

            var expectedOutput = @"";

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(OddLines.ExtractOddLines)} output is incorrect!");
        }
    }
}