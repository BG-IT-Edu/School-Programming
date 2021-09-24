using NUnit.Framework;
using System.IO;

namespace OddLines.Tests
{
    [TestFixture]
    public class TestZero
    {
        [Test]
        public void TakeOddLinesTest0()
        {
            var inputPath = "Input.txt";
            var outputPath = "Output.txt";

            var input = @"Two households, both alike in dignity,
In fair Verona, where we lay our scene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.
";

            File.WriteAllText(inputPath, input);

            OddLines.ExtractOddLines(inputPath, outputPath);

            var expectedOutput = @"In fair Verona, where we lay our scene,
Where civil blood makes civil hands unclean.
A pair of star-cross'd lovers take their life;
Do with their death bury their parents' strife.
";

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(OddLines.ExtractOddLines)} output is incorrect!");
        }
    }
}