using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MergeFiles.Tests
{
    [TestFixture]
    public class TestThree
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
            var inputTwo = @"";

            File.WriteAllText(inputOnePath, inputOne);
            File.WriteAllText(inputTwoPath, inputTwo);

            MergeFiles.MergeTextFiles(inputOnePath, inputTwoPath, outputPath);

            var expectedOutput = @"1
3
5";

            var actualOutput = File.ReadAllText(outputPath).TrimEnd();

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(MergeFiles.MergeTextFiles)} output is incorrect!");
        }
    }
}
