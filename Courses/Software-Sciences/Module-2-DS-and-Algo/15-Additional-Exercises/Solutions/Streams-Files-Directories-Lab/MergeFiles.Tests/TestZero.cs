using System;
using System.IO;
using NUnit.Framework;

namespace MergeFiles.Tests
{
    [TestFixture]
    public class TestZero
    {
        [Test]
        public void MergeTwoFilesInOneTest0()
        {
            var inputOnePath = "FileOne.txt";
            var inputTwoPath = "FileTwo.txt";
            var outputPath = @"Output.txt";

            var inputOne = @"1
3
5";
            var inputTwo = @"2
4
6";

            File.WriteAllText(inputOnePath, inputOne);
            File.WriteAllText(inputTwoPath, inputTwo);

            MergeFiles.MergeTextFiles(inputOnePath, inputTwoPath, outputPath);

            var expectedOutput = @"1
2
3
4
5
6";

            var actualOutput = File.ReadAllText(outputPath).TrimEnd();

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(MergeFiles.MergeTextFiles)} output is incorrect!");
        }
    }
}
