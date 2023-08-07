using System.IO;
using NUnit.Framework;

namespace LineNumbers.Tests
{
    [TestFixture]
    public class TestOne
    {
        readonly string input = "Two households, both alike in dignity,\r\nFrom ancient grudge break to new mutiny,\r\nWhere civil blood makes civil hands unclean.\r\nA pair of star-cross'd lovers take their life;\r\nDo with their death bury their parents' strife.\r\n";

        private readonly string expectedOutput = "Line 1: Two households, both alike in dignity, (31)(2)\r\nLine 2: From ancient grudge break to new mutiny, (33)(1)\r\nLine 3: Where civil blood makes civil hands unclean. (37)(1)\r\nLine 4: A pair of star-cross'd lovers take their life; (36)(3)\r\nLine 5: Do with their death bury their parents' strife. (38)(2)\r\n";
        [Test]
        public void LineNumbersTest1()
        {
            var inputPath = "Input.txt";
            var outputPath = "Output.txt";

            File.WriteAllText(inputPath, input);

            LineNumbers.ProcessLines(inputPath, outputPath);
            
            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(LineNumbers.ProcessLines)} output is incorrect!");
        }
    }
}