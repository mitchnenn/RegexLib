using System;
using System.IO;
using RegexLib;
using Xunit;

namespace RegexLibTest
{
    public class FileRegexTest
    {
        [Theory]
        [InlineData("myfile.json", "C:\\this\\is\\a\\path\\")]
        [InlineData("myfile.aggregated.json", "C:\\this\\is\\a\\path\\")]
        [InlineData("myfile.json", "/this/is/a/path/")]
        [InlineData("myfile.aggregated.json", "/this/is/a/path/")]
        public void Try_Different_Filenames_To_Parse(string filename, string path)
        {
            // Arrange.
            var regext = new FileRegex();
            var fullPath = Path.Combine(path, filename);

            // Act.
            var actual = regext.GetFileName(fullPath);

            // Assert.
            Assert.Equal(filename, actual);
        }
    }
}