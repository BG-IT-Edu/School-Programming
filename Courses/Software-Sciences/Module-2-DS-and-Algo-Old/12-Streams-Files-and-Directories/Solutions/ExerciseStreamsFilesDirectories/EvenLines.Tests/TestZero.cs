using NUnit.Framework;
using System.IO;

namespace EvenLines.Tests
{
    [TestFixture]
    public class TestZero
    {
        [Test]
        public void ProcessEvenLinesTest0()
        {
            var inputPath = "Input.txt";

            var input = @"-I was quick to judge him, but it wasn't his fault.
-Is this some kind of joke?! Is it?
-Quick, hide here. It is safer.
";

            File.WriteAllText(inputPath, input);

            var actualOutput = EvenLines.ProcessLines(inputPath);

            var expectedOutput = @"fault@ his wasn't it but him@ judge to quick was @I
safer@ is It here@ hide @Quick@";

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(EvenLines.ProcessLines)} output is incorrect!");
        }
    }
}