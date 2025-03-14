﻿using System.IO;
using NUnit.Framework;

namespace LineNumbers.Tests
{
    [TestFixture]
    public class TestTwo
    {
        readonly string input = @"Two households, both alike in dignity,
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
        readonly string expectedOutput = @"1. Two households, both alike in dignity,
2. From ancient grudge break to new mutiny,
3. Where civil blood makes civil hands unclean.
4. A pair of star-cross'd lovers take their life;
5. Do with their death bury their parents' strife.
6. 
7. Two households, both alike in dignity,
8. From ancient grudge break to new mutiny,
9. Where civil blood makes civil hands unclean.
10. A pair of star-cross'd lovers take their life;
11. Do with their death bury their parents' strife.
";

        [Test]
        public void RewriteFileWithLineNumbersTest2()
        {
            var inputPath = "Input.txt";
            var outputPath = "Output.txt";

            File.WriteAllText(inputPath, input);

            LineNumbers.RewriteFileWithLineNumbers(inputPath, outputPath);

            var actualOutput = File.ReadAllText(outputPath);

            Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
                $"{nameof(LineNumbers.RewriteFileWithLineNumbers)} output is incorrect!");
        }
    }
}