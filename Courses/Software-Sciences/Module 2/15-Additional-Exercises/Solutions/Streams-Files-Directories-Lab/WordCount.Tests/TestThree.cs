using NUnit.Framework;
using System.IO;

namespace WordCount.Tests
{
    [TestFixture]
    public class TestThree
    {
        [Test]
        public void GetFileWithWordsCountFromTextTest3()
        {
            var wordsPath = "words.txt";
            var textPath = "text.txt";
            var outputPath = "Output.txt";

            var words = @"1 two judge";
            var text = @"-I was quick to judge him, but 1 it wasn't his problem.
-Is this some kind of joke?! Is it?!
-Quick, hide here…It is safer.
-Do not tell the judge! Judge Bucket is prejudiced!
";

            File.WriteAllText(wordsPath, words);
            File.WriteAllText(textPath, text);

            WordCount.CalculateWordCounts(wordsPath, textPath, outputPath);

            var expectedOutput = @"judge - 3
1 - 1
two - 0";

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(WordCount.CalculateWordCounts)} output is incorrect!");
        }
    }
}
