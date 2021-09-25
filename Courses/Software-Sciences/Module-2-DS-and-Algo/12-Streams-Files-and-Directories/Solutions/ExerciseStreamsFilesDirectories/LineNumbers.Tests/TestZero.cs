using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace LineNumbers.Tests
{
    [TestFixture]
    public class TestZero
    {
        readonly string input = "-I was quick to judge him, but it wasn't his fault.\r\n-Is this some kind of joke?! Is it?\r\n-Quick, hide here. It is safer.\r\n";
        readonly string expectedOutput = "Line 1: -I was quick to judge him, but it wasn't his fault. (37)(4)\r\nLine 2: -Is this some kind of joke?! Is it? (24)(4)\r\nLine 3: -Quick, hide here. It is safer. (22)(4)\r\n";

        [Test]
        public void LineNumbersTest0()
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