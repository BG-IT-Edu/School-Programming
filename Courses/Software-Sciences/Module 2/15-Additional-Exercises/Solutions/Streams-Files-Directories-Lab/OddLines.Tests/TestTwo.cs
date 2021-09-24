using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace OddLines.Tests
{
    [TestFixture]
    public class TestTwo
    {
        [Test]
        public void TakeOddLinesTest2()
        {
            var inputPath = "Input.txt";
            var outputPath = "Output.txt";

            var input = @"Two households, both alike in dignity,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
A pair of star-cross'd lovers take their life;
Do with their death bury their parents' strife.
Two households, both alike in dignity,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
A pair of star-cross'd lovers take their life;
Do with their death bury their parents' strife.
";

            File.WriteAllText(inputPath, input);

            OddLines.ExtractOddLines(inputPath, outputPath);

            var expectedOutput = @"From ancient grudge break to new mutiny,
A pair of star-cross'd lovers take their life;
Two households, both alike in dignity,
Where civil blood makes civil hands unclean.
Do with their death bury their parents' strife.
";

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(OddLines.ExtractOddLines)} output is incorrect!");
        }
    }
}