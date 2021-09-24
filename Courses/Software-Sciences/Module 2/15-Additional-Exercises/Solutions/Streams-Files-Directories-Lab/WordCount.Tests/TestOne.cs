using NUnit.Framework;
using System.IO;

namespace WordCount.Tests
{
    [TestFixture]
    public class TestOne
    {
        [Test]
        public void GetFileWithWordsCountFromTextTest1()
        {
            var wordsPath = "words.txt";
            var textPath = "text.txt";
            var outputPath = "Output.txt";

            var words = @"is fault";
            var text = @"-I was quick to judge him, but it wasn't his fault.
-Is this some kind of joke?! Your fault!
-Quick, hide here…It is safer.
";

            File.WriteAllText(wordsPath, words);
            File.WriteAllText(textPath, text);

            WordCount.CalculateWordCounts(wordsPath, textPath, outputPath);

            var expectedOutput = @"is - 2
fault - 2";

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(WordCount.CalculateWordCounts)} output is incorrect!");
        }
    }
}