using NUnit.Framework;
using System.IO;

namespace EvenLines.Tests
{
    [TestFixture]
    public class TestTwo
    {
        [Test]
        public void ProcessEvenLinesTest2()
        {
            var inputPath = "Input.txt";

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

            var expectedOutput = @"dignity@ in alike both households@ Two
unclean@ hands civil makes blood civil Where
strife@ parents' their bury death their with Do
mutiny@ new to break grudge ancient From
life; their take lovers star@cross'd of pair A";

            var actualOutput = EvenLines.ProcessLines(inputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(EvenLines.ProcessLines)} output is incorrect!");
        }
    }
}