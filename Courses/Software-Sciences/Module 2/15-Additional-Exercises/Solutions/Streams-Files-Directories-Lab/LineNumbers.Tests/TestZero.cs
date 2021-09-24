using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace LineNumbers.Tests
{
    [TestFixture]
    public class TestZero
    {
        readonly string input = @"Two households, both alike in dignity,
In fair Verona, where we lay our scene,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
From forth the fatal loins of these two foes
A pair of star-cross'd lovers take their life;
Whose misadventured piteous overthrows
Do with their death bury their parents' strife.
";
        readonly string expectedOutput = @"1. Two households, both alike in dignity,
2. In fair Verona, where we lay our scene,
3. From ancient grudge break to new mutiny,
4. Where civil blood makes civil hands unclean.
5. From forth the fatal loins of these two foes
6. A pair of star-cross'd lovers take their life;
7. Whose misadventured piteous overthrows
8. Do with their death bury their parents' strife.
";

        [Test]
        public void RewriteFileWithLineNumbersTest0()
        {
            var inputPath = "Input.txt";
            var outputPath = "Output.txt";

            File.WriteAllText(inputPath, input);
            LineNumbers.RewriteFileWithLineNumbers(inputPath, outputPath);

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(LineNumbers.RewriteFileWithLineNumbers)} output is incorrect!");
        }
    }
}