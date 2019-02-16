using System;
using RegexLib;
using Xunit;

namespace RegexLibTest
{
    public class FileRegexTest
    {
        [Fact]
        public void Create_File_Regex()
        {
            var obj = new FileRegex();
            Assert.NotNull(obj);
        }

        [Fact]
        public void Get_Filename_From_Windows_Path()
        {
            // Arrange.
            var regext = new FileRegex();
            var filename = "myfile.json";
            var path = $"C:\\this\\is\\a\\path\\{filename}";

            // Act.
            var actual = regext.GetFileName(path);

            // Assert.
            Assert.Equal(filename, actual);
        }

        [Fact]
        public void Get_Filename_From_Linux_Path()
        {
            // Arrange.
            var regext = new FileRegex();
            var filename = "myfile.json";
            var path = $"/this/is/a/path/{filename}";

            // Act.
            var actual = regext.GetFileName(path);

            // Assert.
            Assert.Equal(filename, actual);
        }
    }
}