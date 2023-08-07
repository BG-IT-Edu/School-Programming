using NUnit.Framework;
using System.IO;

namespace EvenLines.Tests
{
    [TestFixture]
    public class TestThree
    {
        [Test]
        public void ProcessEvenLinesTest3()
        {
            var inputPath = "Input.txt";

            var input = @"
This is bad test";
            File.WriteAllText(inputPath, input);

            var expectedOutput = @"";

            var actualOutput = EvenLines.ProcessLines(inputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(EvenLines.ProcessLines)} output is incorrect!");
        }
    }
}