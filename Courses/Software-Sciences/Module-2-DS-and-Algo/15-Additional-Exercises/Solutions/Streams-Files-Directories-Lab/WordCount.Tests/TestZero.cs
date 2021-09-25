using NUnit.Framework;
using System.IO;

namespace WordCount.Tests
{
    [TestFixture]
    public class TestZero
    {
        [Test]
        public void GetFileWithWordsCountFromTextTest0()
        {
            var wordsPath = "words.txt";
            var textPath = "text.txt";
            var outputPath = "Output.txt";

            var words = @"quick is fault";
            var text = @"-I was quick to judge him, but it wasn't his fault.
-Is this some kind of joke?! Is it?
-Quick, hide here…It is safer.
";
            File.WriteAllText(wordsPath, words);
            File.WriteAllText(textPath, text);

            WordCount.CalculateWordCounts(wordsPath, textPath, outputPath);

            var expectedOutput = @"is - 3
quick - 2
fault - 1";

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(WordCount.CalculateWordCounts)} output is incorrect!");
        }
    }
}
