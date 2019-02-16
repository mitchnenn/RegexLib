using System.Text.RegularExpressions;

namespace RegexLib
{
    public class FileRegex : Regex
    {
        public FileRegex() 
            : base(@"\w+:\\(\w+\\)*(?<file>\w*\.\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase)
        {
            
        }

        public string GetFileName(string fullPath)
        {
            return Match(fullPath).Groups["file"].Value;
        }
    }
}