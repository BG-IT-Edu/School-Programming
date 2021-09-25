using NUnit.Framework;
using System.IO;

namespace EvenLines.Tests
{
    [TestFixture]
    public class TestOne
    {
        [Test]
        public void ProcessEvenLinesTest1()
        {
            var inputPath = "Input.txt";

            var input = @"Two households, both alike in dignity,
From ancient grudge break to new mutiny,
Where civil blood makes civil hands unclean.
A pair of star-cross'd lovers take their life;
Do with their death bury their parents' strife.
";

            File.WriteAllText(inputPath, input);

            var expectedOutput = @"dignity@ in alike both households@ Two
unclean@ hands civil makes blood civil Where
strife@ parents' their bury death their with Do";

            var actualOutput = EvenLines.ProcessLines(inputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(EvenLines.ProcessLines)} output is incorrect!");
        }
    }
}